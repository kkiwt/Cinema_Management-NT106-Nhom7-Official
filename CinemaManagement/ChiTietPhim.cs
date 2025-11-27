
namespace CinemaManagement
{
    public partial class ChiTietPhim : Form
    {
        private TrangChuChinh formTrangChuChinh;
        private Phim PhimHienTai;
        public ChiTietPhim(TrangChuChinh parentForm)
        {
            InitializeComponent();
            this.formTrangChuChinh = parentForm;
            TimKiem.KeyPress += TimKiem_KeyPress; //Tim kiem
        }
        private UserInfo currentUser;

        public ChiTietPhim(TrangChuChinh parentForm, UserInfo user)
        {
            InitializeComponent();
            this.formTrangChuChinh = parentForm;
            this.currentUser = user; // Lưu thông tin người dùng
            TimKiem.KeyPress += TimKiem_KeyPress;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            var dangNhap = new PhanDangNhap();
            this.Hide();
            dangNhap.Show();
            // Đóng form hiện tại thay vì Hide()
        }

        private void ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongTinTaiKhoan = new ThongTInTaiKhoan(currentUser);
            this.Hide();
            thongTinTaiKhoan.ShowDialog();


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
                    // Mo trinh duyet
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(PhimHienTai.UrlTrailer) { UseShellExecute = true });
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
            if (formTrangChuChinh != null)
            {
                PhimHot phimhot = new PhimHot(formTrangChuChinh, currentUser);
                this.Hide(); //An ChiTietPhim
                phimhot.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không thể chuyển hướng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimKiem_KeyPress(object sender, KeyPressEventArgs e)  //Tim kiem
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string TenPhimCanTim = TimKiem.Text.Trim();

                if (formTrangChuChinh != null && !string.IsNullOrEmpty(TenPhimCanTim))
                {
                    this.Hide(); //An ChiTietPhim hien tai
                    formTrangChuChinh.TimKiemVaHienThiChiTiet(TenPhimCanTim); //goi ham tim kiem tren TrangChuChinh
                }
                else if (formTrangChuChinh == null)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy Trang Chủ Chính để thực hiện tìm kiếm.", "Lỗi");
                }

                TimKiem.Text = ""; //Xoa ndung tim kiem

            }
        }

        private void MenuTaiKhoan_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}



