
namespace CinemaManagement
{
    public partial class DanhGiaItemControl : UserControl
    {
        private string currentUserId;
        private string idReview;
        UserInfo currentUser;
        public DanhGiaItemControl(ReviewDisplay review, UserInfo currentUser)
        {
            InitializeComponent();

            // Gán dữ liệu
            LoadReview(review);
            this.currentUser = currentUser; // lưu lại toàn bộ user
            idReview = review.IdReview;

            // Quyền hiển thị nút Xóa:
            // - Chủ review: review.IdTaiKhoan == currentUser.IDUser
            // - Nhân viên: currentUser.LaNhanVien == true
            if (review.IdTaiKhoan == currentUser.IDUser || currentUser.LaNhanVien)
            {

            }
            else
            {
                Xoa.Visible = false; // Ẩn nút xóa
            }
        }


        public void LoadReview(ReviewDisplay Review)
        {
            TenNguoiDung.Text = Review.HoTen;
            NoiDungDanhGia.Text = Review.NoiDung;
            HienThiSao(Review.SoSao);
            idReview = Review.IdReview;   // 🔥 GÁN ID REVIEW – QUAN TRỌNG
            string UserIdHienTai = Review.IdTaiKhoan;
        }

        private void HienThiSao(int SoSao)
        {
            Sao.Controls.Clear();
            string Stars = "";
            for (int i = 0; i < 5; i++)
            {
                Stars += (i < SoSao) ? "★" : "☆"; 
            }

            Label StarLabel = new Label()
            {
                Text = Stars,
                Font = new Font(FontFamily.GenericSansSerif, 20),
                AutoSize = true
            };
            Sao.Controls.Add(StarLabel);
        }

        private async void Xoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
            "Bạn có chắc muốn xoá đánh giá này?",
            "Xác nhận xoá",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        );

            if (confirm == DialogResult.Yes)
            {
                ClientTCP client = new ClientTCP();
                string message = $"DELETE_REVIEW|{idReview}";
                string response = await client.SendMessageAsync(message);

                if (response == "SUCCESS")
                {
                    MessageBox.Show("Đã xoá đánh giá!");
                    this.Parent.Controls.Remove(this); // Xoá control khỏi giao diện
                }
                else
                {
                    MessageBox.Show($"Lỗi khi xoá: {response}");
                }
            }
        }

        
    }
}