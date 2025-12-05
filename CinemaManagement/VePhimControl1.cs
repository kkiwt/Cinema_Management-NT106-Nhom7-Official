
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
            // Tên phim: nếu chưa có trong JSON thì placeholder
            lbTenPhim.Text = string.IsNullOrWhiteSpace(ve.TenPhim)
                ? "Phim (đang cập nhật)"
                : ve.TenPhim;

            lbIDVe.Text = $"Mã vé: {ve.IdVe}";
            lbGheNgoi.Text = $"Ghế ngồi: {ve.Ghe}";

            // Giá vé: format theo tiền Việt
            // Bạn có thể cập nhật theo format mong muốn
            lbGiaVe.Text = $"Giá vé: {ve.GiaVe:#,0} đ";

            // Giờ & Ngày chiếu
            lbGioChieu.Text = $"Giờ chiếu: {FormatGio(ve.GioChieu)}";
            lbNgayChieu.Text = $"Ngày chiếu: {FormatNgay(ve.NgayChieu)}";

            // Poster: nếu có PosterUrl => load async, nếu không, để nền trắng hoặc icon mặc định
            _ = LoadPosterAsync(ve.PosterUrl);
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

                using var http = new HttpClient();
                var bytes = await http.GetByteArrayAsync(posterUrl);
                using var ms = new System.IO.MemoryStream(bytes);
                var img = Image.FromStream(ms);
                picturePoster.Image = img;
            }
            catch
            {
                // Không nên làm vỡ UI nếu ảnh lỗi
                picturePoster.BackColor = Color.White;
            }
        }
    }
}
