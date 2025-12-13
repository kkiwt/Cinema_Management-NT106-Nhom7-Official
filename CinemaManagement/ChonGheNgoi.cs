using ControlzEx.Standard;
using Supabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CinemaManagement.ThongTinVe;

namespace CinemaManagement
{
    public partial class ChonGheNgoi : Form
    {
        private readonly Phim _phim;
        private readonly UserInfo _user;
        private readonly DateTime _date;
        private readonly LichChieuCoDinh _slot;

        private List<KhungGio> khungGioList = new List<KhungGio>();
        private List<PhongChieu> phongChieuList = new List<PhongChieu>();
        private List<LichChieuCoDinh> lichChieuList = new List<LichChieuCoDinh>();

        private List<string> _selectedSeats = new List<string>();
        private ClientTCP _client = new ClientTCP();

        private System.Windows.Forms.Timer _seatTimer;
        private bool _loading = false;
        private System.Windows.Forms.Timer _paymentTimer;
        private Form _currentQrPopup;
        private int _paymentCountdown = 300;
        private System.Windows.Forms.Timer _countdownTimer;
        private GiamGia GiamGia;
        string maGiamGia = "";
        private string _lastPaymentId;

        public ChonGheNgoi(
            Phim phim,
            UserInfo user,
            DateTime date,
            LichChieuCoDinh slot,
            List<KhungGio> kg,
            List<PhongChieu> pc,
            List<LichChieuCoDinh> lc)
        {
            InitializeComponent();
            _phim = phim;
            _user = user;
            _date = date.Date;
            _slot = slot;
            khungGioList = kg;
            phongChieuList = pc;
            lichChieuList = lc;
        }

        private async void ChonGheNgoi_Load(object sender, EventArgs e)
        {
            maGiamGia = MaGiamGiaText.Text;
            _seatTimer = new System.Windows.Forms.Timer();
            _seatTimer.Interval = 1000;
            _seatTimer.Tick += async (s, ev) => await LoadSeatStatus();
            _seatTimer.Start();

            await LoadSeatStatus();
        }

        private async Task LoadSeatStatus()
        {
            if (_loading) return;
            _loading = true;

            try
            {
                string jsonSeats = await _client.SendMessageAsync(
                    $"GET_SEATSTATUS|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}");

                if (jsonSeats.StartsWith("ERROR")) return;

                var seatStatusList = JsonSerializer.Deserialize<List<SeatStatus>>(jsonSeats);

                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        string seatId = MapSeatId(btn.Text);
                        var seat = seatStatusList.FirstOrDefault(s => s.idghe == seatId);

                        if (seat.status == "paid")
                        {
                            if (_selectedSeats.Contains(seatId)) continue;
                            btn.BackColor = Color.Red;
                        }
                        else if (seat.status == "holding")
                        {
                            if (seat.userid == _user.IDUser)
                            {
                                btn.BackColor = Color.Yellow;
                                if (!_selectedSeats.Contains(seatId)) _selectedSeats.Add(seatId);
                            }
                            else
                                btn.BackColor = Color.Gold;
                        }
                        else if (seat.status == "pending")
                        {
                            btn.BackColor = Color.Gray;
                        }
                        else
                        {
                            if (_selectedSeats.Contains(seatId)) _selectedSeats.Remove(seatId);
                            btn.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi tải trạng thái ghế: {ex.Message}");
            }
            finally
            {
                _loading = false;
            }
        }

        private async void AllButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            string seatText = btn.Text;
            string seatId = MapSeatId(seatText);

            if (btn.BackColor == Color.Red) return;

            if (btn.BackColor == Color.Yellow)
            {
                string resRemove = await _client.SendMessageAsync(
                    $"REMOVE_HOLDSEAT|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}");

                if (resRemove.StartsWith("ERROR"))
                {
                    MessageBox.Show($"Không thể bỏ giữ ghế {seatText} ({seatId}): {resRemove}");
                }
                else
                {
                    _selectedSeats.Remove(seatId);
                    btn.BackColor = Color.LightGreen;
                }
                return;
            }

            string resHold = await _client.SendMessageAsync(
                $"ADD_HOLDSEAT|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}");

            if (resHold.StartsWith("ERROR"))
            {
                MessageBox.Show($"Ghế {seatText} ({seatId}) đã bị giữ hoặc đã bán.");
            }
            else
            {
                _selectedSeats.Add(seatId);
                btn.BackColor = Color.Yellow;
            }
        }

        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            maGiamGia = MaGiamGiaText.Text.Trim();
            if (_selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi thanh toán.");
                return;
            }
            string json = await _client.SendMessageAsync($"GET_GIAMGIA|{maGiamGia}");

