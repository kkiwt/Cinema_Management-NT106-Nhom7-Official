// DanhSachNguoiDanhGia.cs (Đã sửa đổi)
using System;
using System.Drawing;
using System.Linq; // Thêm
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class DanhSachNguoiDanhGia : UserControl
    {
        private PictureBox[] _starBoxesReview; // Biến mới để giữ các PictureBox sao

        public DanhSachNguoiDanhGia()
        {
            InitializeComponent();

            // Giả định: Tìm kiếm các PictureBox sao trên User Control
            _starBoxesReview = new PictureBox[]
            {
                this.Controls.Find("Star1", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Star2", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Star3", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Star4", true).FirstOrDefault() as PictureBox,
                this.Controls.Find("Star5", true).FirstOrDefault() as PictureBox
            }.Where(pb => pb != null).ToArray();
        }


        public void SetReviewData(string hoTen, string noiDung, int soSao)
        {
            // 1. Cập nhật Họ Tên và Nội dung
            // Giả định các control HoTen và NoiDungDanhGiaNgKhac đã tồn tại
            if (HoTen != null)
            {
                HoTen.Text = hoTen;
            }
            if (NoiDungDanhGiaNgKhac != null)
            {
                NoiDungDanhGiaNgKhac.Text = noiDung;
            }

            // 2. Hiển thị Số sao (Logic mới)
            UpdateReviewStarDisplay(soSao);
        }

        private void UpdateReviewStarDisplay(int rating)
        {
            if (_starBoxesReview == null || _starBoxesReview.Length == 0) return;

            // Logic tô màu sao dựa trên rating
            for (int i = 0; i < _starBoxesReview.Length; i++)
            {
                if (_starBoxesReview[i] != null)
                {
                    // Cần có hình ảnh sao trong Resources (star_filled, star_empty)
                    // _starBoxesReview[i].Image = (i < rating) ?
                    //    Properties.Resources.star_filled :
                    //     Properties.Resources.star_empty;
                }
            }
        }

     
    }
}