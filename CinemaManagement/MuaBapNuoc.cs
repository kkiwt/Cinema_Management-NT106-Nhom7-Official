using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{

    public partial class MuaBapNuoc : Form
    {

        public PaymentResult _lastPaymentResult;
        public UserInfo _user;
        private ClientTCP _client = new ClientTCP();
        private string _idThanhToan;
        private System.Windows.Forms.Timer _paymentTimer;
        private Form _currentQrPopup;
        public MuaBapNuoc(UserInfo user)
        {
            _user = user;
            InitializeComponent();
        }

        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (countAllBapNuoc() == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = TinhTongTien();
            await CreatePaymentQRCode(); // Lưu _idThanhToan

            var account = "0979151133";
            var bank = "MBBank";
            var vnTime = DateTime.UtcNow.AddHours(7);
            _idThanhToan = $"TT{vnTime:yyyyMMddHHmmss}";
            var qrUrl = $"https://qr.sepay.vn/img?acc={account}&bank={bank}&amount={totalAmount}&des={_idThanhToan}&template=compact&download=false";

            // --- Tạo popup QR ---
            _currentQrPopup = new Form()
            {
                Width = 350,
                Height = 450,
                Text = "Quét QR để thanh toán",
                StartPosition = FormStartPosition.CenterParent
            };

            PictureBox pic = new PictureBox()
            {
                Width = 280,
                Height = 280,
                SizeMode = PictureBoxSizeMode.Zoom,
                Left = 30,
                Top = 20
            };
            pic.Load(qrUrl);
            _currentQrPopup.Controls.Add(pic);

            Label lbl = new Label()
            {
                Text = "Tổng tiền: " + totalAmount.ToString("N0") + " VND",
                AutoSize = true,
                Top = 320,
                Left = 30,
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            _currentQrPopup.Controls.Add(lbl);

            Button btnClose = new Button()
            {
                Text = "Hủy",
                Width = 100,
                Height = 35,
                Top = 360,
                Left = 120
            };
            btnClose.Click += (s, ev) =>
            {
                _currentQrPopup.Close();
                _currentQrPopup = null;

                // Xoá thanh toán nếu đóng popup
                if (!string.IsNullOrEmpty(_idThanhToan))
                {
                    _ = _client.SendMessageAsync($"REMOVE_THANHTOAN_BAPNUOC|{_idThanhToan}");
                    _idThanhToan = null;
                }

                // Dừng timer nếu đang chạy
                _paymentTimer?.Stop();
            };
            _currentQrPopup.Controls.Add(btnClose);

            _currentQrPopup.Show();

            // --- Bắt đầu polling kiểm tra thanh toán ---
            StartPaymentPolling(_idThanhToan);
        }
        private void StartPaymentPolling(string idThanhToan)
        {
            _paymentTimer = new System.Windows.Forms.Timer();
            _paymentTimer.Interval = 5000;

            _paymentTimer.Tick += async (s, e) =>
            {
                _paymentTimer.Stop(); // tránh chồng tick

                string res = await _client.SendMessageAsync($"CHECK_PAYMENT|{idThanhToan}");
                if (res.StartsWith("ERROR"))
                {
                    Console.WriteLine("Lỗi check_payment: " + res);
                    _paymentTimer.Start();
                    return;
                }

                try
                {
                    var result = JsonSerializer.Deserialize<Dictionary<string, object>>(res);
                    if (result != null && result.ContainsKey("trangthai"))
                    {
                        string trangThai = result["trangthai"].ToString();

                        if (trangThai == "paid")
                        {

                            // Lấy chuỗi mã NGAY LÚC NÀY, TRƯỚC KHI RESET
                            string TempThanhToanId = _idThanhToan;
                            string idBapNuoc = CreateIdBapNuoc();
                            string moTa = SummarizeIdBapNuoc(idBapNuoc);
                            DateTime nowVN = DateTime.UtcNow.AddHours(7);

                            _idThanhToan = null;
                            Combo1Numeric.Value = 0;
                            Combo2Numeric.Value = 0;
                            Combo3Numeric.Value = 0;
                            Combo4Numering.Value = 0;
                            this.BeginInvoke(new Action(() =>
                            {
                                if (_currentQrPopup != null && !_currentQrPopup.IsDisposed)
                                {
                                    _currentQrPopup.Close();
                                    _currentQrPopup = null;
                                }
                                _paymentTimer?.Stop();

                                MessageBox.Show(this, "Thanh toán thành công!");


                                _lastPaymentResult = new PaymentResult
                                {
                                    IdThanhToan = TempThanhToanId,
                                    IdBapNuoc = idBapNuoc,
                                    MoTaChiTiet = moTa,
                                    ThoiGianVN = nowVN
                                };

                                Action goHome = () =>
                                {
                                    try
                                    {
                                        // B1: lấy hoặc tạo TrangChuChinh
                                        var home = Application.OpenForms.OfType<TrangChuChinh>().FirstOrDefault();
                                        if (home == null)
                                        {
                                            home = new TrangChuChinh(_user)
                                            {
                                                StartPosition = FormStartPosition.CenterScreen
                                            };
                                            home.Show();
                                        }
                                        else
                                        {
                                            home.Show();
                                            home.BringToFront();
                                        }

                                        // B2: đóng theo owner-chain, dừng ở TrangChuChinh
                                        // Điểm xuất phát: form hiện tại là MuaBapNuoc (vì goHome nằm trong lớp này)
                                        Form cur = this; // MuaBapNuoc
                                        while (cur != null && !(cur is TrangChuChinh))
                                        {
                                            var next = cur.Owner;
                                            try { cur.Close(); } catch { /* ignore */ }
                                            cur = next;
                                        }

                                        // B3: đảm bảo TrangChuChinh trên cùng
                                        home.Show();
                                        home.BringToFront();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show($"Không thể về Trang Chủ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                };


                                new ThongTinBap(_lastPaymentResult.IdThanhToan,_lastPaymentResult.IdBapNuoc,_lastPaymentResult.MoTaChiTiet,_lastPaymentResult.ThoiGianVN, goHome).ShowDialog(this);


                            }));
                        }
                        else if (trangThai == "pending")
                        {
                            Console.WriteLine("Đang chờ thanh toán...");
                            _paymentTimer.Start();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Parse check_payment error: " + ex.Message);
                    _paymentTimer.Start();
                }
            };

            _paymentTimer.Start();
        }


        private int countAllBapNuoc()
        {
            int count = 0;
            count += (int)Combo1Numeric.Value;
            count += (int)Combo2Numeric.Value;
            count += (int)Combo3Numeric.Value;
            count += (int)Combo4Numering.Value;
            return count;
        }
        private string CreateIdBapNuoc()
        {
            string cb1 = "B01"; // Combo 1
            string cb2 = "B01P"; // Combo 1 Premium
            string cb3 = "BUIT"; // Combo UIT
            string cb4 = "BUITP"; // Combo UIT Premium
            string result = "";
            if (Combo1Numeric.Value > 0)
            {
                result += $"{Combo1Numeric.Value}{cb1}";
            }
            if (Combo2Numeric.Value > 0)
            {
                result += $"{Combo2Numeric.Value}{cb2}";
            }
            if (Combo3Numeric.Value > 0)
            {
                result += $"{Combo3Numeric.Value}{cb3}";
            }
            if (Combo4Numering.Value > 0)
            {
                result += $"{Combo4Numering.Value}{cb4}";
            }
            return result;
        }
        private decimal TinhTongTien()
        {
            decimal price1 = 9500;
            decimal price2 = 11500;
            decimal price3 = 12500;
            decimal price4 = 13500;
            decimal total = 0;
            total += price1 * Combo1Numeric.Value;
            total += price2 * Combo2Numeric.Value;
            total += price3 * Combo3Numeric.Value;
            total += price4 * Combo4Numering.Value;
            return total;
        }
        private async Task CreatePaymentQRCode()
        {
            var account = "0979151133";
            var bank = "MBBank";
            decimal totalAmount = TinhTongTien();

            var vnTime = DateTime.UtcNow.AddHours(7);

            _idThanhToan = $"TT{vnTime:yyyyMMddHHmmss}";

            string json_add_bapnuoc = await _client.SendMessageAsync(
                $"ADD_THANHTOAN_BAPNUOC|{_idThanhToan}|{_user.IDUser}|{CreateIdBapNuoc()}|{(Int32)(TinhTongTien())}|{"pending"}|{vnTime:yyyy-MM-dd}"
            );
        }

        private async void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_idThanhToan))
            {
                this.Close();
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn huỷ thanh toán và quay lại?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No) return;

            string json_remove = await _client.SendMessageAsync(
                $"REMOVE_THANHTOAN_BAPNUOC|{_idThanhToan}"
            );

            MessageBox.Show("Đã huỷ thanh toán.", "Thông báo");

            this.Close();
        }


        // đặt trong cùng class MuaBapNuoc
        private static readonly Regex _rxBapNuoc =
            new Regex(@"(?:(\d+))?(B01P|BUITP|B01|BUIT)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        private static readonly Dictionary<string, string> _nameByCode =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                ["B01"] = "Combo 1",
                ["B01P"] = "Combo 1 Premium",
                ["BUIT"] = "Combo UIT",
                ["BUITP"] = "Combo UIT Premium"
            };


        /// Đếm số lượng theo mã (key = code) từ chuỗi id, ví dụ "6B012B01P3BUIT1BUITP"
      
        private Dictionary<string, int> CountByCode(string input)
        {
            var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            if (string.IsNullOrEmpty(input)) return counts;

            foreach (Match m in _rxBapNuoc.Matches(input))
            {
                int qty = m.Groups[1].Success ? int.Parse(m.Groups[1].Value) : 1;
                string code = m.Groups[2].Value.ToUpperInvariant();

                if (!counts.ContainsKey(code)) counts[code] = 0;
                counts[code] += qty;
            }
            return counts;
        }

        private string SummarizeIdBapNuoc(string input)
        {
            var counts = CountByCode(input);
            if (counts.Count == 0) return "Không tìm thấy mã combo hợp lệ";

            string[] order = { "B01", "B01P", "BUIT", "BUITP" };
            var parts = order
                .Where(code => counts.ContainsKey(code))
                .Select(code => $"{counts[code]} {_nameByCode[code]}");

            return string.Join(", ", parts);
        }


        private void FillControlsFromId(string input)
        {
            var counts = CountByCode(input);

            Combo1Numeric.Value = counts.TryGetValue("B01", out var v1) ? v1 : 0;
            Combo2Numeric.Value = counts.TryGetValue("B01P", out var v2) ? v2 : 0;
            Combo3Numeric.Value = counts.TryGetValue("BUIT", out var v3) ? v3 : 0;
            Combo4Numering.Value = counts.TryGetValue("BUITP", out var v4) ? v4 : 0;
        }

        private void MuaBapNuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
