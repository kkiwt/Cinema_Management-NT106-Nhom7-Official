using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CinemaManagement
{

    public partial class DanhGia : Form
    {
        private TrangChuChinh formTrangChuChinh;

        private List<Review> AllReviews = new List<Review>();

        private readonly ClientTCP clientTcp;
        private readonly Phim PhimHienTai;
        private readonly string CurrentUserId = "TK001"; 

        private int _soSaoDaChon = 0;
        private PictureBox[] _starBoxes;


        public DanhGia(Phim phim)
        {
            InitializeComponent();

            this.PhimHienTai = phim;
            this.clientTcp = new ClientTCP();

            this.Load += DanhGia_Load;


            _starBoxes = new PictureBox[]
            {
                this.Controls.Find("Sao1", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao2", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao3", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao4", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Sao5", true).FirstOrDefault() as PictureBox
            }.Where(pb => pb != null).ToArray();


            for (int i = 0; i < _starBoxes.Length; i++)
            {
                if (_starBoxes[i] != null) 
                {
                    _starBoxes[i].Tag = i + 1; 
                    _starBoxes[i].Click += Star_Click;
                }
            }

            var btnGuiReview = this.Controls.Find("BtnGuiReview", true).FirstOrDefault();
            if (btnGuiReview != null)
            {
                btnGuiReview.Click += BtnGuiReview_Click;
            }
        }

        public DanhGia()
        {
            InitializeComponent();
        }

        private async void DanhGia_Load(object sender, EventArgs e)
        {
            if (PhimHienTai != null)
            {
                this.Text = $"Đánh giá phim: {PhimHienTai.TenPhim}";
                await LoadReviewData(PhimHienTai.IdPhim);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phim.", "Lỗi");
                this.Close();
            }
        }

        public async Task LoadReviewData(string idPhim)
        {
            string command = $"GET_REVIEW_SUMMARY|{idPhim}";
            string response = await clientTcp.SendMessageAsync(command);

            if (response.StartsWith("ERROR"))
            {
                MessageBox.Show("Lỗi khi tải dữ liệu đánh giá: " + response, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var doc = JsonDocument.Parse(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi phân tích dữ liệu JSON: {ex.Message}", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Star_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox clickedStar && clickedStar.Tag is int starRating)
            {
                _soSaoDaChon = starRating;
                UpdateStarDisplay(_soSaoDaChon);
            }
        }

        private void UpdateStarDisplay(int rating)
        {
            if (_starBoxes == null || _starBoxes.Length == 0) return;

            // Logic tô màu sao hoạt động tốt nếu Resources đã được thêm đúng
            for (int i = 0; i < _starBoxes.Length; i++)
            {
                if (_starBoxes[i] != null)
                {
                   // _starBoxes[i].Image = (i < rating) ?
                    //    Properties.Resources.star_filled :
                   //     Properties.Resources.star_empty;
                }
            }
        }


        private async void BtnGuiReview_Click(object sender, EventArgs e)
        {
            // 1. LẤY SỐ SAO VÀ NỘI DUNG
            int soSao = _soSaoDaChon;

            // Kiểm tra control NoiDungDanhGiaUser
            // LƯU Ý: Control này PHẢI ĐƯỢC KHAI BÁO trong DanhGia.Designer.cs (do đó tôi không chỉnh sửa dòng này)
            string noiDung = NoiDungDanhGiaUser.Text.Trim();

            if (soSao < 1 || soSao > 5)
            {
                MessageBox.Show("Vui lòng chọn số sao (1-5) để đánh giá.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung đánh giá.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. GỬI ĐÁNH GIÁ
            string command = $"POST_REVIEW|{CurrentUserId}|{PhimHienTai.IdPhim}|{noiDung}|{soSao}";
            string response = await clientTcp.SendMessageAsync(command);

            // 3. XỬ LÝ PHẢN HỒI
            if (response == "SUCCESS")
            {
                MessageBox.Show("Đánh giá của bạn đã được gửi thành công!", "Thành công");

                // Reset UI sau khi gửi thành công
                // LƯU Ý: Control này PHẢI ĐƯỢC KHAI BÁO trong DanhGia.Designer.cs
                NoiDungDanhGiaUser.Text = string.Empty;
                _soSaoDaChon = 0;
                UpdateStarDisplay(0);

                await LoadReviewData(PhimHienTai.IdPhim); // Tải lại danh sách
            }
            else
            {
                MessageBox.Show($"Lỗi gửi đánh giá: {response}", "Lỗi");
            }
        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
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

        private void LinkTenPhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Bạn đang ở trang chi tiết của phim: {PhimHienTai.TenPhim}");
        }
    }
}