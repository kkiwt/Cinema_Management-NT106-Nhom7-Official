using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supabase;
using Postgrest.Models;
using Postgrest.Attributes;


namespace CinemaManagement
{
    public partial class ChonSuatChieu : Form
    {
        public ChonSuatChieu()
        {
            InitializeComponent();
        }

        public ChonSuatChieu(Phim phim, UserInfo user)
        {
            InitializeComponent();
            currentFilm = phim;
            curentUser = user;
            this.Text = $"Chọn phòng chiếu cho: {phim.TenPhim}";
            lblTenPhim.Text = phim.TenPhim;
        }
        private Supabase.Client supabase;
        private Phim currentFilm;
        private UserInfo curentUser;
        public class Phim : BaseModel
        {
            [PrimaryKey("IdPhim")]
            public string IdPhim { get; set; }

            [Column("TenPhim")]
            public string TenPhim { get; set; }

            [Column("tungay")]
            public DateTime TuNgay { get; set; }

            [Column("denngay")]
            public DateTime DenNgay { get; set; }
        }
        public class KhungGio : BaseModel
        {
            [PrimaryKey("idKG")]
            public string IdKG { get; set; }

            [Column("tgbatdau")]
            public TimeSpan TGBatDau { get; set; }

            [Column("tgketthuc")]
            public TimeSpan TGKetThuc { get; set; }
        }
        private async void ChonPhongChieu_Load(object sender, EventArgs e)
        {
            supabase = new Supabase.Client("https://qyhamranljmfsrxfxfls.supabase.co", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF5aGFtcmFubGptZnNyeGZ4ZmxzIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjE0NjgzMzQsImV4cCI6MjA3NzA0NDMzNH0.Qtd4vxXBsDlx7ZDWFV92WTmHqXUpJrbyOqW8D5yIBJs");
            await supabase.InitializeAsync();
            DateTime today = DateTime.Today;
            DateTime startDate = currentFilm.TuNgay > today ? currentFilm.TuNgay : today;
            DateTime endDate = currentFilm.DenNgay;

            for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
            {
                Button btnNgay = new Button();
                btnNgay.Text = d.ToString("dd/MM/yyyy");
                btnNgay.Width = 100;
                btnNgay.Height = 40;
                btnNgay.Tag = d;

                btnNgay.Click += (s, e2) =>
                {
                    DateTime selectedDate = (DateTime)((Button)s).Tag;
                    MessageBox.Show($"Chọn ngày: {selectedDate:dd/MM/yyyy}");
                };

                flowLayoutPanelNgay.Controls.Add(btnNgay);
            }
            var khungGioList = await supabase.From<KhungGio>().Get();

            foreach (var kg in khungGioList.Models)
            {
                Button btnKG = new Button();
                btnKG.Text = $"{kg.TGBatDau:hh\\:mm} - {kg.TGKetThuc:hh\\:mm}";
                btnKG.Width = 120;
                btnKG.Height = 40;
                btnKG.Tag = kg;

                btnKG.Click += (s, e3) =>
                {
                    var selectedKG = (KhungGio)((Button)s).Tag;
                    MessageBox.Show($"Chọn khung giờ: {selectedKG.IdKG}");
                };

                flowLayoutPanelKhungGio.Controls.Add(btnKG);
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
