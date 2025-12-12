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
    public partial class ThongTinVe : Form
    {
        public ThongTinVe()
        {
            InitializeComponent();
        }
        private TicketInfo _ticket;
        public class TicketInfo
        {
            public string IdThanhToan { get; set; }
            public string TenPhim { get; set; }
            public DateTime ThoiGian { get; set; }
            public string PhongChieu { get; set; }
            public List<string> DanhSachSeatIds { get; set; } = new List<string>();
        }

        public ThongTinVe(TicketInfo ticket) : this()
        {
            _ticket = ticket;
            BindData();
        }

        private void BindData()
        {
            if (_ticket == null) return;

            TenPhimText.Text = _ticket.TenPhim;                                         // đã có trong Designer
            ThoiGianNgayThangNamGioPhutGiay.Text = _ticket.ThoiGian.ToString("dd/MM/yyyy HH:mm"); // đã có trong Designer
            DanhSachSoGheText.Text = string.Join(", ", _ticket.DanhSachSeatIds);        // đã có trong Designer
            TenPhongChieuText.Text = _ticket.PhongChieu;                                 // đã có trong Designer
            MaThanhToanText.Text = _ticket.IdThanhToan;                                  // đã có trong Designer
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void TenPhongChieuText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
