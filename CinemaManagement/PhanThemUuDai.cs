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

        private void NutThemUuDai_Click(object sender, EventArgs e)
        {
            // 1. Validate Tên Ưu Đãi
            if (string.IsNullOrWhiteSpace(TenUuDai.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Ưu Đãi!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TenUuDai.Focus();
                return;
            }
            if (!daChonNgayBD || !daChonNgayKT)
            {
                MessageBox.Show("Chưa nhập ngày bắt đầu ưu đãi hoặc ngày hết ưu đãi",
                                "Lỗi ngày tháng",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }



            // 2. Validate Ngày
            if (ChonHetUuDai.Value < ChonUuDaiTu.Value)
            {
                MessageBox.Show("Ngày kết thúc ưu đãi phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validate ComboBox: Đối tượng được giảm
            if (ChonDoiTuongDuocGiam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Đối Tượng Được Giảm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Validate phần trăm giảm
            if (ChonPhanTramGiam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn % giảm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Validate phim được giảm
            if (ChonPhimDuocGiam.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 phim được giảm!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
    }
}
