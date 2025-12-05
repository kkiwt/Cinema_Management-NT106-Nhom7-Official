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
            lbNgayChieu = new Label();
            panel1 = new Panel();
            lbIDVe = new Label();
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
            lbGiaVe.Location = new Point(449, 81);
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
            lbGheNgoi.Location = new Point(449, 49);
            lbGheNgoi.Name = "lbGheNgoi";
            lbGheNgoi.Size = new Size(76, 22);
            lbGheNgoi.TabIndex = 9;
            lbGheNgoi.Text = "Ghế ngồi:";
            // 
            // picturePoster
            // 
            picturePoster.BackColor = SystemColors.ButtonHighlight;
            picturePoster.Location = new Point(-2, -3);
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
            lbGioChieu.Location = new Point(141, 81);
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
            // lbNgayChieu
            // 
            lbNgayChieu.AutoSize = true;
            lbNgayChieu.BackColor = Color.Transparent;
            lbNgayChieu.Font = new Font("Arial Narrow", 12.8F);
            lbNgayChieu.ForeColor = Color.White;
            lbNgayChieu.Location = new Point(138, 49);
            lbNgayChieu.Name = "lbNgayChieu";
            lbNgayChieu.Size = new Size(92, 22);
            lbNgayChieu.TabIndex = 7;
            lbNgayChieu.Text = "Ngày chiếu: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbIDVe);
            panel1.Controls.Add(picturePoster);
            panel1.Controls.Add(lbGiaVe);
            panel1.Controls.Add(lbGioChieu);
            panel1.Controls.Add(lbTenPhim);
            panel1.Controls.Add(lbNgayChieu);
            panel1.Controls.Add(lbGheNgoi);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 146);
            panel1.TabIndex = 11;
            // 
            // lbIDVe
            // 
            lbIDVe.AutoSize = true;
            lbIDVe.BackColor = Color.Transparent;
            lbIDVe.Font = new Font("Arial Narrow", 12.8F);
            lbIDVe.ForeColor = Color.White;
            lbIDVe.Location = new Point(141, 113);
            lbIDVe.Name = "lbIDVe";
            lbIDVe.Size = new Size(49, 22);
            lbIDVe.TabIndex = 11;
            lbIDVe.Text = "ID Vé:";
            // 
            // VePhimControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            Controls.Add(panel1);
            Name = "VePhimControl1";
            Size = new Size(745, 146);
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
        private Label lbNgayChieu;
        private Panel panel1;
        private Label lbIDVe;
    }
}
