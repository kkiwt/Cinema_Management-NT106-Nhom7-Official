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
        UserInfo currentUser = new UserInfo();
        Phim currentPhim = new Phim();

        public GDThanhToan(UserInfo user, Phim phim)
        {
            currentUser = user;
            currentPhim = phim;
            InitializeComponent();
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
