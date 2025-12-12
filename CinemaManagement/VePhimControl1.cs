
using System;
using System.Drawing;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class VePhimControl1 : UserControl
    {
        public VePhimControl1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set dữ liệu cho control từ model VeDat.
        /// Nếu thiếu TenPhim/PosterUrl, hiển thị placeholder.
        /// </summary>

        public void SetData(VeDat ve)
        {
            // Tên phim
            lbTenPhim.Text = string.IsNullOrWhiteSpace(ve.TenPhim)
                ? "Phim (đang cập nhật)"
                : ve.TenPhim;

            // Mã vé, ghế, giá vé
            lbIDVe.Text = $"Mã vé: {ve.IdVe}";
            lbGheNgoi.Text = $"Ghế ngồi: {(!string.IsNullOrWhiteSpace(ve.Ghe) ? ve.Ghe : "—")}";
            lbGiaVe.Text = $"Giá vé: {(ve.GiaVe.HasValue ? $"{ve.GiaVe.Value:#,0} đ" : "—")}";

            // Giờ & Ngày chiếu
            lbGioChieu.Text = $"Giờ chiếu: {FormatGio(ve.GioChieu)}";
            lbNgayChieu.Text = $"Ngày chiếu: {FormatNgay(ve.NgayChieu)}";

            // Tên phòng chiếu: ghép IdPhongChieu + IdPhim (ví dụ C01P04)
            string tenPhong = BuildTenPhongChieu(ve.IdPhongChieu, ve.IdPhim);
            lbTenPhongChieu.Text = $"Phòng chiếu: {tenPhong}";

            // Poster
            _ = LoadPosterAsync(ve.PosterUrl);
        }

        private static string BuildTenPhongChieu(string idPhongChieu, string idPhim)
        {
            if (string.IsNullOrWhiteSpace(idPhongChieu) && string.IsNullOrWhiteSpace(idPhim))
                return "—";

            if (string.IsNullOrWhiteSpace(idPhongChieu))
                return idPhim ?? "—";

            if (string.IsNullOrWhiteSpace(idPhim))
                return idPhongChieu ?? "—";

            return idPhongChieu + idPhim; // ví dụ: C01 + P04 => C01P04
        }


        private static string FormatGio(TimeSpan? gio)
            => gio.HasValue ? $"{gio.Value.Hours:00}:{gio.Value.Minutes:00}" : "—";

        private static string FormatNgay(DateTime? ngay)
            => ngay.HasValue ? ngay.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture) : "—";

        private async Task LoadPosterAsync(string posterUrl)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(posterUrl))
                {
                    // Placeholder: màu nền hoặc ảnh mặc định
                    picturePoster.BackColor = Color.White;
                    // TODO: set ảnh mặc định từ resources nếu có
                    return;
                }

                picturePoster.LoadAsync(posterUrl);
            }
            catch
            {
                // Không nên làm vỡ UI nếu ảnh lỗi
                picturePoster.BackColor = Color.White;
            }
        }

        private void lbTenPhongChieu_Click(object sender, EventArgs e)
        {

        }
    }
}
