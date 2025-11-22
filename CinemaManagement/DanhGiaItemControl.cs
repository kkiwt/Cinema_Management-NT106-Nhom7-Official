using System;
using System;
using System.Drawing;
using System.Windows.Forms;
using CinemaManagement; 

namespace CinemaManagement
{
    public partial class DanhGiaItemControl : UserControl
    {

        public DanhGiaItemControl(ReviewDisplay review)
        {
            InitializeComponent();
            LoadReview(review);


            // Thêm vào UserControl nếu chưa có
            this.Controls.Add(TenNguoiDung);
            this.Controls.Add(Sao);
            this.Controls.Add(NoiDungDanhGia);

            LoadReview(review);
        }

        public void LoadReview(ReviewDisplay review)
        {
            TenNguoiDung.Text = review.HoTen;
            NoiDungDanhGia.Text = review.NoiDung;

            // Vùng này cần logic để vẽ hoặc load 5 ngôi sao
            DisplayStars(review.SoSao);

            // Logic ẩn/hiện nút Sửa/Xóa (Cần biết IdTaiKhoan của người dùng hiện tại)
            string currentUserId = "ID_NGUOI_DUNG_HIEN_TAI"; // Cần lấy từ biến toàn cục

        }

        // Hàm hiển thị ngôi sao (ví dụ đơn giản)
        private void DisplayStars(int soSao)
        {
            Sao.Controls.Clear();
            string stars = "";
            for (int i = 0; i < 5; i++)
            {
                stars += (i < soSao) ? "★" : "☆"; // Unicode cho ngôi sao đặc và rỗng
            }

            Label starLabel = new Label()
            {
                Text = stars,
                Font = new Font(FontFamily.GenericSansSerif, 20),
                AutoSize = true
            };
            Sao.Controls.Add(starLabel);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}