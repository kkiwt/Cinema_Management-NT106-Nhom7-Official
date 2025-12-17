
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

        public void SetData(VeDat ve)
        {
    
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

            // Tên phòng chiếu
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

            return idPhongChieu + idPhim; 
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
          
                    picturePoster.BackColor = Color.White;
                    return;
                }

                picturePoster.LoadAsync(posterUrl);
            }
            catch
            {

                picturePoster.BackColor = Color.White;
            }
        }

        private void lbTenPhongChieu_Click(object sender, EventArgs e)
        {

        }
    }
}
