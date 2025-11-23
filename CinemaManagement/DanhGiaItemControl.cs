
namespace CinemaManagement
{
    public partial class DanhGiaItemControl : UserControl
    {

        public DanhGiaItemControl(ReviewDisplay Review)
        {
            InitializeComponent();
            LoadReview(Review);
            this.Controls.Add(TenNguoiDung);
            this.Controls.Add(Sao);
            this.Controls.Add(NoiDungDanhGia);
        }

        public void LoadReview(ReviewDisplay Review)
        {
            TenNguoiDung.Text = Review.HoTen;
            NoiDungDanhGia.Text = Review.NoiDung;
            HienThiSao(Review.SoSao);
            string UserIdHienTai = "ID_NGUOI_DUNG_HIEN_TAI"; 

        }

        private void HienThiSao(int SoSao)
        {
            Sao.Controls.Clear();
            string Stars = "";
            for (int i = 0; i < 5; i++)
            {
                Stars += (i < SoSao) ? "★" : "☆"; 
            }

            Label StarLabel = new Label()
            {
                Text = Stars,
                Font = new Font(FontFamily.GenericSansSerif, 20),
                AutoSize = true
            };
            Sao.Controls.Add(StarLabel);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {

        }
    }
}