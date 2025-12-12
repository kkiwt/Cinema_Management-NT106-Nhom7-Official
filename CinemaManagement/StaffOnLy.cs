using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CinemaManagement
{
    public partial class StaffOnLy : Form
    {
        public StaffOnLy()
        {
            InitializeComponent();

        }



        private void CreateChart()
        {



        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }


        private ClientTCP client = new ClientTCP();

        private async void StaffOnLy_Load(object sender, EventArgs e)
        {
            await LoadStats();
        }

        private async Task LoadStats()
        {

            string response = await client.SendMessageAsync("GET_STATS2");
            if (!string.IsNullOrWhiteSpace(response) && !response.StartsWith("ERROR"))
            {
                var json = System.Text.Json.JsonDocument.Parse(response);
                var root = json.RootElement[0]; // Supabase trả về array

                // Cập nhật theo Name đã khai báo trong Designer
                ThongKeVeDoanhThu.Nodes["SoLuongVeRoot"].Text =
                    $"Số Lượng Vé Đã Bán Ra: {root.GetProperty("tong_so_ve").GetInt64()}";



                ThongKeVeDoanhThu.Nodes["DoanhThuRoot"].Text =
                    $"Tổng Doanh Thu Của Rạp: {root.GetProperty("doanh_thu").GetDecimal():N0} VND";
                ThongKeVeDoanhThu.Nodes["DoanhThuRoot"].Nodes["NodePhim"].Text =
                    $"Doanh Thu Phim: {root.GetProperty("doanh_thu_phim").GetDecimal():N0} VND";

                ThongKeVeDoanhThu.Nodes["DoanhThuRoot"].Nodes["NodeBapNuoc"].Text =
                    $"Doanh Thu Bắp Nước: {root.GetProperty("doanh_thu_bapnuoc").GetDecimal():N0} VND";

                ThongKeVeDoanhThu.Nodes["RootSoPhim"].Text =
                    $"Số Phim Đang Chiếu: {root.GetProperty("so_phim").GetInt64()}";
            }
            else
            {
                MessageBox.Show("Không thể tải thống kê: " + response);
            }

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void nightPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }


        private void ThemPhim_Click(object sender, EventArgs e)
        {
            var themphim = new PhanThemPhim();

            // Đăng ký sự kiện khi thêm phim thành công
            themphim.PhimDaThemThanhCong += () =>
            {
                // Lấy form TrangChuChinh từ Owner
                var trangChu = this.Owner as TrangChuChinh;
                if (trangChu != null)
                {
                    trangChu.RefreshDanhSachPhim(); // Gọi hàm refresh
                }
            };

            // Hiển thị form thêm phim dưới dạng dialog
            themphim.ShowDialog();
        }


        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NutThemUuDai_Click(object sender, EventArgs e)
        {
            PhanThemUuDai uudai = new PhanThemUuDai();
            uudai.ShowDialog();
        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void NutLichSu_Click(object sender, EventArgs e)
        {
            PhanLichSu lichsu = new PhanLichSu();
            lichsu.ShowDialog();
        }

        private void NutXemDanhSachPhim_Click(object sender, EventArgs e)
        {
            PhanDanhSachPhim ds = new PhanDanhSachPhim();
            ds.ShowDialog();
        }
    }
}
