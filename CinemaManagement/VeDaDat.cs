using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class VeDaDat : Form
    {
        private readonly UserInfo currentUser;
        private readonly ClientTCP client = new ClientTCP();
        public VeDaDat(UserInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.Load += VeDaDat_Load;
        }
        private async void VeDaDat_Load(object sender, EventArgs e)
        {
            string response = await client.SendMessageAsync($"GET_VE_DADAT|{currentUser.IDUser}");

            if (string.IsNullOrWhiteSpace(response) || response.StartsWith("ERROR"))
            {
                MessageBox.Show($"Không thể tải vé đã đặt: {response}", "Lỗi");
                return;
            }

            var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<VeDat> danhSach;

            try
            {
                danhSach = JsonSerializer.Deserialize<List<VeDat>>(response, opts) ?? new List<VeDat>();
            }
            catch
            {
                // Trường hợp server trả chuỗi bị quote/escape
                var clean = response.Trim();
                if (clean.StartsWith("\"") && clean.EndsWith("\""))
                    clean = clean.Trim('\"').Replace("\\\"", "\"");
                danhSach = JsonSerializer.Deserialize<List<VeDat>>(clean, opts) ?? new List<VeDat>();
            }

            // Hiển thị
            flowLayoutPanel1.Controls.Clear();
            if (danhSach.Count == 0)
            {
                MessageBox.Show("Bạn chưa có vé đã đặt.", "Thông báo");
                return;
            }

            foreach (var ve in danhSach)
            {
                var item = new VePhimControl1();
                item.SetData(ve);
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        private void UuDai_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height)); //Hien thi menu tai khoan de chon 3 tien ich.
        }
      
    }
}
