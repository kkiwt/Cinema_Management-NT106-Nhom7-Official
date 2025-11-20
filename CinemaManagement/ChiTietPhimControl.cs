using CinemaManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class ChiTietPhimControl : UserControl
    {
        private Phim PhimHienTai;
        public ChiTietPhimControl()
        {
            InitializeComponent();
        }

        public void ThongTinChiTiet(Phim Movie)
        {
            PhimHienTai = Movie;
            TenPhim.Text = Movie.TenPhim;
            DaoDien.Text = Movie.DaoDien;
          //  DienVien.Text = Movie.DienVien;
            TheLoai.Text = Movie.TheLoai;
           // ThoiLuong.Text = Movie.ThoiLuong;
            NgonNgu.Text = Movie.NgonNgu;
            QuocGia.Text = Movie.QuocGia;
            DoTuoi.Text = Movie.DoTuoi;
            MoTa.Text = Movie.MoTa;

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

    }
}
