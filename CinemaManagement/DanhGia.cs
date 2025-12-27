using System.Text.Json;

namespace CinemaManagement
{
    public partial class DanhGia : Form
    {
        private Phim PhimHienTai;
        private ClientTCP clientTcp;
        private ReviewSummary TongDanhGiaHienTai;
        private int ChonSaoDanhGia = 0;
        private ChiTietPhim GoiChiTietPhim;
        private UserInfo currentUser;

       
        public DanhGia(Phim phim, ChiTietPhim GoiForm, UserInfo user)
        {
            InitializeComponent();
            PhimHienTai = phim;
            this.currentUser = user;
            clientTcp = new ClientTCP();
            GoiChiTietPhim = GoiForm;
            this.Text = $"Đánh giá phim: {phim.TenPhim}";
            SetupComboBox();
            SetupStarSelection();

            this.Load += DanhGia_Load;
            LinkTenPhim.LinkClicked += LinkTenPhim_LinkClicked;
            LinkTenPhim.Text = PhimHienTai.TenPhim + " >> Đánh giá";

        }

        private async void DanhGia_Load(object sender, EventArgs e)
        {
            LinkTenPhim.Text = PhimHienTai.TenPhim + " >> Đánh giá";
            if (PhimHienTai != null && !string.IsNullOrEmpty(PhimHienTai.IdPhim))
            {
                await LoadReviewDataAsync(PhimHienTai.IdPhim);
            }
        }

        private void SetupComboBox()
        {
            Loc.Items.Add("Tất cả");
            for (int i = 5; i >= 1; i--)
            {
                Loc.Items.Add($"{i} sao");
            }
            Loc.SelectedIndex = 0; // mac dinh la Tat ca
            Loc.SelectedIndexChanged += Loc_SelectedIndexChanged;
        }


        private void SetupStarSelection()
        {
            pnlMyStars.Controls.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Label star = new Label
                {
                    Name = $"lblStar_{i}",
                    Tag = i,
                    Text = "☆",
                    Size = new Size(80, 80),
                    Location = new Point((i - 1) * 80, 0),
                    Font = new Font("Arial", 40),
                    ForeColor = Color.Gray,
                    Cursor = Cursors.Hand,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                star.Click += Star_Click;
                pnlMyStars.Controls.Add(star);
            }
            ChonSaoDanhGia = 0; // dam bao reset so sao da chon
        }

        private void Star_Click(object sender, EventArgs e)
        {
            Label SaoDuocClick = (Label)sender;
            int GiaTriSao = (int)SaoDuocClick.Tag;
            ChonSaoDanhGia = GiaTriSao;

            foreach (Control control in pnlMyStars.Controls)
            {
                if (control is Label lbl)
                {
                    int TagGiaTri = (int)lbl.Tag;
                    lbl.Font = new Font("Arial", 40);
                    lbl.Text = (TagGiaTri <= GiaTriSao) ? "★" : "☆";
                    lbl.ForeColor = (TagGiaTri <= GiaTriSao) ? Color.Gold : Color.Gray;
                }
            }
        }

