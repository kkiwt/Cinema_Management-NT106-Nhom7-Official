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

    // Model gói thông tin hiển thị sau thanh toán



    public partial class ThongTinBap : Form
    {
        public ThongTinBap()
        {
            InitializeComponent();
        }



        public ThongTinBap(string maThanhToan, string maBapNuoc, string noiDungChiTiet, DateTime ngayThanhToan) : this()
        {
            NoiDungBapNuocText.Text = noiDungChiTiet ?? "";
            MaBapNuocText.Text = maBapNuoc ?? "";
            NgayThanhToanText.Text = ngayThanhToan.ToString("yyyy-MM-dd HH:mm:ss");
            MaThanhToanText.Text = maThanhToan ?? "";
        }



        private void QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    public class PaymentResult
    {
        public string IdThanhToan { get; set; }
        public string IdBapNuoc { get; set; }        // chuỗi mã: 6B012B01P3BUIT1BUITP...
        public string MoTaChiTiet { get; set; }      // "6 combo 1, 2 combo 1 premium, ..."
        public DateTime ThoiGianVN { get; set; }     // UTC+7 khi tạo đơn
    }
}
