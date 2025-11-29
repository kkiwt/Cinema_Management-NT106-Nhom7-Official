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
    public partial class ChonPhongChieu : Form
    {
        public ChonPhongChieu()
        {
            InitializeComponent();
        }

        private Phim phimDuocChon;
        private UserInfo userHienTai;

        public ChonPhongChieu(Phim phim, UserInfo user)
        {
            InitializeComponent();
            phimDuocChon = phim;
            userHienTai = user;
            this.Text = $"Chọn phòng chiếu cho: {phim.TenPhim}";
            lblTenPhim.Text = phim.TenPhim; // ví dụ hiển thị tên phim
        }

        private void ChonPhongChieu_Load(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
