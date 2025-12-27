namespace CinemaManagement
{
    public partial class PhimItemControl : UserControl
    {
        public event EventHandler<PhimDuocChonEventArgs> PhimDuocChon;
        public event EventHandler<PhimDuocChonEventArgs> DatVeDuocChon;
        private Phim PhimHienTai;
        public PhimItemControl()
        {
            InitializeComponent();
        }

        public void ThongTinPhim(Phim phim)
        {
            PhimHienTai = phim;
            TenPhim.Text = phim.TenPhim;
            try
            {
                if (!string.IsNullOrEmpty(phim.PosterPhim))
                {
                    PosterPhim.LoadAsync(phim.PosterPhim);
                }
                else
                {
                    PosterPhim.Image = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi tải poster phim: {ex.Message}");
                PosterPhim.Image = null;
            }

        }

        protected virtual void OnPhimDuocChon(Phim phim) 
        {
            PhimDuocChon?.Invoke(this, new PhimDuocChonEventArgs(phim));
        }


        private void DatVePhim_Click(object sender, EventArgs e)
        {
            if (PhimHienTai != null)
                DatVeDuocChon?.Invoke(this, new PhimDuocChonEventArgs(PhimHienTai));
        }


        private void ChiTiet_Click(object sender, EventArgs e)
        {
            if (PhimHienTai != null)
            {
                OnPhimDuocChon(PhimHienTai);
            }
            else
            {
                MessageBox.Show($"Chi tiết phim: {TenPhim.Text}");
            }
        }

  
    }

}
