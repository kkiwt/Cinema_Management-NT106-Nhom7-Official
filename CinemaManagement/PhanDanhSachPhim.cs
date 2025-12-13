
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class PhanDanhSachPhim : Form
    {
        // DTO ánh xạ đúng các field JSON từ RPC get_movies_list
        public class MovieDto
        {
            public string IdPhim { get; set; }
            public string TenPhim { get; set; }
            public DateTime? ChieuTu { get; set; }
            public DateTime? DenNgay { get; set; }
        }

        private readonly ClientTCP _client = new ClientTCP();

        public PhanDanhSachPhim()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;

            // Map cột Designer sang property để dùng DataSource
            IdPhim.DataPropertyName = "IdPhim";
            TenPhim.DataPropertyName = "TenPhim";
            ChieuTu.DataPropertyName = "ChieuTu";
            DenNgay.DataPropertyName = "DenNgay";

            // (Tuỳ chọn) định dạng hiển thị ngày
            dataGridView1.Columns["ChieuTu"].DefaultCellStyle.Format = "yyyy-MM-dd";
            dataGridView1.Columns["DenNgay"].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void PhanDanhSachPhim_Load(object sender, EventArgs e)
        {
            await LoadMoviesAsync(); // mặc định limit 100
        }

        // Hàm tải danh sách phim từ server và bind lên DataGridView
        private async Task LoadMoviesAsync(int limit = 100)
        {
            try
            {
                // Gửi lệnh theo protocol: command dòng 1, tham số dòng 2
                string request = $"GET_MOVIES_LIST|{limit}";
                string response = await _client.SendMessageAsync(request);

                // Parse JSON → List<MovieDto>
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    NumberHandling = JsonNumberHandling.AllowReadingFromString
                };
                var movies = JsonSerializer.Deserialize<List<MovieDto>>(response, options) ?? new List<MovieDto>();

                // Bind trực tiếp DataSource cho gọn
                dataGridView1.DataSource = movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không thể tải danh sách phim.\n{ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void NutReload_Click(object sender, EventArgs e)
        {
            await LoadMoviesAsync();
        }

        private void bigLabel3_Click(object sender, EventArgs e)
        {
        }



        private async void NutXoaPhim_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Kiểm tra có dòng nào được chọn
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một phim trong danh sách.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2) Lấy IdPhim & TenPhim từ dòng đang chọn
                var idPhimCell = dataGridView1.CurrentRow.Cells["IdPhim"].Value;
                if (idPhimCell == null)
                {
                    MessageBox.Show("Không tìm thấy IdPhim của dòng đang chọn.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string idPhim = idPhimCell.ToString().Trim();
                string tenPhim = dataGridView1.CurrentRow.Cells["TenPhim"].Value?.ToString();

                // 3) Xác nhận xoá
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xoá phim '{tenPhim ?? idPhim}'?\nThao tác này không thể hoàn tác.",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                // 4) Gửi lệnh xoá (đúng protocol của bạn)
                // Nếu server dùng phân cách bằng '|' như bạn đang ghi, giữ nguyên:
                string request = $"DELETE_MOVIE|{idPhim}";
                // Nếu server dùng xuống dòng: $"DELETE_MOVIE\n{idPhim}"
                string response = await _client.SendMessageAsync(request);

                // 5) Xử lý phản hồi
                if (!string.IsNullOrWhiteSpace(response) &&
                    response.Trim().StartsWith("OK", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Đã xoá phim '{tenPhim ?? idPhim}'.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 6) Reload lại danh sách ở form quản trị
                    await LoadMoviesAsync();

                    // 7) Báo cho TrangChuChinh reload bằng owner-chain
                    // Owner-chain: PhanDanhSachPhim -> StaffOnLy -> TrangChuChinh
                    Form cur = this.Owner; // StaffOnLy (nếu đã gán Owner khi mở)
                    while (cur != null && !(cur is TrangChuChinh))
                    {
                        cur = cur.Owner; // leo lên TrangChuChinh
                    }

                    if (cur is TrangChuChinh home)
                    {
                        // Gọi refresh ở TrangChuChinh
                        home.RefreshDanhSachPhim();
                        // (tuỳ chọn) đưa TrangChuChinh lên trước
                        home.Show();
                        home.BringToFront();
                    }
                    else
                    {
                        // Fallback: nếu Owner chưa được gán, thử OpenForms
                        var home2 = Application.OpenForms.OfType<TrangChuChinh>().FirstOrDefault();
                        if (home2 != null)
                        {
                            home2.RefreshDanhSachPhim();
                            home2.BringToFront();
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Xoá không thành công.\nPhản hồi server: {response}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi xoá phim.\n{ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