            if (json.StartsWith("ERROR"))
            {
                GiamGia = null;
            }
            else
            {
                try
                {
                    GiamGia = JsonSerializer.Deserialize<GiamGia>(json);
                }
                catch
                {
                    var list = JsonSerializer.Deserialize<List<GiamGia>>(json);
                    GiamGia = list?.FirstOrDefault();
                }

                if (GiamGiaApDung())
                {
                    MessageBox.Show($"Mã giảm giá hợp lệ! Giảm {GiamGia.tilegiam * 100}%.");
                }
                else if (maGiamGia == "")
                {
                    GiamGia = null;
                }
                else
                {
                    GiamGia = null;
                    MessageBox.Show("Mã giảm giá không hợp lệ hoặc đã hết hạn.");
                }
            }

            await CreatePaymentQRCode();

        }
        private bool GiamGiaApDung()
        {
            return GiamGia != null && GiamGia.denngay > DateTime.Now && GiamGia.trangthai == "available";
        }
        private async void RecreatePayment()
        {
            await CreatePaymentQRCode();
        }

        private async Task CreatePaymentQRCode()
        {
            var account = "0979151133";
            var bank = "MBBank";
            decimal totalAmount = 0;

            var vnTime = DateTime.UtcNow.AddHours(7);
            var idThanhToan = $"TT{vnTime:yyyyMMddHHmmss}";
            _lastPaymentId = idThanhToan;
            // Lấy danh sách ghế
            string jsonSeats = await _client.SendMessageAsync(
                $"GET_SEATSTATUS|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}");

            if (jsonSeats.StartsWith("ERROR")) return;

            var seatStatusList = JsonSerializer.Deserialize<List<SeatStatus>>(jsonSeats);

            foreach (var seatId in _selectedSeats)
            {
                var seat = seatStatusList.FirstOrDefault(s => s.idghe == seatId);
                if (seat == null) continue;
                decimal tileGiam = GiamGia?.tilegiam ?? 0m;
                if (!GiamGiaApDung()) 
                {
                    tileGiam= 0m;
                }
                var giaVe = (int)((_phim.GiaVeChuan ?? 10000m)
                                  * (seat.hesoghe ?? 1m)
                                  * (1 - tileGiam));

                totalAmount += giaVe;

                if (seat.status == "pending") continue;

                await _client.SendMessageAsync(
                    $"SET_VE|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}|{giaVe}|{idThanhToan}");

                MarkSeatPending(seatId);
            }

            StartPaymentPolling(idThanhToan);

            var url = $"https://qr.sepay.vn/img?acc={account}&bank={bank}&amount={totalAmount}&des={idThanhToan}&template=compact&download=false";

            using var http = new HttpClient();
            using var ms = new MemoryStream(await http.GetByteArrayAsync(url));

            string paymentInfo = $"ID Thanh toán: {idThanhToan}\r\nTổng tiền: {totalAmount} VND";
            if (GiamGiaApDung())
            {
                string json = await _client.SendMessageAsync($"SET_GIAMGIA|{GiamGia.idgiamgia}");
            }
            var img = Image.FromStream(ms);

            var popup = ShowImagePopup(img, "QR Thanh Toán", RecreatePayment, () =>
            {
                ResetPendingSeatsToHolding();
                ResumeSeatTimer();
            }, paymentInfo);
            popup.Owner = this;
            _currentQrPopup = popup;
            popup.Show();

            _seatTimer.Stop();
        }

