using CinemaManagement;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using TrangChu;


namespace CinemaManagement
{
    public partial class MovieItemControl : UserControl
    {
        private Phim PhimHienTai;
        public event EventHandler<PhimDuocChonEventArgs> PhimDuocChon;

        public MovieItemControl()
        {
            InitializeComponent();
        }

        public void ThongTinPhim(Phim Movie)
        {
            PhimHienTai = Movie;
            TenPhim.Text = Movie.TenPhim;


            try
            {
                if (!string.IsNullOrEmpty(Movie.PosterPhim))
                {
                    PosterPhim.LoadAsync(Movie.PosterPhim);
                }
                else
                {
                    PosterPhim.BackColor = Color.Gray;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Lỗi tải ảnh: {ex.Message}");
                PosterPhim.BackColor = Color.Gray;
            }
        }

        private void KichHoatSuKienPhimDuocChon()
        {
            if (PhimHienTai != null)
                PhimDuocChon?.Invoke(this, new PhimDuocChonEventArgs(PhimHienTai));
        }

        private void ChiTietPhim_Click(object sender, EventArgs e)
        {
            if (PhimHienTai != null)
            {
                ChiTietPhim chitietphim = new ChiTietPhim(PhimHienTai);

                chitietphim.Show();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin phim.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatVePhim_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}