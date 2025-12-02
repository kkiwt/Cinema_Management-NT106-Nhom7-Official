using System.Text.Json;
using System.Text.Json.Serialization;

namespace CinemaManagement
{

    public partial class TrangChuChinh : Form
    {

        private List<Phim> DanhSachPhim = new List<Phim>();
        private int ViTriBatDauCuaMotPhim = 0;

        private int KichThuocTrang = 3;
        private int TongSoTrang = 1;
        private int TrangHienTai = 1;

        public TrangChuChinh()
        {
            InitializeComponent();
            this.Load += TrangChuChinh_Load; // Gan su kien Load
            TimKiem.KeyPress += TimKiem_KeyPress; //Tim kiem
        }



        private async void TrangChuChinh_Load(object sender, EventArgs e)
        {
            var tcpClient = new ClientTCP();
            if (currentUser.LaNhanVien ==   true)
                {
                NutStaffOnly.Visible = true;
            }
            else
            {
                NutStaffOnly.Visible = false;
            }
            int GioiHanPhim = 100;
            string command = $"GET_LATEST_MOVIES|{GioiHanPhim}";
            string response = await tcpClient.SendMessageAsync(command);

            if (!response.StartsWith("ERROR"))
            {
                try
                {
                    var Options = new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        // Cho phep doc so tu chuoi neu can, khac phuc loi dinh dang locale 
                        NumberHandling = JsonNumberHandling.AllowReadingFromString
                    };

                    //Dung Ops da tao
                    DanhSachPhim = JsonSerializer.Deserialize<List<Phim>>(response, Options);

                    if (DanhSachPhim != null && DanhSachPhim.Count > 0)
                    {
                        TongSoTrang = (int)Math.Ceiling((double)DanhSachPhim.Count / KichThuocTrang);
                        TrangHienTai = 1;

                        HienThiPhim();
                        CapNhatNutDiChuyen();
                        CapNhatTrang();
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu phim nào từ Server.");
                        CapNhatNutDiChuyen(); //Van goi de vo hieu hoa nut
                        CapNhatTrang();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi parse dữ liệu phim: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không thể tải danh sách phim: " + response);
            }
        }


        private void CapNhatNutDiChuyen()
        {
            Prev.Enabled = ViTriBatDauCuaMotPhim > 0;
            Next.Enabled = ViTriBatDauCuaMotPhim + 3 < DanhSachPhim.Count;
        }
        private void CapNhatTrang()
        {
            if (DanhSachPhim.Count > 0)
            {
                TrangHienTai = (ViTriBatDauCuaMotPhim / KichThuocTrang) + 1;
                Trang.Text = $"Trang {TrangHienTai} / {TongSoTrang}";
            }
            else
            {
                Trang.Text = "Không có phim nào";
            }
        }

        private void HienThiPhim()
        {
            BangPhim.Controls.Clear();


            for (int i = ViTriBatDauCuaMotPhim; i < ViTriBatDauCuaMotPhim + KichThuocTrang && i < DanhSachPhim.Count; i++)
            {
                var MucPhim = new PhimItemControl();
                var DuLieuPhim = DanhSachPhim[i];

                MucPhim.ThongTinPhim(DuLieuPhim);
                MucPhim.PhimDuocChon += MucPhimDuocChon;
                MucPhim.DatVeDuocChon += MucDatVeDuocChon; // Đặt vé
                BangPhim.Controls.Add(MucPhim);
            }
        }

        private void MucPhimDuocChon(object sender, PhimDuocChonEventArgs e)
        {
            Phim PhimDaDuocChon = e.PhimDuocChon;
            ChiTietPhim formChiTiet = new ChiTietPhim(this, currentUser); // Truyền user
            formChiTiet.HienThiThongTinPhim(PhimDaDuocChon);
            this.Hide();
            formChiTiet.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (ViTriBatDauCuaMotPhim + 3 < DanhSachPhim.Count)
            {
                ViTriBatDauCuaMotPhim += 3;
                HienThiPhim();
                CapNhatNutDiChuyen();
                CapNhatTrang(); //Cap nhat label
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (ViTriBatDauCuaMotPhim > 0)
            {
                ViTriBatDauCuaMotPhim = Math.Max(0, ViTriBatDauCuaMotPhim - 3);
                HienThiPhim();
                CapNhatNutDiChuyen();
                CapNhatTrang();
            }
        }

        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //An vao thi tro ve trang dau tien
            ViTriBatDauCuaMotPhim = 0;
            HienThiPhim();
            CapNhatNutDiChuyen();
            CapNhatTrang();
        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
        }
        private void UuDai_Click(object sender, EventArgs e)
        {
            DanhSachUuDai danhSachUuDai = new DanhSachUuDai();
            this.Hide();
            danhSachUuDai.ShowDialog();
        }

        private void PhimHot_Click(object sender, EventArgs e)
        {
            PhimHot phimhot = new PhimHot(this, currentUser);// 'this' là TrangChuChinh
            this.Hide();
            phimhot.ShowDialog();
        }

        private void TimKiem_KeyPress(object sender, KeyPressEventArgs e)  //Ham de tim kiem phim
        {
            if (e.KeyChar == (char)Keys.Enter) //An enter
            {
                e.Handled = true; //chan tieng bệp cua window

                string TenPhimCanTim = TimKiem.Text.Trim();
                if (!string.IsNullOrEmpty(TenPhimCanTim))
                {
                    TimKiemVaHienThiChiTiet(TenPhimCanTim);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên phim cần tìm.", "Thông báo");
                }
            }
        }

        public void TimKiemVaHienThiChiTiet(string tenPhim) //Ham de tim kiem phim
        {
            string TenPhimThuong = tenPhim.ToLower(); //Khong phan biet chu hoa/thuong khi nhap vao tim kiem

            Phim PhimDuocTimThay = DanhSachPhim.FirstOrDefault(p => p.TenPhim.ToLower().Contains(TenPhimThuong)); //Tim kiem phim tu list

            if (PhimDuocTimThay != null)
            {
                ChiTietPhim chitietphim = new ChiTietPhim(this, currentUser); //Chuuyen sang ChiTietPhim
                chitietphim.HienThiThongTinPhim(PhimDuocTimThay);
                this.Hide();
                chitietphim.Show();
                TimKiem.Text = "";
            }
            else
            {
                MessageBox.Show($"Không tìm thấy phim có tên gần giống '{tenPhim}'.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongTinTaiKhoan = new ThongTInTaiKhoan(currentUser);
            this.Hide();
            thongTinTaiKhoan.ShowDialog();


        }
        private UserInfo currentUser;
        public TrangChuChinh(UserInfo user)
        {
            InitializeComponent();
            currentUser = user; // Lưu lại để dùng sau
            this.Load += TrangChuChinh_Load;
            TimKiem.KeyPress += TimKiem_KeyPress;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            var dangNhap = new PhanDangNhap();
            this.Hide();
            dangNhap.Show();
            // Đóng form hiện tại thay vì Hide()
        }

        private void UuDai_Click_1(object sender, EventArgs e)
        {
            var danhSachUuDai = new DanhSachUuDai(); // Truyền user hiện tại
            this.Hide();
            danhSachUuDai.ShowDialog();
        }

        private void MucDatVeDuocChon(object sender, PhimDuocChonEventArgs e)
        {
            Phim phimChon = e.PhimDuocChon;
            if (phimChon != null && currentUser != null)
            {
                ChonPhongChieu formChonPhong = new ChonPhongChieu(phimChon, currentUser);
                this.Hide();
                formChonPhong.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không thể đặt vé vì thiếu thông tin.", "Lỗi");
            }
        }


        private void NutStaffOnly_Click(object sender, EventArgs e)
        {
            var staffForm = new StaffOnLy();
            staffForm.Owner = this; // Quan trọng để StaffOnly biết ai là cha
            staffForm.ShowDialog();
        }



        public async void RefreshDanhSachPhim()
        {
            var tcpClient = new ClientTCP();
            string command = "GET_LATEST_MOVIES|100";
            string response = await tcpClient.SendMessageAsync(command);
            if (!response.StartsWith("ERROR"))
            {
                var Options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    NumberHandling = JsonNumberHandling.AllowReadingFromString
                };
                DanhSachPhim = JsonSerializer.Deserialize<List<Phim>>(response, Options);
                HienThiPhim();
                CapNhatNutDiChuyen();
                CapNhatTrang();
            }
        }


    }




    public class PhimDuocChonEventArgs : EventArgs
    {
        public Phim PhimDuocChon { get; private set; }

        public PhimDuocChonEventArgs(Phim phim)
        {
            this.PhimDuocChon = phim;
        }
    }

}
