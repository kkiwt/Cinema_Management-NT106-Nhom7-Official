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
        private void NutThemPhim_Click(object sender, EventArgs e)
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

            // 7. Kiểm tra CheckedListBox
            if (ChonTheLoai.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một thể loại!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ChonPhongChieu.CheckedItems.Count == 0 || ChonSuatChieu.CheckedItems.Count == 0)
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

            // Nếu tất cả hợp lệ
            MessageBox.Show("Dữ liệu hợp lệ! Tiến hành thêm phim...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: Thực hiện thêm phim vào database
        }

        private void NutThemAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Chọn ảnh poster phim";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Hiển thị ảnh vào HopePictureBox
                    AnhSeDuocThem.Image = Image.FromFile(openFileDialog.FileName);

                    // Lưu đường dẫn ảnh vào TextBox (nếu bạn muốn)
                    URLTrailerPhim.Text = openFileDialog.FileName;

                    MessageBox.Show("Ảnh đã được thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
