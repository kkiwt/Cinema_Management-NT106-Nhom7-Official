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
    public partial class PhanThemPhim : Form
    {
        public PhanThemPhim()
        {
            InitializeComponent();
        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel14_Click(object sender, EventArgs e)
        {

        }

        public event Action PhimDaThemThanhCong;
        private async void NutThemPhim_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra tên bộ phim
            if (string.IsNullOrWhiteSpace(TenBoPhim.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bộ phim!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra tên đạo diễn
            if (string.IsNullOrWhiteSpace(TenDaoDien.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đạo diễn!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Kiểm tra diễn viên
            if (string.IsNullOrWhiteSpace(DanDienVien.Text))
            {
                MessageBox.Show("Vui lòng nhập danh sách diễn viên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Kiểm tra mô tả phim
            if (string.IsNullOrWhiteSpace(MoTaPhim.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả phim!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Kiểm tra URL trailer
            if (string.IsNullOrWhiteSpace(URLTrailerPhim.Text))
            {
                MessageBox.Show("Vui lòng nhập URL trailer!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Kiểm tra ComboBox
            if (ChonDoTuoi.SelectedIndex < 0 || ChonQuocGia.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn độ tuổi và quốc gia!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ChonNgonNgu.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ngôn ngữ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (ChonPhongChieu.SelectedIndex < 0 || ChonSuatChieu.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng chiếu và suất chiếu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 8. Kiểm tra thời gian chiếu
            if (ChieuTu.Value > ChieuDen.Value)
            {
                MessageBox.Show("Ngày chiếu từ phải nhỏ hơn hoặc bằng ngày chiếu đến!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 9. Kiểm tra ảnh
            if (AnhSeDuocThem.Image == null)
            {
                MessageBox.Show("Vui lòng thêm ảnh poster!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(localPosterPath) || !File.Exists(localPosterPath))
            {
                MessageBox.Show("Đường dẫn ảnh không hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Lấy tên phòng từ combobox
            string tenPhong = ChonPhongChieu.Text; // ví dụ: "Phòng chiếu 1"



            string phongId = ChonPhongChieu.SelectedValue.ToString(); // Trả về C02 nếu chọn "Phòng chiếu 2"


            string danhSachGio = string.Join("|", ChonSuatChieu.CheckedItems.Cast<string>());
            string posterBase64 = ImageToBase64(localPosterPath);

            string message =
            $"ADD_PHIM|{TenBoPhim.Text}|{TheLoaiText.Text}|{ChonDoTuoi.Text}|{ThoiLuongText.Text}|{MoTaPhim.Text}|{URLTrailerPhim.Text}|{posterBase64}|{TenDaoDien.Text}|{DanDienVien.Text}|{ChonNgonNgu.Text}|{ChonQuocGia.Text}|{ChieuTu.Value:yyyy-MM-dd}|{ChieuDen.Value:yyyy-MM-dd}|{danhSachGio}|{phongId}";



            var client = new ClientTCP();
            string response = await client.SendMessageAsync(message);



            if (response.Contains("SUCCESS"))
            {
                MessageBox.Show("Thêm phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhimDaThemThanhCong?.Invoke();
                this.Close();
            }


            else
                MessageBox.Show("Lỗi: " + response, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private string ImageToBase64(string path)
        {
            byte[] bytes = File.ReadAllBytes(path); // chuyen anh thanh mang byte
            return Convert.ToBase64String(bytes);
        }



        private string localPosterPath = "";


        private void NutThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AnhSeDuocThem.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    localPosterPath = openFileDialog.FileName;
                }
            }
        }


        private bool isLoading = true;

        private void PhanThemPhim_Load(object sender, EventArgs e)
        {
            isLoading = true;
            var phongChieuList = new[]
            {
        new { Text = "Phòng chiếu 1", Value = "C01" },
        new { Text = "Phòng chiếu 2", Value = "C02" },
        new { Text = "Phòng chiếu 3", Value = "C03" },
        new { Text = "Phòng chiếu 4", Value = "C04" },
        new { Text = "Phòng chiếu 5", Value = "C05" },
        new { Text = "Phòng chiếu 6", Value = "C06" }
    };
            ChonPhongChieu.DisplayMember = "Text";
            ChonPhongChieu.ValueMember = "Value";
            ChonPhongChieu.DataSource = phongChieuList;
            isLoading = false;
        }


        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ChonSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void ChonPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading || ChonPhongChieu.SelectedIndex < 0) return;

            ChonSuatChieu.Items.Clear();
            string phongId = ChonPhongChieu.SelectedValue.ToString();
            string message = $"GET_AVAILABLE_SLOTS|{phongId}|{ChieuTu.Value:yyyy-MM-dd}|{ChieuDen.Value:yyyy-MM-dd}";

            var client = new ClientTCP();
            string response = await client.SendMessageAsync(message);

            if (response == "EMPTY")
            {
                MessageBox.Show("Không còn khung giờ trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (response.StartsWith("ERROR"))
            {
                MessageBox.Show(response, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var gio in response.Split(','))
            {
                ChonSuatChieu.Items.Add(gio);
            }
        }


    }
}
