using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq; // Cần cho lọc LINQ
using CinemaManagement; // Chứa các Models Phim, ReviewSummary, ReviewDisplay

namespace CinemaManagement
{
    public partial class DanhGia : Form
    {
        private Phim PhimHienTai;
        private ClientTCP clientTcp;
        private ReviewSummary currentReviewSummary;
        private int selectedStar = 0; // Số sao người dùng chọn khi viết đánh giá

        private ChiTietPhim _callerChiTietPhim;
        private readonly string CurrentUserId = "ID_NGUOI_DUNG_HIEN_TAI"; // Cần lấy từ Session/Login
        private readonly string CurrentUserName = "Tên Của Tôi"; // Cần lấy từ Session/Login

        // Giả định Controls: Loc (ComboBox), DiemDanhGia (Label), TongLuotDanhGia (Label), 
        // TongSao (Label), flowLayoutPanel (FlowLayoutPanel), pnlMyStars (Panel), 
        // NoiDungDanhGia (TextBox), Gui (Button)

        public DanhGia(Phim phim, ChiTietPhim callerForm) // Constructor nhận thông tin Phim
        {
            InitializeComponent();
            PhimHienTai = phim;
            clientTcp = new ClientTCP();
            _callerChiTietPhim = callerForm;
            // Cập nhật tên phim trên tiêu đề/form nếu cần
            this.Text = $"Đánh giá phim: {phim.TenPhim}";

            // Khởi tạo ComboBox
            SetupComboBox();

            // Khởi tạo sự kiện cho chọn sao
            SetupStarSelection();

            // GÁN SỰ KIỆN GỬI ĐÁNH GIÁ (Cần thiết để nút hoạt động)
            // Giả định nút Gửi có tên là 'Gui'
            Gui.Click += Gui_Click;

            // Tải dữ liệu khi Form mở
            this.Load += DanhGia_Load;
            // Gán sự kiện cho LinkLabel (Giả định tên LinkLabel là LinkTrangChuChinh và LinkTenPhim)
            LinkTrangChuChinh.LinkClicked += LinkTrangChuChinh_LinkClicked;
            LinkTenPhim.LinkClicked += LinkTenPhim_LinkClicked;
            LinkTenPhim.Text = PhimHienTai.TenPhim + " >> Đánh giá"; // Đặt tên phim cho Link
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

        // Cấu hình ComboBox
        private void SetupComboBox()
        {
            // Thêm các mục lọc vào ComboBox
            Loc.Items.Add("Tất cả");
            for (int i = 5; i >= 1; i--)
            {
                Loc.Items.Add($"{i} sao");
            }
            Loc.SelectedIndex = 0; // Mặc định chọn "Tất cả"
            Loc.SelectedIndexChanged += Loc_SelectedIndexChanged;
        }

        // Cấu hình chọn sao cho phần "Viết đánh giá của bạn" (Sử dụng Unicode Label)
        private void SetupStarSelection()
        {
            pnlMyStars.Controls.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Label star = new Label
                {
                    Name = $"lblStar_{i}",
                    Tag = i,
                    Text = "☆", // Ký tự sao rỗng Unicode
                    Size = new Size(80, 80),
                    Location = new Point((i - 1) * 80, 0),
                    Font = new Font("Arial", 40), // Dùng font lớn để dễ nhìn
                    ForeColor = Color.Gray,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter // Căn giữa sao trong Label
                };
                star.Click += Star_Click;
                pnlMyStars.Controls.Add(star);
            }
            selectedStar = 0; // Đảm bảo reset lại số sao đã chọn
        }

        // Xử lý sự kiện click chọn sao (Sử dụng Unicode Label)
        private void Star_Click(object sender, EventArgs e)
        {
            Label clickedStar = (Label)sender;
            int starValue = (int)clickedStar.Tag;
            selectedStar = starValue;

            foreach (Control control in pnlMyStars.Controls)
            {
                if (control is Label lbl)
                {
                    int tagValue = (int)lbl.Tag;
                    lbl.Font = new Font("Arial", 40);
                    lbl.Text = (tagValue <= starValue) ? "★" : "☆";
                    lbl.ForeColor = (tagValue <= starValue) ? Color.Gold : Color.Gray;
                }
            }
        }

