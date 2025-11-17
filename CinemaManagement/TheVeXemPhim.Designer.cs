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
            tableLayoutPanel = new TableLayoutPanel();
            picturePoster = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            lbGheNgoi = new Label();
            lbGioChieu = new Label();
            lbNgayChieu = new Label();
            lbTenPhim = new Label();
            panel2 = new Panel();
            btnInVe = new Button();
            pictureBox1 = new PictureBox();
            btnXuatVe = new Button();
            btnHuyVe = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePoster).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 3;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.1401863F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.85981F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 209F));
            tableLayoutPanel.Controls.Add(picturePoster, 0, 0);
            tableLayoutPanel.Controls.Add(panel1, 1, 0);
            tableLayoutPanel.Controls.Add(panel2, 2, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(632, 174);
            tableLayoutPanel.TabIndex = 0;
            tableLayoutPanel.Paint += tableLayoutPanel_Paint;
            // 
            // picturePoster
            // 
            picturePoster.BackColor = SystemColors.ButtonHighlight;
            picturePoster.Dock = DockStyle.Fill;
            picturePoster.Location = new Point(3, 3);
            picturePoster.Name = "picturePoster";
            picturePoster.Size = new Size(121, 168);
            picturePoster.SizeMode = PictureBoxSizeMode.Zoom;
            picturePoster.TabIndex = 0;
            picturePoster.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbGheNgoi);
            panel1.Controls.Add(lbGioChieu);
            panel1.Controls.Add(lbNgayChieu);
            panel1.Controls.Add(lbTenPhim);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(130, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 168);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Arial Narrow", 12.8F);
            label1.Location = new Point(16, 107);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 4;
            label1.Text = "Giá vé:";
            // 
            // lbGheNgoi
            // 
            lbGheNgoi.AutoSize = true;
            lbGheNgoi.BackColor = SystemColors.ButtonShadow;
            lbGheNgoi.Font = new Font("Arial Narrow", 12.8F);
            lbGheNgoi.Location = new Point(16, 84);
            lbGheNgoi.Name = "lbGheNgoi";
            lbGheNgoi.Size = new Size(76, 22);
            lbGheNgoi.TabIndex = 3;
            lbGheNgoi.Text = "Ghế ngồi:";
            // 
            // lbGioChieu
            // 
            lbGioChieu.AutoSize = true;
            lbGioChieu.BackColor = SystemColors.ButtonShadow;
            lbGioChieu.Font = new Font("Arial Narrow", 12.8F);
            lbGioChieu.Location = new Point(16, 61);
            lbGioChieu.Name = "lbGioChieu";
            lbGioChieu.Size = new Size(78, 22);
            lbGioChieu.TabIndex = 2;
            lbGioChieu.Text = "Giờ chiếu:";
            // 
            // lbNgayChieu
            // 
            lbNgayChieu.AutoSize = true;
            lbNgayChieu.BackColor = SystemColors.ButtonShadow;
            lbNgayChieu.Font = new Font("Arial Narrow", 12.8F);
            lbNgayChieu.Location = new Point(16, 38);
            lbNgayChieu.Name = "lbNgayChieu";
            lbNgayChieu.Size = new Size(92, 22);
            lbNgayChieu.TabIndex = 1;
            lbNgayChieu.Text = "Ngày chiếu: ";
            // 
            // lbTenPhim
            // 
            lbTenPhim.AutoSize = true;
            lbTenPhim.BackColor = SystemColors.ButtonShadow;
            lbTenPhim.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTenPhim.Location = new Point(16, 6);
            lbTenPhim.Name = "lbTenPhim";
            lbTenPhim.Size = new Size(81, 23);
            lbTenPhim.TabIndex = 0;
            lbTenPhim.Text = "Tên phim";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHuyVe);
            panel2.Controls.Add(btnXuatVe);
            panel2.Controls.Add(btnInVe);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(425, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 168);
            panel2.TabIndex = 2;
            // 
            // btnInVe
            // 
            btnInVe.Location = new Point(9, 147);
            btnInVe.Name = "btnInVe";
            btnInVe.Size = new Size(63, 20);
            btnInVe.TabIndex = 1;
            btnInVe.Text = "In Vé";
            btnInVe.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(61, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnXuatVe
            // 
            btnXuatVe.Location = new Point(78, 147);
            btnXuatVe.Name = "btnXuatVe";
            btnXuatVe.Size = new Size(63, 20);
            btnXuatVe.TabIndex = 2;
            btnXuatVe.Text = "Xuất Vé";
            btnXuatVe.UseVisualStyleBackColor = true;
            // 
            // btnHuyVe
            // 
            btnHuyVe.Location = new Point(144, 147);
            btnHuyVe.Name = "btnHuyVe";
            btnHuyVe.Size = new Size(63, 20);
            btnHuyVe.TabIndex = 3;
            btnHuyVe.Text = "Hủy Vé";
            btnHuyVe.UseVisualStyleBackColor = true;
            // 
            // TheVeXemPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(632, 174);
            Controls.Add(tableLayoutPanel);
            Name = "TheVeXemPhim";
            Text = "TheVeXemPhim";
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePoster).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox picturePoster;
        private Panel panel1;
        private Label lbTenPhim;
        private Label lbGheNgoi;
        private Label lbGioChieu;
        private Label lbNgayChieu;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Button btnInVe;
        private PictureBox pictureBox1;
        private Button btnHuyVe;
        private Button btnXuatVe;
    }
}