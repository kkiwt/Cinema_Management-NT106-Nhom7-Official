namespace CinemaManagement
{
    partial class TheVeXemPhim
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTenPhim = new Label();
            lbNgayChieu = new Label();
            lbGioChieu = new Label();
            lbGheNgoi = new Label();
            label1 = new Label();
            picturePoster = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePoster).BeginInit();
            SuspendLayout();
            // 
            // lbTenPhim
            // 
            lbTenPhim.AutoSize = true;
            lbTenPhim.BackColor = Color.Transparent;
            lbTenPhim.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenPhim.ForeColor = Color.White;
            lbTenPhim.Location = new Point(287, 199);
            lbTenPhim.Name = "lbTenPhim";
            lbTenPhim.Size = new Size(81, 23);
            lbTenPhim.TabIndex = 0;
            lbTenPhim.Text = "Tên phim";
            // 
            // lbNgayChieu
            // 
            lbNgayChieu.AutoSize = true;
            lbNgayChieu.BackColor = Color.Transparent;
            lbNgayChieu.Font = new Font("Arial Narrow", 12.8F);
            lbNgayChieu.ForeColor = Color.White;
            lbNgayChieu.Location = new Point(217, 248);
            lbNgayChieu.Name = "lbNgayChieu";
            lbNgayChieu.Size = new Size(92, 22);
            lbNgayChieu.TabIndex = 1;
            lbNgayChieu.Text = "Ngày chiếu: ";
            // 
            // lbGioChieu
            // 
            lbGioChieu.AutoSize = true;
            lbGioChieu.BackColor = Color.Transparent;
            lbGioChieu.Font = new Font("Arial Narrow", 12.8F);
            lbGioChieu.ForeColor = Color.White;
            lbGioChieu.Location = new Point(339, 279);
            lbGioChieu.Name = "lbGioChieu";
            lbGioChieu.Size = new Size(78, 22);
            lbGioChieu.TabIndex = 2;
            lbGioChieu.Text = "Giờ chiếu:";
            // 
            // lbGheNgoi
            // 
            lbGheNgoi.AutoSize = true;
            lbGheNgoi.BackColor = Color.Transparent;
            lbGheNgoi.Font = new Font("Arial Narrow", 12.8F);
            lbGheNgoi.ForeColor = Color.White;
            lbGheNgoi.Location = new Point(445, 213);
            lbGheNgoi.Name = "lbGheNgoi";
            lbGheNgoi.Size = new Size(76, 22);
            lbGheNgoi.TabIndex = 3;
            lbGheNgoi.Text = "Ghế ngồi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 12.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(445, 258);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 4;
            label1.Text = "Giá vé:";
            // 
            // picturePoster
            // 
            picturePoster.BackColor = SystemColors.ButtonHighlight;
            picturePoster.Location = new Point(104, 167);
            picturePoster.Name = "picturePoster";
            picturePoster.Size = new Size(121, 145);
            picturePoster.SizeMode = PictureBoxSizeMode.Zoom;
            picturePoster.TabIndex = 0;
            picturePoster.TabStop = false;
            // 
            // TheVeXemPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(962, 424);
            Controls.Add(label1);
            Controls.Add(lbGheNgoi);
            Controls.Add(picturePoster);
            Controls.Add(lbGioChieu);
            Controls.Add(lbTenPhim);
            Controls.Add(lbNgayChieu);
            Name = "TheVeXemPhim";
            Text = "TheVeXemPhim";
            ((System.ComponentModel.ISupportInitialize)picturePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label lbTenPhim;
        private Label lbNgayChieu;
        private Label lbGioChieu;
        private Label lbGheNgoi;
        private Label label1;
        private PictureBox picturePoster;
    }
}