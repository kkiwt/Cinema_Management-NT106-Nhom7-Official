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
    public partial class GDThanhToan : Form
    {
        private readonly Phim _phim;
        private readonly UserInfo _user;
        private readonly DateTime _date;
        private readonly LichChieuCoDinh _slot;

        private List<KhungGio> khungGioList = new List<KhungGio>();
        private List<PhongChieu> phongChieuList = new List<PhongChieu>();
        private List<LichChieuCoDinh> lichChieuList = new List<LichChieuCoDinh>();
        private readonly List<string> _selectedSeats = new List<string>();
        private ClientTCP _client = new ClientTCP();

        public GDThanhToan(Phim phim, UserInfo user, DateTime date, LichChieuCoDinh slot, List<KhungGio> kg, List<PhongChieu> pc, List<LichChieuCoDinh> lc)
        {
            
            InitializeComponent();
            _user = user;
            _phim = phim;
            _date = date;
            _slot = slot;
            khungGioList = kg;
            phongChieuList = pc;
            lichChieuList = lc;
        }

        private async void btnLoadQR_Click(object sender, EventArgs e)
        {
            var account = "0979151133";
            var bank = "MBBank";
            var amount = 100000;
            var description = "ID";
            var template = "compact";
            var download = "false";

            var url = $"https://qr.sepay.vn/img?acc={account}&bank={bank}&amount={amount}&des={description}&template={template}&download={download}";

            using var http = new HttpClient();
            var bytes = await http.GetByteArrayAsync(url);

            using var ms = new MemoryStream(bytes);
            pictureBox1.Image = System.Drawing.Image.FromStream(ms);
        }

        private void GDThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
