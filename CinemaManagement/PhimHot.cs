using System.Text.Json;

namespace CinemaManagement
{
    public partial class PhimHot : Form
    {
        private Form ParentForm;
        private List<Phim> DanhSachPhimDaTai = new List<Phim>();

        public PhimHot(Form parentForm)
        {
            InitializeComponent();
            this.ParentForm = parentForm;
            this.Load += DanhSachPhim_Load;
            LinkTrangChuChinh.LinkClicked += LinkTrangChuChinh_LinkClicked;
            TimKiem.KeyPress += TimKiem_KeyPress;  //Tim kiem phim
        }

        private async void DanhSachPhim_Load(object sender, EventArgs e)
        {
            await TaiVaHienThiPhim();
        }

        public async Task TaiVaHienThiPhim()
        {
            this.Cursor = Cursors.WaitCursor;
            flpDanhSachPhim.Controls.Clear();

            var tcpClient = new ClientTCP();
            string command = "GET_LATEST_MOVIES|100";
            string response = await tcpClient.SendMessageAsync(command);

            this.Cursor = Cursors.Default; //Tra lai con tro mac dinh

            if (!response.StartsWith("ERROR"))
            {
                try
                {
                    var Options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true }; //phim da dc dinh nghia Model.cs
                    DanhSachPhimDaTai = JsonSerializer.Deserialize<List<Phim>>(response, Options);
                    HienThiPhim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi parse dữ liệu phim: " + ex.Message, "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách phim: " + response.Replace("ERROR: ", ""), "Lỗi Kết Nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiPhim()
        {
            flpDanhSachPhim.Controls.Clear();

            if (DanhSachPhimDaTai == null || DanhSachPhimDaTai.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phim nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var DuLieuPhim in DanhSachPhimDaTai)
            {
                var MucPhim = new PhimItemControl();
                MucPhim.ThongTinPhim(DuLieuPhim);
                MucPhim.PhimDuocChon += MucPhimDuocChon; //Chuyen sang ChiTietPhim
                flpDanhSachPhim.Controls.Add(MucPhim);
            }
        }

        private void MucPhimDuocChon(object sender, PhimDuocChonEventArgs e)
        {
            Phim PhimDaDuocChon = e.PhimDuocChon;
            TrangChuChinh formTrangChuChinh = ParentForm as TrangChuChinh; // Lay TrangChuChinh de truyen vao ChiTietPhim

            if (ParentForm is ChiTietPhim chiTietPhim)
            {
                formTrangChuChinh = chiTietPhim.GetTrangChuChinh();
            }

            if (formTrangChuChinh != null)
            {
                ChiTietPhim formChiTietPhim = new ChiTietPhim(formTrangChuChinh);
                formChiTietPhim.HienThiThongTinPhim(PhimDaDuocChon);
                this.Hide();
                formChiTietPhim.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không thể chuyển đến trang chi tiết vì không có Form Trang Chủ Chính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Parent form co phai la TrangChuChinh hay khong
            TrangChuChinh formTrangChuChinh = ParentForm as TrangChuChinh;

            if (formTrangChuChinh != null)
            {
                this.Close(); //Dong PhimHot
                formTrangChuChinh.Show(); // Hien TrangChuChinh
            }
            else
            {
                MessageBox.Show("Lỗi định tuyến. Không tìm thấy Trang Chủ Chính.", "Lỗi");
            }
        }

        private void TimKiem_KeyPress(object sender, KeyPressEventArgs e)  //Ham tim kiem phim
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string TenPhimCanTim = TimKiem.Text.Trim();

                TrangChuChinh formTrangChuChinh = ParentForm as TrangChuChinh;

                if (ParentForm is ChiTietPhim chiTietPhim)
                {
                    formTrangChuChinh = chiTietPhim.GetTrangChuChinh();
                }

                if (formTrangChuChinh != null && !string.IsNullOrEmpty(TenPhimCanTim))
                {
                    this.Close(); //dong PhimHot

                    formTrangChuChinh.TimKiemVaHienThiChiTiet(TenPhimCanTim); //goi ham timkiem o TrangChuChinh
                }
                else if (formTrangChuChinh == null)
                {
                    MessageBox.Show("Lỗi: Không tìm thấy Trang Chủ Chính để thực hiện tìm kiếm.", "Lỗi");
                }

                TimKiem.Text = ""; //xoa ndung timkiem
            }
        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
        }
    }
}
