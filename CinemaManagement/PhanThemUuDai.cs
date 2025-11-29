using System;
using System.Windows.Forms;
using System.Text.Json;

namespace CinemaManagement
{
    public partial class PhanThemUuDai : Form
    {
        public PhanThemUuDai()
        {
            InitializeComponent();
        }

        private void bigLabel5_Click(object sender, EventArgs e)
        {

        }
        bool daChonNgayBD = false;
        bool daChonNgayKT = false;

        private void ChonUuDaiTu_ValueChanged(object sender, EventArgs e)
        {
            daChonNgayBD = true;
        }

        private void ChonHetUuDai_ValueChanged(object sender, EventArgs e)
        {
            daChonNgayKT = true;
        }


        private async void NutThemUuDai_Click(object sender, EventArgs e)
        {
            string id = MaUuDaiText.Text.Trim();
            DateTime tuNgay = ChonUuDaiTu.Value.Date;
            DateTime denNgay = ChonHetUuDai.Value.Date;
            string tiLeStr = ChonPhanTramGiam.SelectedItem?.ToString();

            // --- Validation ---
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(tiLeStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }
            if (!decimal.TryParse(tiLeStr, out decimal tiLe) || tiLe <= 0 || tiLe > 100)
            {
                MessageBox.Show("Tỉ lệ giảm phải là số từ 1 đến 100.");
                return;
            }
            if (denNgay < tuNgay)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                return;
            }

            try
            {

                // Chia tiLe cho 100 trước khi gửi
                tiLe = tiLe / 100;

                ClientTCP client = new ClientTCP();

                string message = $"ADD_GIAMGIA|{id}|{tuNgay:yyyy-MM-dd}|{denNgay:yyyy-MM-dd}|{tiLe}";

                string response = await client.SendMessageAsync(message);

                this.Invoke((MethodInvoker)delegate
                {
                    string[] parts = null;
                    try
                    {
                        parts = JsonSerializer.Deserialize<string[]>(response);
                    }
                    catch
                    {
                        string clean = response.Replace("\\\\", "")
                                               .Replace("[", "")
                                               .Replace("]", "")
                                               .Replace("\\\"", "")
                                               .Trim();
                        parts = clean.Split(',', StringSplitOptions.RemoveEmptyEntries);
                    }

                    if (parts == null || parts.Length == 0)
                    {
                        MessageBox.Show($"Phản hồi rỗng hoặc không hợp lệ: {response}", "Lỗi");
                        return;
                    }

                    string command = parts[0].Trim();
                    switch (command)
                    {
                        case "SUCCESS":
                            MessageBox.Show("Thêm ưu đãi thành công!", "Thành công");
                            this.Close(); // hoặc chuyển về dashboard
                            break;
                        case "FAILED":
                            MessageBox.Show("Thêm ưu đãi thất bại.", "Lỗi");
                            break;
                        default:
                            MessageBox.Show($"Phản hồi không xác định: {string.Join(", ", parts)}", "DEBUG");
                            break;
                    }
                });
            }
            catch (Exception ex)
            {
                this.Invoke((Action)(() =>
                {
                    MessageBox.Show($"Lỗi gửi dữ liệu đến server: {ex.Message}", "Lỗi");
                }));
            }
        }


    }
}
