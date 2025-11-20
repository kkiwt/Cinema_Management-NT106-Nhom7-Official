using CinemaManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrangChu
{
    public partial class ChiTietPhim : Form
    {
        private const string SupabaseUrl = "https://qyhamranljmfsrxfxfls.supabase.co";
        private const string SupabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF5aGFtcmFubGptZnNyeGZ4ZmxzIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjE0NjgzMzQsImV4cCI6MjA3NzA0NDMzNH0.Qtd4vxXBsDlx7ZDWFV92WTmHqXUpJrbyOqW8D5yIBJs";

        public ChiTietPhim(Phim Movie)
        {
            InitializeComponent();
            PhimHienTai = Movie; 
            if (Movie != null)
            {
                this.Text = Movie.TenPhim;
             //   IDPhim = Movie.IDPhim; 
            }
        }

        private string IDPhim;
        private Phim PhimHienTai;

        private async void ChiTietPhim_Load(object sender, EventArgs e)
        {
            var tcpClient = new ClientTCP();
            string response = await tcpClient.SendMessageAsync($"GET_REVIEWS|{IDPhim}");

            if (!response.StartsWith("ERROR"))
            {
                var chitiet = JsonSerializer.Deserialize<List<Review>>(response);
                HienThiChiTietPhim(chitiet);
            }
            else
            {
                MessageBox.Show("Không thể tải review: " + response);
            }
        }

        
 

        private void HienThiChiTietPhim(List<Review> reviews)
        {
            PanelChiTietPhim.Controls.Clear();
            foreach (var rv in reviews) 
            {
                var chitietItem = new ChiTietPhimControl();
              // chitietItem.ThongTinChiTiet();
                PanelChiTietPhim.Controls.Add(chitietItem);
            }
        }

        private void DanhGia_Click(object sender, EventArgs e)
        {
            DanhGia DanhGiaPhim = new DanhGia();
            DanhGiaPhim.Show();
        }

        private void PanelChiTietPhim_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChiTietPhim_Load_1(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {

        }
    }
}


