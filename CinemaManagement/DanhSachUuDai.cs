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
    public partial class DanhSachUuDai : Form
    {
        public DanhSachUuDai()
        {
            InitializeComponent();

        }

        private async void DanhSachUuDai_Load(object sender, EventArgs e)
        {
            var client = new ClientTCP();
            string response = await client.SendMessageAsync("GET_GIAMGIA_STAT");

            if (string.IsNullOrWhiteSpace(response) || response.StartsWith("ERROR"))
            {
                MessageBox.Show($"Không thể tải ưu đãi: {response}", "Lỗi");
                return;
            }

            var opts = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<GiamGia> danhSach = null;

            try
            {
                danhSach = System.Text.Json.JsonSerializer.Deserialize<List<GiamGia>>(response, opts);
            }
            catch
            {
                var clean = response.Trim();
                if (clean.StartsWith("\"") && clean.EndsWith("\""))
                    clean = clean.Trim('\"').Replace("\\\"", "\"");
                danhSach = System.Text.Json.JsonSerializer.Deserialize<List<GiamGia>>(clean, opts);
            }

            danhSach ??= new List<GiamGia>();

            dataGridViewDanhSach.AutoGenerateColumns = false;
            dataGridViewDanhSach.Columns.Clear();

            dataGridViewDanhSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdGiamGia", HeaderText = "Mã ưu đãi" });
            dataGridViewDanhSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TuNgay", HeaderText = "Từ ngày", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dataGridViewDanhSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DenNgay", HeaderText = "Đến ngày", DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dataGridViewDanhSach.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TiLeGiam", HeaderText = "Tỷ lệ", DefaultCellStyle = new DataGridViewCellStyle { Format = "P0" } });

            dataGridViewDanhSach.DataSource = danhSach;
            dataGridViewDanhSach.ReadOnly = true;
            dataGridViewDanhSach.EnableHeadersVisualStyles = true;

            dataGridViewDanhSach.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridViewDanhSach.RowsDefaultCellStyle.ForeColor = Color.Black;

            dataGridViewDanhSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dataGridViewDanhSach.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            dataGridViewDanhSach.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewDanhSach.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewDanhSach.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewDanhSach.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewDanhSach.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewDanhSach.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridViewDanhSach.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridViewDanhSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridViewDanhSach.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dataGridViewDanhSach.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridViewDanhSach.GridColor = Color.Silver;
        }


        private void UuDai_Click(object sender, EventArgs e)
        {

        }

        private void TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongtintaikhoan = new ThongTInTaiKhoan();
            thongtintaikhoan.ShowDialog();
            this.Close();
        }

        private void VeDaDat_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewDanhSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var cell = dataGridViewDanhSach.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Selected)
            {
                cell.Style.BackColor = Color.LightSkyBlue;
                cell.Style.ForeColor = Color.Black;
                cell.Style.SelectionBackColor = Color.LightSkyBlue;
                cell.Style.SelectionForeColor = Color.Black;
            }
            else
            {
                
                cell.Style.ForeColor = Color.Black;
            }
        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
