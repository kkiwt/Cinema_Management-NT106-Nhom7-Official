using CinemaManagement;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                // TẠO Form DanhGia và truyền đối tượng PhimHienTai
                DanhGia danhgia = new DanhGia(PhimHienTai);
                danhgia.Show();
            }
            else
            {
                MessageBox.Show("Không thể xem đánh giá vì thông tin phim không khả dụng.", "Lỗi");
            }
        }
    }
}