        // --- HÀM TẢI DỮ LIỆU CHÍNH ---
        private async Task LoadReviewDataAsync(string idPhim)
        {
            string message = $"GET_REVIEW_SUMMARY|{idPhim}";
            string response = await clientTcp.SendMessageAsync(message);

            if (response.StartsWith("ERROR"))
            {
                MessageBox.Show($"Lỗi tải đánh giá: {response}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentReviewSummary = new ReviewSummary { LatestReviews = new List<ReviewDisplay>() };
                UpdateSummaryDisplay(currentReviewSummary); // Vẫn cập nhật UI dù lỗi
                return;
            }

            try
            {
                currentReviewSummary = JsonSerializer.Deserialize<ReviewSummary>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                // 1. Hiển thị thông tin tổng hợp
                UpdateSummaryDisplay(currentReviewSummary);

                // 3. Hiển thị danh sách đánh giá ban đầu (Tất cả)
                // Lấy giá trị lọc hiện tại (hoặc 0 nếu là Tất cả)
                int filterStar = (Loc.SelectedIndex > 0) ?
                    int.Parse(Loc.SelectedItem.ToString().Split(' ')[0]) : 0;
                DisplayReviewList(currentReviewSummary.LatestReviews, filterStar);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý dữ liệu đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cập nhật phần tổng hợp (Mục tiêu 1)
        private void UpdateSummaryDisplay(ReviewSummary summary)
        {
            DiemDanhGia.Text = $"{summary.AvgRating:0.0}";
            TongLuotDanhGia.Text = $"{summary.TotalReviews} lượt đánh giá";

            // Hiển thị số sao trung bình bằng Unicode
            int roundedStars = (int)Math.Round(summary.AvgRating);
            string stars = "";
            for (int i = 0; i < 5; i++)
            {
                stars += (i < roundedStars) ? "★" : "☆";
            }
            TongSao.Text = stars;
            TongSao.Font = new Font("Arial", 28, FontStyle.Regular);
        }

        private void DisplayReviewList(List<ReviewDisplay> reviews, int filterStar)
        {
            // *** CẬP NHẬT: Xóa Controls một cách an toàn ***
            // Tạo danh sách controls cần xóa (bản sao)
            List<Control> controlsToRemove = flowLayoutPanel.Controls.Cast<Control>().ToList();

            // Xóa từng control khỏi flowLayoutPanel
            foreach (var control in controlsToRemove)
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose(); // Giải phóng tài nguyên
            }
            // Hết khu vực xóa an toàn

            // Lọc danh sách nếu filterStar > 0
            var filteredReviews = (filterStar > 0)
                ? reviews.Where(r => r.SoSao == filterStar).ToList()
                : reviews;

            foreach (var review in filteredReviews)
            {
                var reviewItem = new DanhGiaItemControl(review);
                reviewItem.Width = flowLayoutPanel.Width - 5;
                // Đảm bảo có Margin để các item không dính sát
                reviewItem.Margin = new Padding(0, 0, 0, 10);
                flowLayoutPanel.Controls.Add(reviewItem);
            }
        }

        // Xử lý sự kiện thay đổi ComboBox (Mục tiêu 3 - Lọc)
        private void Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentReviewSummary == null) return;

            string selectedItem = Loc.SelectedItem.ToString();
            int filterStar = 0;

            if (selectedItem != "Tất cả")
            {
                // Lấy số sao từ chuỗi (vd: "5 sao" -> 5)
                int.TryParse(selectedItem.Split(' ')[0], out filterStar);
            }

            DisplayReviewList(currentReviewSummary.LatestReviews, filterStar);
        }


        // DanhGia.cs - Hàm Gui_Click

        private async void Gui_Click(object sender, EventArgs e)
        {
            if (selectedStar == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao trước khi gửi.", "Lỗi");
                return;
            }

            string noiDung = NoiDungDanhGia.Text.Trim();
            string message = $"POST_REVIEW|{CurrentUserId}|{PhimHienTai.IdPhim}|{noiDung}|{selectedStar}";

            string response = await clientTcp.SendMessageAsync(message); // *** Chạy Bất đồng bộ ở đây ***

            if (response == "SUCCESS")
            {
                MessageBox.Show("Gửi đánh giá thành công!", "Thông báo");

                // *** KHU VỰC CẦN CHỈNH SỬA: CHỈ SỬ DỤNG Invoke cho UI TỨC THỜI ***

                // 1. Reset Form nhập liệu (Chạy trên UI Thread, KHÔNG cần await)
                this.Invoke((MethodInvoker)delegate
                {
                    NoiDungDanhGia.Text = "";
                    selectedStar = 0;
                    SetupStarSelection(); // Đặt lại ngôi sao rỗng
                });

                // 2. Tải lại dữ liệu (Chạy bất đồng bộ TRÊN LUỒNG HIỆN TẠI, sau khi UI reset)
                await LoadReviewDataAsync(PhimHienTai.IdPhim);

                // 3. Tự động cuộn (Chạy trên UI Thread sau khi tải xong)
                this.Invoke((MethodInvoker)delegate
                {
                    if (flowLayoutPanel.Controls.Count > 0)
                        flowLayoutPanel.ScrollControlIntoView(flowLayoutPanel.Controls[0]);
                });
                // *** HẾT KHU VỰC CHỈNH SỬA ***
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

        // DanhGia.cs

        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Đóng Form Đánh giá
            this.Close();

            // Yêu cầu Form Chi Tiết Phim gọi hàm trở về Trang Chủ Chính của nó
            if (_callerChiTietPhim != null)
            {
                _callerChiTietPhim.TroVeTrangChuChinh();
            }
        }

        // DanhGia.cs

        private void LinkTenPhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ẩn Form DanhGia
            this.Hide();

            if (_callerChiTietPhim != null)
            {
                // Hiển thị lại Form Chi Tiết Phim đã gọi
                _callerChiTietPhim.Show();

            }
            // Form sẽ đóng khi ShowDialog kết thúc, nếu dùng ShowDialog
            this.Close();
        }

        
    }
}