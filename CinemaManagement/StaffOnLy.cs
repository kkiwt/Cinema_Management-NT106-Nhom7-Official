using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace CinemaManagement
{
    public partial class StaffOnLy : Form
    {
        public StaffOnLy()
        {
            InitializeComponent();
            CreateChart();
        }

        private void CreateChart()
        {

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea("MainArea");
            chart.ChartAreas.Add(chartArea);

            Series series = new Series("DoanhThu");
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("Tháng 1", 100);
            series.Points.AddXY("Tháng 2", 150);
            series.Points.AddXY("Tháng 3", 200);

            chart.Series.Add(series);

            // Thêm Chart vào Panel
            panelChart.Controls.Add(chart);

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void nightPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void ThemPhim_Click(object sender, EventArgs e)
        {
            PhanThemPhim themphim = new PhanThemPhim();
            themphim.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NutThemUuDai_Click(object sender, EventArgs e)
        {
               PhanThemUuDai uudai = new PhanThemUuDai();
            uudai.ShowDialog();
        }
    }
}
