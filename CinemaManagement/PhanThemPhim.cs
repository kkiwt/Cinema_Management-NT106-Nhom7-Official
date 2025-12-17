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




            string posterBase64 = ImageToBase64(localPosterPath);

            string message =
            $"ADD_PHIM|{TenBoPhim.Text}|{TheLoaiText.Text}|{ChonDoTuoi.Text}|{ThoiLuongText.Text}|{MoTaPhim.Text}|{URLTrailerPhim.Text}|{posterBase64}|{TenDaoDien.Text}|{DanDienVien.Text}|{ChonNgonNgu.Text}|{ChonQuocGia.Text}|{ChieuTu.Value:yyyy-MM-dd}|{ChieuDen.Value:yyyy-MM-dd}"; // Bo di danh sach gio va phongId



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
            return Convert.ToBase64String(bytes); // chuyen sang base64
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




        private void PhanThemPhim_Load(object sender, EventArgs e)
        {


        }


        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ChonSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void ChonPhongChieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
