
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
            IdPhim.DataPropertyName = "IdPhim";
            TenPhim.DataPropertyName = "TenPhim";
            ChieuTu.DataPropertyName = "ChieuTu";
            DenNgay.DataPropertyName = "DenNgay";

           
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


        private async Task LoadMoviesAsync(int limit = 100)
        {
            try
            {

                string request = $"GET_MOVIES_LIST|{limit}";
                string response = await _client.SendMessageAsync(request);

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    NumberHandling = JsonNumberHandling.AllowReadingFromString
                };
                var movies = JsonSerializer.Deserialize<List<MovieDto>>(response, options) ?? new List<MovieDto>();


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

                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một phim trong danh sách.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var idPhimCell = dataGridView1.CurrentRow.Cells["IdPhim"].Value;
                if (idPhimCell == null)
                {
                    MessageBox.Show("Không tìm thấy IdPhim của dòng đang chọn.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string idPhim = idPhimCell.ToString().Trim();
                string tenPhim = dataGridView1.CurrentRow.Cells["TenPhim"].Value?.ToString();

                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn xoá phim '{tenPhim ?? idPhim}'?\nThao tác này không thể hoàn tác.",
                    "Xác nhận xoá",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

               
                string request = $"DELETE_MOVIE|{idPhim}";
     
                string response = await _client.SendMessageAsync(request);

              
                if (!string.IsNullOrWhiteSpace(response) &&
                    response.Trim().StartsWith("OK", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Đã xoá phim '{tenPhim ?? idPhim}'.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload lại danh sách ở form quản trị
                    await LoadMoviesAsync();


                    Form cur = this.Owner; 
                    while (cur != null && !(cur is TrangChuChinh))
                    {
                        cur = cur.Owner; // leo lên TrangChuChinh
                    }

                    if (cur is TrangChuChinh home)
                    {

                        home.RefreshDanhSachPhim();
                        home.Show();
                        home.BringToFront();
                    }
                    else
                    {
                       
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

