
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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

            flowLayoutPanel1.WrapContents = false;           
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;               // bật cuộn
            flowLayoutPanel1.Padding = new Padding(6);
            flowLayoutPanel1.AutoScrollMargin = new Size(0, 12);

        }

        private async void VeDaDat_Load(object sender, EventArgs e)
        {
  
            var prevCursor = Cursor;


            try
            {
         
                string request = $"GET_VE_DADAT|{currentUser.IDUser}";
                string response = await client.SendMessageAsync(request);

                if (string.IsNullOrWhiteSpace(response))
                {
                    MessageBox.Show("Phản hồi rỗng từ server.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (response.StartsWith("ERROR"))
                {
                    MessageBox.Show($"Không thể tải vé đã đặt: {response}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
               
                    var clean = response.Trim();
                    if (clean.StartsWith("\"") && clean.EndsWith("\""))
                    {

                        clean = clean.Trim('"').Replace("\\\"", "\"");
                    }

           
                    danhSach = JsonSerializer.Deserialize<List<VeDat>>(clean, opts) ?? new List<VeDat>();
                }

          
                RenderDanhSachVe(danhSach);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi tải vé đã đặt:\n{ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = prevCursor;
            }
        }

        private void RenderDanhSachVe(List<VeDat> danhSach)
        {
            flowLayoutPanel1.Controls.Clear();

            if (danhSach == null || danhSach.Count == 0)
            {
                MessageBox.Show("Bạn chưa có vé đã đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            foreach (var ve in danhSach)
            {
                var item = new VePhimControl1
                {
                    Margin = new Padding(8)

                };

                item.SetData(ve);
                flowLayoutPanel1.Controls.Add(item);
            }

        }


        private void UuDai_Click(object sender, EventArgs e)
        {

        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
