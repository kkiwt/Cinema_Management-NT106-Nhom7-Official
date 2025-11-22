using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using CinemaManagement;

namespace CinemaManagement
{
    public partial class DanhGia : Form
    {
        private Phim PhimHienTai;
        private ClientTCP clientTcp;
        private ReviewSummary TongDanhGiaHienTai;
        private int ChonSaoDanhGia = 0; 
        private ChiTietPhim GoiChiTietPhim;
        private readonly string UserIdHienTai = "ID_NGUOI_DUNG_HIEN_TAI"; // Cần lấy từ Session/Login
        private readonly string UserNameHienTai = "Tên Của Tôi"; // Cần lấy từ Session/Login

        public DanhGia(Phim phim, ChiTietPhim GoiForm)
        {
            InitializeComponent();
            PhimHienTai = phim;
            clientTcp = new ClientTCP();
            GoiChiTietPhim = GoiForm;
            this.Text = $"Đánh giá phim: {phim.TenPhim}";
            SetupComboBox();
            SetupStarSelection();
            Gui.Click += Gui_Click;
            this.Load += DanhGia_Load;
            LinkTrangChuChinh.LinkClicked += LinkTrangChuChinh_LinkClicked;
            LinkTenPhim.LinkClicked += LinkTenPhim_LinkClicked;
            LinkTenPhim.Text = PhimHienTai.TenPhim + " >> Đánh giá"; 
        }

        // Constructor rỗng cho Designer
        public DanhGia()
        {
            InitializeComponent();
        }

        private async void DanhGia_Load(object sender, EventArgs e)
        {
            if (PhimHienTai != null && !string.IsNullOrEmpty(PhimHienTai.IdPhim))
            {
                await LoadReviewDataAsync(PhimHienTai.IdPhim);
            }
        }

        private void SetupComboBox()
        {
            Loc.Items.Add("Tất cả");
            for (int i = 5; i >= 1; i--)
            {
                Loc.Items.Add($"{i} sao");
            }
            Loc.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            Loc.SelectedIndexChanged += Loc_SelectedIndexChanged;
        }


        private void SetupStarSelection()
        {
            pnlMyStars.Controls.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Label star = new Label
                {
                    Name = $"lblStar_{i}",
                    Tag = i,
                    Text = "☆", 
                    Size = new Size(80, 80),
                    Location = new Point((i - 1) * 80, 0),
                    Font = new Font("Arial", 40), 
                    ForeColor = Color.Gray,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                star.Click += Star_Click;
                pnlMyStars.Controls.Add(star);
            }
            ChonSaoDanhGia = 0; // Đảm bảo reset lại số sao đã chọn
        }

        private void Star_Click(object sender, EventArgs e)
        {
            Label SaoDuocClick = (Label)sender;
            int GiaTriSao = (int)SaoDuocClick.Tag;
            ChonSaoDanhGia = GiaTriSao;

            foreach (Control control in pnlMyStars.Controls)
            {
                if (control is Label lbl)
                {
                    int TagGiaTri = (int)lbl.Tag;
                    lbl.Font = new Font("Arial", 40);
                    lbl.Text = (TagGiaTri  <= GiaTriSao) ? "★" : "☆";
                    lbl.ForeColor = (TagGiaTri <= GiaTriSao) ? Color.Gold : Color.Gray;
                }
            }
        }

