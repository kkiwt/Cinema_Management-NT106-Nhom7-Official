using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CinemaManagement
{
    public partial class MuaBapNuoc : Form
    {
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
                            _idThanhToan= null;
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
            string cb1 = "B01";
            string cb2 = "B01P";
            string cb3 = "BUIT";
            string cb4 = "BUITP";
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


        private void MuaBapNuoc_Load(object sender, EventArgs e)
        {

        }
    }
}
