namespace CinemaManagement
{
    partial class VePhimControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbGiaVe = new Label();
            lbGheNgoi = new Label();
            picturePoster = new PictureBox();
            lbGioChieu = new Label();
            lbTenPhim = new Label();
            lbMaVe = new Label();
            panel1 = new Panel();
            lbNgayChieu = new Label();
            ((System.ComponentModel.ISupportInitialize)picturePoster).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbGiaVe
            // 
            lbGiaVe.AutoSize = true;
            lbGiaVe.BackColor = Color.Transparent;
            lbGiaVe.Font = new Font("Arial Narrow", 12.8F);
            lbGiaVe.ForeColor = Color.White;
            lbGiaVe.Location = new Point(302, 72);
            lbGiaVe.Name = "lbGiaVe";
            lbGiaVe.Size = new Size(55, 22);
            lbGiaVe.TabIndex = 10;
            lbGiaVe.Text = "Giá vé:";
            // 
            // lbGheNgoi
            // 
            lbGheNgoi.AutoSize = true;
            lbGheNgoi.BackColor = Color.Transparent;
            lbGheNgoi.Font = new Font("Arial Narrow", 12.8F);
            lbGheNgoi.ForeColor = Color.White;
            lbGheNgoi.Location = new Point(302, 50);
            lbGheNgoi.Name = "lbGheNgoi";
            lbGheNgoi.Size = new Size(76, 22);
            lbGheNgoi.TabIndex = 9;
            lbGheNgoi.Text = "Ghế ngồi:";
            // 
            // picturePoster
            // 
            picturePoster.BackColor = SystemColors.ButtonHighlight;
            picturePoster.Location = new Point(0, 3);
            picturePoster.Name = "picturePoster";
            picturePoster.Size = new Size(121, 145);
            picturePoster.SizeMode = PictureBoxSizeMode.Zoom;
            picturePoster.TabIndex = 5;
            picturePoster.TabStop = false;
            // 
            // lbGioChieu
            // 
            lbGioChieu.AutoSize = true;
            lbGioChieu.BackColor = Color.Transparent;
            lbGioChieu.Font = new Font("Arial Narrow", 12.8F);
            lbGioChieu.ForeColor = Color.White;
            lbGioChieu.Location = new Point(138, 72);
            lbGioChieu.Name = "lbGioChieu";
            lbGioChieu.Size = new Size(78, 22);
            lbGioChieu.TabIndex = 8;
            lbGioChieu.Text = "Giờ chiếu:";
            // 
            // lbTenPhim
            // 
            lbTenPhim.AutoSize = true;
            lbTenPhim.BackColor = Color.Transparent;
            lbTenPhim.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenPhim.ForeColor = Color.White;
            lbTenPhim.Location = new Point(138, 15);
            lbTenPhim.Name = "lbTenPhim";
            lbTenPhim.Size = new Size(81, 23);
            lbTenPhim.TabIndex = 6;
            lbTenPhim.Text = "Tên phim";
            // 
            // lbMaVe
            // 
            lbMaVe.AutoSize = true;
            lbMaVe.BackColor = Color.Transparent;
            lbMaVe.Font = new Font("Arial Narrow", 12.8F);
            lbMaVe.ForeColor = Color.White;
            lbMaVe.Location = new Point(138, 50);
            lbMaVe.Name = "lbMaVe";
            lbMaVe.Size = new Size(58, 22);
            lbMaVe.TabIndex = 7;
            lbMaVe.Text = "Mã vé: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbNgayChieu);
            panel1.Controls.Add(picturePoster);
            panel1.Controls.Add(lbGiaVe);
            panel1.Controls.Add(lbGioChieu);
            panel1.Controls.Add(lbTenPhim);
            panel1.Controls.Add(lbMaVe);
            panel1.Controls.Add(lbGheNgoi);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(509, 146);
            panel1.TabIndex = 11;
            // 
            // lbNgayChieu
            // 
            lbNgayChieu.AutoSize = true;
            lbNgayChieu.BackColor = Color.Transparent;
            lbNgayChieu.Font = new Font("Arial Narrow", 12.8F);
            lbNgayChieu.ForeColor = Color.White;
            lbNgayChieu.Location = new Point(138, 94);
            lbNgayChieu.Name = "lbNgayChieu";
            lbNgayChieu.Size = new Size(92, 22);
            lbNgayChieu.TabIndex = 11;
            lbNgayChieu.Text = "Ngày chiếu: ";
            // 
            // VePhimControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            Controls.Add(panel1);
            Name = "VePhimControl1";
            Size = new Size(512, 146);
            ((System.ComponentModel.ISupportInitialize)picturePoster).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbGiaVe;
        private Label lbGheNgoi;
        private PictureBox picturePoster;
        private Label lbGioChieu;
        private Label lbTenPhim;
        private Label lbMaVe;
        private Panel panel1;
        private Label lbNgayChieu;
    }
}
