using System.Text.Json;
using System.Text.Json.Serialization;
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
        }

        private async void TrangChuChinh_Load(object sender, EventArgs e)
        {
            var tcpClient = new ClientTCP();

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
                BangPhim.Controls.Add(MucPhim);
            }
        }
        private void MucPhimDuocChon(object sender, PhimDuocChonEventArgs e)
        {
            Phim PhimDaDuocChon = e.PhimDuocChon;
            ChiTietPhim formChiTiet = new ChiTietPhim(this); //them this vi ben ChiTietPhim co chen parentForm
            formChiTiet.HienThiThongTinPhim(PhimDaDuocChon);
            this.Hide(); //lien quan toi linklable TrangChuChinh o ChiTietphim neu muon quay lai TrangChuChinh
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

        }

        private void LinkTrangChuChinh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //An vao thi tro ve trang dau tien
            ViTriBatDauCuaMotPhim = 0;
            HienThiPhim();
            CapNhatNutDiChuyen();
            CapNhatTrang();
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
