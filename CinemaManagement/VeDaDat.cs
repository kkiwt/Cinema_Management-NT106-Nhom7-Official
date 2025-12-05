
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    /// <summary>
    /// Form hiển thị danh sách vé đã đặt của currentUser.
    /// Yêu cầu: ClientTCP, UserInfo, VePhimControl1 đã tồn tại trong project.
    /// </summary>
    public partial class VeDaDat : Form
    {
        private readonly UserInfo currentUser;
        private readonly ClientTCP client = new ClientTCP();

        public VeDaDat(UserInfo currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // Sự kiện load form
            this.Load += VeDaDat_Load;
            // Trong constructor sau InitializeComponent();
            flowLayoutPanel1.WrapContents = false;            // các item xếp dọc, không wrap sang phải
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.AutoScroll = true;               // bật cuộn
            flowLayoutPanel1.Padding = new Padding(6);
            flowLayoutPanel1.AutoScrollMargin = new Size(0, 12); // khoảng trống thêm khi scroll

        }

        private async void VeDaDat_Load(object sender, EventArgs e)
        {
            // UI: show loading
            var prevCursor = Cursor;


            try
            {
                // Gọi server với lệnh GET_VE_DADAT theo giao thức bạn đã dùng
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

                // Deserialize JSON (case-insensitive)
                var opts = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                List<VeDat> danhSach;

                try
                {
                    // Trường hợp chuẩn: server trả JSON array: [ { ... }, ... ]
                    danhSach = JsonSerializer.Deserialize<List<VeDat>>(response, opts) ?? new List<VeDat>();
                }
                catch
                {
                    // Trường hợp server trả JSON bị bọc trong chuỗi (double-quoted) hoặc escape
                    var clean = response.Trim();
                    if (clean.StartsWith("\"") && clean.EndsWith("\""))
                    {
                        // Bỏ dấu quote ngoài và unescape các chuỗi JSON bên trong
                        clean = clean.Trim('"').Replace("\\\"", "\"");
                    }

                    // Deserialize lại
                    danhSach = JsonSerializer.Deserialize<List<VeDat>>(clean, opts) ?? new List<VeDat>();
                }

                // Hiển thị
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
                    // KHÔNG set Width/Height ở đây
                };

                item.SetData(ve);
                flowLayoutPanel1.Controls.Add(item);
            }

        }


        private void UuDai_Click(object sender, EventArgs e)
        {
            // TODO: mở form ưu đãi nếu có
        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }



}