        private async Task LoadReviewDataAsync(string idPhim)
        {
            string message = $"GET_REVIEW_SUMMARY|{idPhim}";
            string response = await clientTcp.SendMessageAsync(message);

            if (response.StartsWith("ERROR"))
            {
                MessageBox.Show($"Lỗi tải đánh giá: {response}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TongDanhGiaHienTai = new ReviewSummary { LatestReviews = new List<ReviewDisplay>() };
                HienThiKetQuaTong(TongDanhGiaHienTai); // van cap nhat du UI loi
                return;
            }

            try
            {
                TongDanhGiaHienTai = JsonSerializer.Deserialize<ReviewSummary>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                HienThiKetQuaTong(TongDanhGiaHienTai);
                // hien thi list danhgia ban dau
                // lay gia tri loc hien tai
                int LocTheoSao = (Loc.SelectedIndex > 0) ?
                    int.Parse(Loc.SelectedItem.ToString().Split(' ')[0]) : 0;
                DisplayReviewList(TongDanhGiaHienTai.LatestReviews, LocTheoSao);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý dữ liệu đánh giá: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiKetQuaTong(ReviewSummary Tong)
        {
            DiemDanhGia.Text = $"{Tong.AvgRating:0.0}";
            TongLuotDanhGia.Text = $"{Tong.TotalReviews} lượt đánh giá";

            // Sao trung binh
            int RoundedStars = (int)Math.Round(Tong.AvgRating);
            string Stars = "";
            for (int i = 0; i < 5; i++)
            {
                Stars += (i < RoundedStars) ? "★" : "☆";
            }
            TongSao.Text = Stars;
            TongSao.Font = new Font("Arial", 28, FontStyle.Regular);
        }

        private void DisplayReviewList(List<ReviewDisplay> Reviews, int LocSao)
        {
            // tao danh sach control can xoa
            List<Control> controlsToRemove = flowLayoutPanel.Controls.Cast<Control>().ToList();
            // xoa tung control ra khoi panel
            foreach (var control in controlsToRemove)
            {
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose(); //giai phong tai nguyen
            }

            //loc danh sach
            var LocDanhGia = (LocSao > 0)
                ? Reviews.Where(r => r.SoSao == LocSao).ToList()
                : Reviews;

            foreach (var Review in LocDanhGia)
            {
                var ReviewItem = new DanhGiaItemControl(Review, currentUser);
                ReviewItem.Width = flowLayoutPanel.Width - 5;
                ReviewItem.Margin = new Padding(0, 0, 0, 10);
                flowLayoutPanel.Controls.Add(ReviewItem);
            }
        }

        private void Loc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TongDanhGiaHienTai == null) return;

            string ItemDuocChon = Loc.SelectedItem.ToString();
            int LocSao = 0;

            if (ItemDuocChon != "Tất cả")
            {
                int.TryParse(ItemDuocChon.Split(' ')[0], out LocSao);
            }

            DisplayReviewList(TongDanhGiaHienTai.LatestReviews, LocSao);
        }

        private async void Gui_Click(object sender, EventArgs e)
        {
            if (ChonSaoDanhGia == 0)
            {
                MessageBox.Show("Vui lòng chọn số sao trước khi gửi.", "Lỗi");
                return;
            }

            string NoiDung = NoiDungDanhGia.Text.Trim();
            string message = $"POST_REVIEW|{currentUser.IDUser}|{PhimHienTai.IdPhim}|{NoiDung}|{ChonSaoDanhGia}";

            string response = await clientTcp.SendMessageAsync(message);

            if (response == "SUCCESS")
            {
                MessageBox.Show("Gửi đánh giá thành công!", "Thông báo");
                //  Reset Form nhap lieu (chay tren UI Thread, Kko can await)
                this.Invoke((MethodInvoker)delegate
                {
                    NoiDungDanhGia.Text = "";
                    ChonSaoDanhGia = 0;
                    SetupStarSelection(); 
                });
                // tai lai data
                await LoadReviewDataAsync(PhimHienTai.IdPhim);

                // tu dong cuon
                this.Invoke((MethodInvoker)delegate
                {
                    if (flowLayoutPanel.Controls.Count > 0)
                        flowLayoutPanel.ScrollControlIntoView(flowLayoutPanel.Controls[0]);
                });
            }
            else
            {
                MessageBox.Show($"Lỗi gửi đánh giá: {response}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height));
        }

        private void LinkTenPhim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            if (GoiChiTietPhim != null)
            {
                GoiChiTietPhim.Show();
            }
            this.Close();
        }

        private void PhimHot_Click(object sender, EventArgs e)
        {
            TrangChuChinh formTrangChuChinh = GoiChiTietPhim.GetTrangChuChinh(); // Lay form TrangChuChinh thong qua form ChiTietPhim

            if (formTrangChuChinh != null)
            {
                PhimHot phimhot = new PhimHot(formTrangChuChinh, currentUser);
                this.Close(); 
                GoiChiTietPhim.Hide(); 
                phimhot.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy Trang Chủ Chính để điều hướng.", "Lỗi");
            }
        }


        private void DangXuat_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void UuDai_Click(object sender, EventArgs e)
        {
            var uuDai = new DanhSachUuDai();
            this.Hide();
            uuDai.Show();
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            NoiDungDanhGia.Clear();
        }

        private void ThongTinTaiKhoan_Click_1(object sender, EventArgs e)
        {
            ThongTInTaiKhoan TK = new ThongTInTaiKhoan(currentUser);
            TK.ShowDialog();

        }

        private void VeDaDat_Click(object sender, EventArgs e)
        {
            VeDaDat veDaDat = new VeDaDat(currentUser);
            veDaDat.ShowDialog();
        }

        private void LinkTenPhim_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NutReload_Click(object sender, EventArgs e)
        {
            DanhGia_Load(sender, e);
        }
        
        private void DangXuat_Click(object sender, EventArgs e)
        {
            var dangNhap = new PhanDangNhap();
            this.Hide();
            dangNhap.Show();

        }
        private void ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongTinTaiKhoan = new ThongTInTaiKhoan(currentUser);
            this.Hide();
            thongTinTaiKhoan.ShowDialog();

        }
    }
}