        public void ResumeSeatTimer()
        {
            _seatTimer?.Start();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            this.BeginInvoke(new Action(() =>
                            {
                                // Đóng popup trước
                                if (_currentQrPopup != null && !_currentQrPopup.IsDisposed)
                                {
                                    _currentQrPopup.Close();
                                    _currentQrPopup = null;
                                }

                                // Dừng countdown timer
                                _countdownTimer?.Stop();

                                // === BIẾN TẠM: chụp danh sách ghế hiện tại ===
                                var seatsForTicket = _selectedSeats.ToList();

                                // Cập nhật ghế
                                foreach (var seatId in _selectedSeats)
                                    MarkSeatSold(seatId);
                                _selectedSeats.Clear();
                                MaGiamGiaText.Text = "";
                                maGiamGia = "";
                                // Resume seat timer
                                ResumeSeatTimer();
                                var ticket = new TicketInfo
                                {
                                    IdThanhToan = _lastPaymentId,           // đã lưu khi tạo QR
                                    TenPhim = _phim?.TenPhim ?? "N/A",
                                    // Ghép ngày chiếu (_date) + giờ từ slot/khung giờ. Nếu slot có giờ bắt đầu, thay thế dưới đây cho đúng:
                                    ThoiGian = _date.Date + khungGioList.First(x => x.idKG == _slot.idkhunggio).TGBatDau, // ví dụ: nếu có giờ trong _slot hoặc khungGioList, cộng thêm ở đây
                                                                                                                          // .AddHours( ... ) .AddMinutes( ... ),
                                    PhongChieu = $"{_slot.idphongchieu:D2}{_phim.IdPhim:D2}",
                                    DanhSachSeatIds = seatsForTicket

                                };

                                // Thông báo
                                MessageBox.Show(this, "Thanh toán thành công!");

                                var frmVe = new ThongTinVe(ticket);
                                frmVe.StartPosition = FormStartPosition.CenterScreen;

                                frmVe.ShowDialog();          // Show non-modal (hoặc dùng ShowDialog nếu muốn chặn)

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

        private void StartCountdownTimer()
        {
            if (_countdownTimer == null)
            {
                _countdownTimer = new System.Windows.Forms.Timer();
                _countdownTimer.Interval = 1000; // 1 giây
                _countdownTimer.Tick += CountdownTick;
            }
            _countdownTimer.Start();
        }

        private void CountdownTick(object sender, EventArgs e)
        {
            _paymentCountdown--;

            if (_paymentCountdown <= 0)
            {
                _countdownTimer.Stop();

                if (_currentQrPopup != null && !_currentQrPopup.IsDisposed)
                {
                    _currentQrPopup.Close();
                    _currentQrPopup = null;
                }
                ResetPendingSeatsToHolding();
                ResumeSeatTimer();

                MessageBox.Show("Hết thời gian thanh toán. Vui lòng thực hiện lại.");
            }
        }

        private async void ResetPendingSeatsToHolding()
        {
            foreach (var seatId in _selectedSeats)
            {
                string resDelete = await _client.SendMessageAsync(
                    $"DELETE_TICKET|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}");

                if (resDelete.StartsWith("ERROR"))
                {
                    Console.WriteLine($"Không thể xóa vé {seatId}: {resDelete}");
                }
                else
                {
                    Console.WriteLine($"Đã xóa vé ghế {seatId}: {resDelete}");
                }

                string resHold = await _client.SendMessageAsync(
                    $"ADD_HOLDSEAT|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}");

                if (resHold.StartsWith("ERROR"))
                {
                    Console.WriteLine($"Không thể khôi phục ghế {seatId}: {resHold}");
                    continue;
                }
                foreach (Control ctrl in panel1.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        if (MapSeatId(btn.Text) == seatId && btn.BackColor == Color.Gray)
                        {
                            btn.BackColor = Color.Yellow;
                        }
                    }
                }
            }
        }

        private void MarkSeatSold(string seatId)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    string mapped = MapSeatId(btn.Text);
                    if (mapped == seatId)
                        btn.BackColor = Color.Red;
                }
            }
        }

        private void MarkSeatPending(string seatId)
        {
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button btn)
                {
                    string mapped = MapSeatId(btn.Text);
                    if (mapped == seatId)
                        btn.BackColor = Color.Gray;
                }
            }
        }

        private string MapSeatId(string text)
        {
            if (text.StartsWith("G")) return text; // đã đúng format

            char row = text[0];
            if (!int.TryParse(text.Substring(1), out int col)) return null;

            return $"G{row}{col:D2}";
        }

        public static Form ShowImagePopup(
            Image img,
            string title,
            Action onRecreatePayment,
            Action onCloseKeepHolding,
            string paymentInfo = "")
        {
            Form popup = new Form
            {
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = new Size(350, 450)
            };

            // PictureBox hiển thị QR
            PictureBox pb = new PictureBox
            {
                Dock = DockStyle.Top,
                SizeMode = PictureBoxSizeMode.Zoom,
                Height = 300,
                Image = img
            };

            // TextBox hiển thị thông tin thanh toán
            TextBox txtInfo = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Height = 80,
                Top = 310,
                Left = 10,
                Width = 330,
                Text = paymentInfo,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 10, FontStyle.Regular)
            };

            // Nút quay lại
            Button btnOk = new Button
            {
                Text = "Quay lại",
                Width = 120,
                Height = 35,
                Left = 30,
                Top = 400
            };
            btnOk.Click += (s, e) =>
            {
                popup.Close();
                onCloseKeepHolding?.Invoke();
            };

            // Nút tạo mới thanh toán
            Button btnBack = new Button
            {
                Text = "Tạo mới thanh toán",
                Width = 150,
                Height = 35,
                Left = 180,
                Top = 400
            };
            btnBack.Click += (s, e) =>
            {
                popup.Close();
                onRecreatePayment?.Invoke();
            };

            popup.Controls.Add(pb);
            popup.Controls.Add(txtInfo);
            popup.Controls.Add(btnOk);
            popup.Controls.Add(btnBack);

            return popup;
        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}