        private async Task LoadReviewDataAsync(string idPhim)
        {
            string message = $"GET_REVIEW_SUMMARY|{idPhim}";
            string response = await clientTcp.SendMessageAsync(message);

            if (response.StartsWith("ERROR"))
            {
                MessageBox.Show($"Lỗi tải đánh giá: {response}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TongDanhGiaHienTai = new ReviewSummary { LatestReviews = new List<ReviewDisplay>() };
                HienThiKetQuaTong(TongDanhGiaHienTai); // Vẫn cập nhật UI dù lỗi
                return;
            }

            try
            {
                TongDanhGiaHienTai = JsonSerializer.Deserialize<ReviewSummary>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                // 1. Hiển thị thông tin tổng hợp
                HienThiKetQuaTong(TongDanhGiaHienTai);
                // 3. Hiển thị danh sách đánh giá ban đầu (Tất cả)
                // Lấy giá trị lọc hiện tại (hoặc 0 nếu là Tất cả)
                int LocTheoSao = (Loc.SelectedIndex > 0) ?
                    int.Parse(Loc.SelectedItem.ToString().Split(' ')[0]) : 0;
                DisplayReviewList(TongDanhGiaHienTai.LatestReviews, LocTheoSao);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý dữ liệu đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiKetQuaTong(ReviewSummary Tong)
        {
            DiemDanhGia.Text = $"{Tong.AvgRating:0.0}";
            TongLuotDanhGia.Text = $"{Tong.TotalReviews} lượt đánh giá";

            // Hiển thị số sao trung bình bằng Unicode
            int RoundedStars = (int)Math.Round(Tong.AvgRating);
            string Stars = "";
            for (int i = 0; i < 5; i++)
            {
                Stars += (i < RoundedStars) ? "★" : "☆";
            }
            TongSao.Text = Stars;
            TongSao.Font = new Font("Arial", 28, FontStyle.Regular);
        }

        private void DisplayReviewList(List<ReviewDisplay> Reviews, int LocSao)
        {
            // Tạo danh sách controls cần xóa (bản sao)
            List<Control> controlsToRemove = flowLayoutPanel.Controls.Cast<Control>().ToList();
            // Xóa từng control khỏi flowLayoutPanel
            foreach (var control in controlsToRemove)
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose(); // Giải phóng tài nguyên
            }

            // Lọc danh sách nếu filterStar > 0
            var LocDanhGia = (LocSao > 0)
                ? Reviews.Where(r => r.SoSao == LocSao).ToList()
                : Reviews;

            foreach (var Review in LocDanhGia)
            {
                var ReviewItem = new DanhGiaItemControl(Review);
                ReviewItem.Width = flowLayoutPanel.Width - 5;
                // Đảm bảo có Margin để các item không dính sát
                ReviewItem.Margin = new Padding(0, 0, 0, 10);
                flowLayoutPanel.Controls.Add(ReviewItem);
            }
        }

        private void Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TongDanhGiaHienTai == null) return;

            string ItemDuocChon = Loc.SelectedItem.ToString();
            int LocSao = 0;

            if (ItemDuocChon != "Tất cả")
            {
                // Lấy số sao từ chuỗi (vd: "5 sao" -> 5)
                int.TryParse(ItemDuocChon.Split(' ')[0], out LocSao);
            }

            DisplayReviewList(TongDanhGiaHienTai.LatestReviews, LocSao);
        }

        private async void Gui_Click(object sender, EventArgs e)
        {
            if (ChonSaoDanhGia == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao trước khi gửi.", "Lỗi");
                return;
            }

            string NoiDung = NoiDungDanhGia.Text.Trim();
            string message = $"POST_REVIEW|{UserIdHienTai}|{PhimHienTai.IdPhim}|{NoiDung}|{ChonSaoDanhGia}";

            string response = await clientTcp.SendMessageAsync(message); 

            if (response == "SUCCESS")
            {
                MessageBox.Show("Gửi đánh giá thành công!", "Thông báo");
                // 1. Reset Form nhập liệu (Chạy trên UI Thread, KHÔNG cần await)
                this.Invoke((MethodInvoker)delegate
                {
                    NoiDungDanhGia.Text = "";
                    ChonSaoDanhGia = 0;
                    SetupStarSelection(); // Đặt lại ngôi sao rỗng
                });
                // 2. Tải lại dữ liệu
                await LoadReviewDataAsync(PhimHienTai.IdPhim);

                // 3. Tự động cuộn
                this.Invoke((MethodInvoker)delegate
                {
                    if (flowLayoutPanel.Controls.Count > 0)
                        flowLayoutPanel.ScrollControlIntoView(flowLayoutPanel.Controls[0]);
                });
            }
            else
            {
                MessageBox.Show($"Lỗi gửi đánh giá: {response}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
        }


        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            if (GoiChiTietPhim != null)
            {
                GoiChiTietPhim.TroVeTrangChuChinh();
            }
        }

        private void LinkTenPhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (GoiChiTietPhim != null)
            {
                GoiChiTietPhim.Show();
            }
            this.Close();
        }

        
    }
}