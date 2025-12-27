
namespace CinemaManagement
{
    public partial class ChiTietPhim : Form
    {
        private TrangChuChinh formTrangChuChinh;
        private Phim PhimHienTai;
        private UserInfo currentUser;

        public ChiTietPhim(TrangChuChinh parentForm, UserInfo user)
        {
            InitializeComponent();
            this.formTrangChuChinh = parentForm;
            this.currentUser = user; // Lưu thông tin người dùng
        }


        public void HienThiThongTinPhim(Phim phim)
        {
            if (phim == null) return;
            this.PhimHienTai = phim;
            this.Text = "Chi Tiết Phim: " + phim.TenPhim;
            LinkTenPhim.Text = phim.TenPhim;
            ThongTinChiTiet(phim);
        }

        public void ThongTinChiTiet(Phim phim)
        {
            if (phim == null) return;
            TenPhim.Text = phim.TenPhim;
            DaoDien.Text = phim.DaoDien;
            DienVien.Text = phim.DienVien;
            TheLoai.Text = phim.TheLoai;
            ThoiLuong.Text = phim.ThoiLuong.ToString() + " phút";
            DoTuoi.Text = phim.DoTuoi;
            NgonNgu.Text = phim.NgonNgu;
            QuocGia.Text = phim.QuocGia;
            MoTa.Text = phim.MoTa;

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
        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (formTrangChuChinh != null)
            {
                this.Hide(); 
                formTrangChuChinh.Show(); 
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

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
        }

        private void Trailer_Click(object sender, EventArgs e)
        {
            if (PhimHienTai != null && !string.IsNullOrEmpty(PhimHienTai.UrlTrailer))
            {
                try
                {
                    string embedUrl = TrailerForm.GetEmbedUrlFromYouTubeUrl(PhimHienTai.UrlTrailer);

                    using (var trailerForm = new TrailerForm(embedUrl))
                    {
                        trailerForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở trailer. Vui lòng kiểm tra URL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không có đường dẫn trailer cho phim này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DanhGia_Click(object sender, EventArgs e)
        {
            if (PhimHienTai != null)
            {
                this.Hide();
                DanhGia danhgia = new DanhGia(PhimHienTai, this, currentUser);
                danhgia.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không thể xem đánh giá vì thông tin phim không khả dụng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TroVeTrangChuChinh()
        {
            this.Close(); //Dong ChiTietPhim
            if (formTrangChuChinh != null)
            {
                formTrangChuChinh.Show(); //Hien thi TrangChuChinh
            }
        }

        public TrangChuChinh GetTrangChuChinh()
        {
            return formTrangChuChinh;
        }


        private void PhimHot_Click(object sender, EventArgs e)
        {
            var phimhot = new PhimHot(this, currentUser)
            {
                Owner = this // QUAN TRỌNG: PhimHot có Owner là TrangChuChinh
            };
            this.Hide();
            phimhot.ShowDialog();
            this.Show();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongTinTaiKhoan = new ThongTInTaiKhoan(currentUser);

            thongTinTaiKhoan.ShowDialog();


        }
        private void DatVe_Click(object sender, EventArgs e)
        {
            if (PhimHienTai != null && currentUser != null)
            {

                var formChonSuat = new ChonSuatChieu(PhimHienTai, currentUser);
                formChonSuat.Owner = this;         
                formChonSuat.ShowDialog();

            }
            else
            {
                MessageBox.Show("Không thể đặt vé vì thiếu thông tin phim hoặc người dùng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeDaDat_Click(object sender, EventArgs e)
        {
            VeDaDat veDaDatForm = new VeDaDat(currentUser);
            veDaDatForm.ShowDialog();
        }

        private void UuDai_Click(object sender, EventArgs e)
        {
            DanhSachUuDai danhSachUuDaiForm = new DanhSachUuDai();
            danhSachUuDaiForm.ShowDialog();
        }
    }
}



