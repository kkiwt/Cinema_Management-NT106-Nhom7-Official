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
    public partial class VePhimControl1 : UserControl
    {
        public VePhimControl1()
        {
            InitializeComponent();
        }
        private VeDat current;
        public void SetData(VeDat ve)
        {
            current = ve; 

            lbTenPhim.Text = ve.TenPhim;
            lbMaVe.Text = ve.IdVe;
            lbNgayChieu.Text = ve.NgayChieu.HasValue ? ve.NgayChieu.Value.ToString("dd/MM/yyyy") : "";
            lbGioChieu.Text = ve.GioChieu.HasValue ? ve.GioChieu.Value.ToString(@"hh\:mm") : "";
            lbGheNgoi.Text = ve.Ghe;
            lbGiaVe.Text = ve.GiaVe.HasValue ? $"{ve.GiaVe.Value:N0} VND" : "";

            if (!string.IsNullOrEmpty(ve.PosterPhim))
            {
                try
                {
                    picturePoster.LoadAsync(ve.PosterPhim);
                }
                catch
                {
                    picturePoster.Image = null;
                }
            }
            else
            {
                picturePoster.Image = null;
            }
            
        }

    }
}
