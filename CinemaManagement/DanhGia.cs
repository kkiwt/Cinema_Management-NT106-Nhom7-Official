using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    // Giả định ClientTCP có phương thức SendMessageAsync(string command)
    // và ClientTCP nằm trong cùng Namespace hoặc được tham chiếu.
    // public class ClientTCP { public async Task<string> SendMessageAsync(string command) { ... } } 

    public partial class DanhGia : Form
    {
        private TrangChuChinh formTrangChuChinh;

        private List<Review> AllReviews = new List<Review>();

        // Giả định các Dependency đã được định nghĩa
        private readonly ClientTCP clientTcp;
        private readonly Phim PhimHienTai;
        private readonly string CurrentUserId = "TK001"; // ID người dùng hiện tại (Giả định)
        private readonly string CurrentUserName = "Tên Người Dùng"; // Tên người dùng hiện tại (Giả định)

        private int _soSaoDaChon = 0;
        private PictureBox[] _starBoxes;

        // KHAI BÁO BIẾN HÌNH ẢNH SAO (Cần load từ Resources hoặc file)
        private Image SaoVang;
        private Image SaoXam;

       

        // ===============================================
        // KHỞI TẠO & LOAD DỮ LIỆU
        // ===============================================

        public DanhGia(Phim phim)
        {
            InitializeComponent();

            this.PhimHienTai = phim;
            this.clientTcp = new ClientTCP(); // Khởi tạo TCP client

            this.Load += DanhGia_Load;

            // Thiết lập các PictureBox cho rating (Giống như trong snippet của bạn)
            _starBoxes = new PictureBox[]
            {
                this.Controls.Find("Sao1", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao2", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao3", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao4", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao5", true).FirstOrDefault() as PictureBox
            }.Where(pb => pb != null).ToArray();

            // Đính kèm sự kiện cho các ngôi sao
            foreach (var pb in _starBoxes)
            {
                if (pb != null)
                {
                    pb.MouseEnter += Sao_MouseEnter;
                    pb.MouseLeave += Sao_MouseLeave;
                    pb.Click += Sao_Click;
                }
            }

            // Đảm bảo flpReviews có FlowDirection.TopDown
            if (DanhSachCacDanhGia != null)
            {
                DanhSachCacDanhGia.FlowDirection = FlowDirection.TopDown;
                DanhSachCacDanhGia.WrapContents = false;
                DanhSachCacDanhGia.AutoScroll = true;
            }

            // Gán sự kiện cho nút gửi đánh giá
            this.GuiPhanHoi.Click += GuiPhanHoi_Click;

            try
            {
                // Gán hình ảnh từ Resources của dự án của bạn
                // BẠN PHẢI THAY THẾ 'star_filled' và 'star_empty' bằng tên Resources thực tế
                // Hoặc load từ file nếu bạn không dùng Resources
                SaoVang = Properties.Resources.star_filled;
                SaoXam = Properties.Resources.star_empty;
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy tài nguyên hình ảnh ngôi sao. Vui lòng kiểm tra lại Properties.Resources.", "Lỗi Resource", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể gán NULL hoặc Placeholder nếu không tìm thấy
                SaoVang = null;
                SaoXam = null;
            }
        }

        private async void DanhGia_Load(object sender, EventArgs e)
        {
            // Kết nối TCP nếu cần (tùy thuộc vào thiết kế ClientTCP)
            // await clientTcp.ConnectAsync(); 

            // Tải dữ liệu đánh giá ban đầu
            await LoadReviewData(PhimHienTai.IdPhim);
        }

        // ===============================================
        // LOGIC TƯƠNG TÁC STAR RATING (UI)
        // ===============================================

        /// <summary> Cập nhật hình ảnh ngôi sao dựa trên số sao (starCount) </summary>
        // File: DanhGia.cs

        /// <summary> Cập nhật hình ảnh ngôi sao dựa trên số sao (starCount) </summary>
        private void UpdateStarDisplay(int starCount)
        {
            if (SaoVang == null || SaoXam == null) return; // Bảo vệ nếu hình ảnh không load được

            for (int i = 0; i < _starBoxes.Length; i++)
            {
                // Nếu chỉ số i nhỏ hơn số sao được truyền vào, tô màu vàng, ngược lại tô xám
                _starBoxes[i].Image = (i < starCount) ? SaoVang : SaoXam; 
            }
        }

        private void Sao_MouseEnter(object sender, EventArgs e)
        {
            PictureBox currentStar = sender as PictureBox;
            if (currentStar == null) return;

            // Tìm index của ngôi sao hiện tại trong mảng
            int index = Array.IndexOf(_starBoxes, currentStar);

            // Hiển thị ngôi sao sáng từ đầu đến ngôi sao hiện tại (index + 1)
            UpdateStarDisplay(index + 1);
        }

        private void Sao_MouseLeave(object sender, EventArgs e)
        {
            // Khi chuột rời, hiển thị lại số sao đã chọn (hoặc 0 nếu chưa chọn)
            UpdateStarDisplay(_soSaoDaChon);
        }

        private void Sao_Click(object sender, EventArgs e)
        {
            PictureBox currentStar = sender as PictureBox;
            if (currentStar == null) return;

            // Lưu lại số sao đã chọn
            _soSaoDaChon = Array.IndexOf(_starBoxes, currentStar) + 1;

            // Cập nhật hiển thị (sao_MouseLeave sẽ không thay đổi nó)
            UpdateStarDisplay(_soSaoDaChon);
        }

        // ===============================================
        // GỬI ĐÁNH GIÁ (SUBMISSION)
        // ===============================================

        private async void GuiPhanHoi_Click(object sender, EventArgs e)
        {
            if (_soSaoDaChon == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao đánh giá.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string noiDung = NhapDanhGia.Text.Trim();
            if (string.IsNullOrWhiteSpace(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung bình luận.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giao thức: POST_REVIEW|IdTaiKhoan|IdPhim|NoiDung|SoSao
            // Lưu ý: Dùng Base64 để mã hóa NộiDung nếu TCP không đảm bảo ký tự UTF8 nguyên vẹn
            // Tuy nhiên, dựa trên snippet ServerTCP, chúng ta sẽ gửi chuỗi thẳng
            string command = $"POST_REVIEW|{CurrentUserId}|{PhimHienTai.IdPhim}|{noiDung}|{_soSaoDaChon}";

            // 2. GỬI LỆNH ĐẾN SERVER
            string response = await clientTcp.SendMessageAsync(command);

            // 3. XỬ LÝ PHẢN HỒI
            if (response == "SUCCESS")
            {
                MessageBox.Show("Đánh giá của bạn đã được gửi thành công!", "Thành công");

                // Reset UI sau khi gửi thành công
                NhapDanhGia.Text = string.Empty;
                _soSaoDaChon = 0;
                UpdateStarDisplay(0);

                await LoadReviewData(PhimHienTai.IdPhim); // Tải lại danh sách
            }
            else
            {
                MessageBox.Show($"Lỗi gửi đánh giá: {response}", "Lỗi");
            }
        }

        // ===============================================
        // TẢI VÀ HIỂN THỊ ĐÁNH GIÁ (DISPLAY)
        // ===============================================
       
        private async Task LoadReviewData(string idPhim)
        {
            // Giao thức: GET_REVIEW_SUMMARY|IdPhim
            string command = $"GET_REVIEW_SUMMARY|{idPhim}";

            string jsonResponse = await clientTcp.SendMessageAsync(command);

            if (jsonResponse.StartsWith("ERROR"))
            {
                MessageBox.Show($"Không thể tải dữ liệu đánh giá: {jsonResponse}", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Deserialize JSON string thành ReviewSummary object
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var summary = JsonSerializer.Deserialize<ReviewSummary>(jsonResponse, options);

                if (summary == null) throw new Exception("Dữ liệu summary rỗng");

                // 1. Cập nhật tổng quan
                UpdateAverageRatingDisplay(summary.AvgRating, summary.TotalReviews);

                // 2. Hiển thị danh sách đánh giá
                DisplayReviews(summary.LatestReviews);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý dữ liệu đánh giá: {ex.Message}\nJSON nhận được: {jsonResponse}", "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAverageRatingDisplay(float avgRating, int totalReviews)
        {
            DTB.Text = $"{avgRating:0.0}";
            TongSoLuotDanhGia.Text = $"{totalReviews} lượt đánh giá";
        }

        private void DisplayReviews(List<ReviewDisplay> reviews)
        {
            // Xóa các đánh giá cũ
            if (DanhSachCacDanhGia == null) return;
            DanhSachCacDanhGia.Controls.Clear();

            if (reviews == null || reviews.Count == 0)
            {
                Label lbl = new Label { Text = "Chưa có đánh giá nào cho phim này.", AutoSize = true, Margin = new Padding(10) };
                DanhSachCacDanhGia.Controls.Add(lbl);
                return;
            }

            foreach (var review in reviews)
            {
                // Tạo Review Card
                FlowLayoutPanel reviewPanel = new FlowLayoutPanel();
                // ... (cài đặt FlowLayoutPanel) ...

                // 1. Dòng Tiêu đề (User + Ngôi sao)
                Label lblHeader = new Label();
                lblHeader.Text = review.HoTen; // Dùng thuộc tính HoTen mới
                lblHeader.Font = new Font(lblHeader.Font, FontStyle.Bold);
                lblHeader.AutoSize = true;
                reviewPanel.Controls.Add(lblHeader);

                // 2. Hiển thị Ngôi sao (tạo động)
                FlowLayoutPanel starContainer = new FlowLayoutPanel { AutoSize = true, FlowDirection = FlowDirection.LeftToRight };
                int rating = review.SoSao ?? 0; // Đảm bảo rating là 0 nếu SoSao là null

                for (int i = 0; i < 5; i++)
                {
                    PictureBox pbStar = new PictureBox
                    {
                        // SỬA: Sử dụng thuộc tính SoSao để gán hình ảnh
                        Image = (i < rating) ? SaoVang : SaoXam, // <<< ĐÃ SỬA
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Size = new Size(20, 20),
                        Margin = new Padding(1)
                    };
                    starContainer.Controls.Add(pbStar);
                }
                reviewPanel.Controls.Add(starContainer);

                

                // 3. Nội dung bình luận
                Label lblComment = new Label();
                lblComment.Text = review.NoiDung; // Dùng thuộc tính NoiDung
                                                  // ...

                // 4. Ngày tạo
                // ... (hiện tại không có, tạm bỏ qua hoặc dùng placeholder)

                DanhSachCacDanhGia.Controls.Add(reviewPanel);
            }
        }
        // ===============================================
        // CÁC HÀM KHÁC (GIỮ NGUYÊN HOẶC ĐƠN GIẢN HÓA)
        // ===============================================

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            // Giả định có MenuTaiKhoan
            // MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
        }

        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formTrangChuChinh != null)
            {
                this.Hide(); //An form chi tiet hien tai 
                formTrangChuChinh.Show(); //Hien thi TrangChuChinh
            }
            else
            {
                this.Close();
            }
        }
    }
}