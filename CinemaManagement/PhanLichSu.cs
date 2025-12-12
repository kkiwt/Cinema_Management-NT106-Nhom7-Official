using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class PhanLichSu : Form
    {
        private DataTable _allData;  
        private DataView _view;      

        public PhanLichSu()
        {
            InitializeComponent();

            // ❗ Quan trọng: tắt auto-gen NGAY từ đầu để tránh lặp cột
            BangLichSu.AutoGenerateColumns = false;

            // ❗ Map DataPropertyName cho cột Designer
            // (Tên phải khớp với caption trong DataTable bạn tạo)
            MaKH.DataPropertyName = "Mã Khách Hàng";
            TenKH.DataPropertyName = "Tên Khách Hàng";
            TenPhim.DataPropertyName = "Tên Phim Đã Đặt";
            Ghe.DataPropertyName = "Ghế";
            PhongChieu.DataPropertyName = "Phòng Chiếu";
            TenBapNuoc.DataPropertyName = "Bắp Nước";
            NgayDat.DataPropertyName = "Ngày Đặt";
            GioBatDau.DataPropertyName = "Giờ Bắt Đầu";

            // Gắn sự kiện tìm kiếm
            TimTenKH.TextChanged += TimTenKH_TextChanged;
        }

        private void NutQuayLai_Click(object sender, EventArgs e) => this.Close();

        private void parrotGradientPanel1_Paint(object sender, PaintEventArgs e) { }

        private async void PhanLichSu_Load(object sender, EventArgs e)
        {
            // Cấu hình giao diện lưới trước
            SetupGridLook();

            // Rồi mới load dữ liệu và bind
            await LoadHistoryAsync();
        }

        private void SetupGridLook()
        {
            // Đã tắt auto-gen ở ctor, giữ nguyên
            BangLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Fit & tỉ lệ
            TenKH.FillWeight = 160;
            TenPhim.FillWeight = 180;
            Ghe.FillWeight = 70;
            PhongChieu.FillWeight = 100;

            BangLichSu.ScrollBars = ScrollBars.Vertical;
            BangLichSu.ReadOnly = true;
            BangLichSu.AllowUserToAddRows = false;
            BangLichSu.AllowUserToDeleteRows = false;
            BangLichSu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BangLichSu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Lưu ý: cột "Ngày Đặt" đang là string → Format sẽ không áp dụng.
            // Nếu cần hiển thị format ngày chuẩn, hãy đổi kiểu cột trong DataTable thành DateTime.
        }

        private async Task LoadHistoryAsync()
        {
            try
            {
                ClientTCP client = new ClientTCP();
                string response = await client.SendMessageAsync("GET_HISTORY");
                BindLichSuVeFromJson(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được lịch sử vé: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindLichSuVeFromJson(string json)
        {
            // Tạo DataTable với đúng caption sẽ map vào DataPropertyName ở trên
            var dt = new DataTable();
            dt.Columns.Add("Mã Khách Hàng", typeof(string));
            dt.Columns.Add("Tên Khách Hàng", typeof(string));
            dt.Columns.Add("Tên Phim Đã Đặt", typeof(string));
            dt.Columns.Add("Ghế", typeof(string));
            dt.Columns.Add("Phòng Chiếu", typeof(string));
            dt.Columns.Add("Bắp Nước", typeof(string));
            dt.Columns.Add("Ngày Đặt", typeof(string)); // hiển thị chuỗi dd/MM/yyyy cho filter
            dt.Columns.Add("Giờ Bắt Đầu", typeof(string));

            if (!string.IsNullOrWhiteSpace(json) && json != "[]")
            {
                using var doc = JsonDocument.Parse(json);
                if (doc.RootElement.ValueKind == JsonValueKind.Array)
                {
                    foreach (var item in doc.RootElement.EnumerateArray())
                    {
                        string maKH = item.TryGetProperty("idtaikhoan", out var x1) ? x1.GetString() : "";
                        string tenKH = item.TryGetProperty("hoten", out var x2) ? x2.GetString() : "";
                        string tenPhim = item.TryGetProperty("tenphim", out var x3) ? x3.GetString() : "";
                        string ghe = item.TryGetProperty("tenghe", out var x4) ? x4.GetString() : "";
                        string phongChieu = item.TryGetProperty("tenphongchieu", out var x5) ? x5.GetString() : "";
                        string bapNuoc = item.TryGetProperty("tenbapnuoc", out var x6) ? x6.GetString() : "";
                        string ngayDatStr = item.TryGetProperty("ngaydat", out var x7) ? x7.GetString() : null;
                        string gioBD = item.TryGetProperty("tgbatdau", out var x8) ? x8.GetString() : "";

                        // format ngày → string dd/MM/yyyy
                        string ngayHienThi = "";
                        if (DateTime.TryParse(ngayDatStr, out var d))
                            ngayHienThi = d.ToString("dd/MM/yyyy");

                        dt.Rows.Add(maKH, tenKH, tenPhim, ghe, phongChieu, bapNuoc, ngayHienThi, gioBD);
                    }
                }
            }

            // Lưu bản gốc & tạo view rồi bind
            _allData = dt;
            _view = new DataView(_allData)
            {
                Sort = "[Ngày Đặt] DESC, [Giờ Bắt Đầu] DESC"
            };
            BangLichSu.DataSource = _view;
        }

        private static string RemoveDiacritics(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();
            foreach (var c in normalizedString)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        private void TimTenKH_TextChanged(object sender, EventArgs e)
        {
            if (_allData == null) return;

            string keyword = TimTenKH.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                // Trả về view gốc (đã sort sẵn)
                BangLichSu.DataSource = _view;
                return;
            }

            string kwNoAccent = RemoveDiacritics(keyword);

            // Tạo bảng kết quả có cùng schema, KHÔNG thêm cột mới
            var filtered = _allData.Clone();

            foreach (DataRow r in _allData.Rows)
            {
                string tenKH = r["Tên Khách Hàng"]?.ToString() ?? string.Empty;

                bool matchWithAccent = tenKH.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0;
                bool matchWithoutAccent = RemoveDiacritics(tenKH)
                                          .IndexOf(kwNoAccent, StringComparison.CurrentCultureIgnoreCase) >= 0;

                if (matchWithAccent || matchWithoutAccent)
                    filtered.ImportRow(r);
            }

            // Sắp xếp theo ngày/giờ như view gốc
            var viewFiltered = new DataView(filtered)
            {
                Sort = "[Ngày Đặt] DESC, [Giờ Bắt Đầu] DESC"
            };
            BangLichSu.DataSource = viewFiltered;
        }

        private void NutReload_Click(object sender, EventArgs e)
        {
            PhanLichSu_Load(sender, e);
        }
    }
}
