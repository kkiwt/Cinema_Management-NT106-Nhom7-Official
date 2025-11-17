namespace CinemaManagement
{
    partial class ThongTInTaiKhoan
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
            components = new System.ComponentModel.Container();
            PanelHeader = new Panel();
            Logo = new PictureBox();
            TimKiem = new TextBox();
            TaiKhoan = new Button();
            PhimHot = new Button();
            UuDai = new Button();
            MenuTaiKhoan = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            PanelDuongDan = new Panel();
            label2 = new Label();
            DuongDanTaiKhoan = new Label();
            label1 = new Label();
            DuongDanThongTinTaiKhoan = new Label();
            DuongDanTrangChu = new Label();
            lbThongTinNguoiDung = new Label();
            panel1 = new Panel();
            tbNgaySinh = new TextBox();
            lbNgaySinh = new Label();
            tbEmail = new TextBox();
            lbEmail = new Label();
            tbUsername = new TextBox();
            lbUsername = new Label();
            tbSDT = new TextBox();
            lbSoDienThoai = new Label();
            lbHovaTen = new TextBox();
            lbHoTen = new Label();
            label4 = new Label();
            label3 = new Label();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            PanelDuongDan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Controls.Add(TimKiem);
            PanelHeader.Controls.Add(TaiKhoan);
            PanelHeader.Controls.Add(PhimHot);
            PanelHeader.Controls.Add(UuDai);
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 78);
            PanelHeader.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.Location = new Point(107, 0);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(91, 71);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // TimKiem
            // 
            TimKiem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimKiem.Location = new Point(394, 28);
            TimKiem.Margin = new Padding(3, 2, 3, 2);
            TimKiem.Name = "TimKiem";
            TimKiem.Size = new Size(181, 26);
            TimKiem.TabIndex = 3;
            TimKiem.Text = "Tìm kiếm phim";
            // 
            // TaiKhoan
            // 
            TaiKhoan.BackColor = Color.FromArgb(255, 87, 87);
            TaiKhoan.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaiKhoan.ForeColor = SystemColors.Control;
            TaiKhoan.Location = new Point(934, 18);
            TaiKhoan.Margin = new Padding(3, 2, 3, 2);
            TaiKhoan.Name = "TaiKhoan";
            TaiKhoan.Size = new Size(136, 42);
            TaiKhoan.TabIndex = 1;
            TaiKhoan.Text = "TÀI KHOẢN";
            TaiKhoan.UseVisualStyleBackColor = false;
            TaiKhoan.Click += TaiKhoan_Click;
            // 
            // PhimHot
            // 
            PhimHot.BackColor = Color.FromArgb(230, 57, 70);
            PhimHot.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhimHot.ForeColor = SystemColors.Control;
            PhimHot.Location = new Point(607, 18);
            PhimHot.Margin = new Padding(3, 2, 3, 2);
            PhimHot.Name = "PhimHot";
            PhimHot.Size = new Size(123, 42);
            PhimHot.TabIndex = 1;
            PhimHot.Text = "PHIM HOT";
            PhimHot.UseVisualStyleBackColor = false;
            // 
            // UuDai
            // 
            UuDai.BackColor = Color.FromArgb(230, 57, 70);
            UuDai.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UuDai.ForeColor = SystemColors.Control;
            UuDai.Location = new Point(769, 18);
            UuDai.Margin = new Padding(3, 2, 3, 2);
            UuDai.Name = "UuDai";
            UuDai.Size = new Size(123, 42);
            UuDai.TabIndex = 1;
            UuDai.Text = "ƯU ĐÃI";
            UuDai.UseVisualStyleBackColor = false;
            // 
            // MenuTaiKhoan
            // 
            MenuTaiKhoan.ImageScalingSize = new Size(20, 20);
            MenuTaiKhoan.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, VeDaDat, DangXuat });
            MenuTaiKhoan.Name = "MenuTaiKhoan";
            MenuTaiKhoan.Size = new Size(240, 88);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(255, 235, 235);
            toolStripMenuItem1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = Color.FromArgb(92, 77, 68);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(239, 28);
            toolStripMenuItem1.Text = "Thông tin tài khoản ";
            // 
            // VeDaDat
            // 
            VeDaDat.BackColor = Color.FromArgb(247, 201, 201);
            VeDaDat.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VeDaDat.ForeColor = Color.FromArgb(92, 77, 68);
            VeDaDat.Name = "VeDaDat";
            VeDaDat.Size = new Size(239, 28);
            VeDaDat.Text = "Vé đã đặt";
            // 
            // DangXuat
            // 
            DangXuat.BackColor = Color.FromArgb(255, 235, 235);
            DangXuat.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DangXuat.ForeColor = Color.FromArgb(92, 77, 68);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(239, 28);
            DangXuat.Text = "Đăng xuất";
            // 
            // PanelDuongDan
            // 
            PanelDuongDan.BackColor = Color.LightBlue;
            PanelDuongDan.Controls.Add(label2);
            PanelDuongDan.Controls.Add(DuongDanTaiKhoan);
            PanelDuongDan.Controls.Add(label1);
            PanelDuongDan.Controls.Add(DuongDanThongTinTaiKhoan);
            PanelDuongDan.Controls.Add(DuongDanTrangChu);
            PanelDuongDan.ForeColor = Color.Transparent;
            PanelDuongDan.Location = new Point(0, 76);
            PanelDuongDan.Margin = new Padding(3, 2, 3, 2);
            PanelDuongDan.Name = "PanelDuongDan";
            PanelDuongDan.Size = new Size(1117, 39);
            PanelDuongDan.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(229, 12);
            label2.Name = "label2";
            label2.Size = new Size(13, 18);
            label2.TabIndex = 6;
            label2.Text = "-";
            // 
            // DuongDanTaiKhoan
            // 
            DuongDanTaiKhoan.AutoSize = true;
            DuongDanTaiKhoan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanTaiKhoan.ForeColor = Color.Navy;
            DuongDanTaiKhoan.Location = new Point(147, 12);
            DuongDanTaiKhoan.Name = "DuongDanTaiKhoan";
            DuongDanTaiKhoan.Size = new Size(76, 18);
            DuongDanTaiKhoan.TabIndex = 3;
            DuongDanTaiKhoan.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(128, 12);
            label1.Name = "label1";
            label1.Size = new Size(13, 18);
            label1.TabIndex = 5;
            label1.Text = "-";
            label1.Click += label1_Click;
            // 
            // DuongDanThongTinTaiKhoan
            // 
            DuongDanThongTinTaiKhoan.AutoSize = true;
            DuongDanThongTinTaiKhoan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanThongTinTaiKhoan.ForeColor = Color.Navy;
            DuongDanThongTinTaiKhoan.Location = new Point(248, 12);
            DuongDanThongTinTaiKhoan.Name = "DuongDanThongTinTaiKhoan";
            DuongDanThongTinTaiKhoan.Size = new Size(138, 18);
            DuongDanThongTinTaiKhoan.TabIndex = 4;
            DuongDanThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // DuongDanTrangChu
            // 
            DuongDanTrangChu.AutoSize = true;
            DuongDanTrangChu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanTrangChu.ForeColor = Color.Navy;
            DuongDanTrangChu.Location = new Point(47, 12);
            DuongDanTrangChu.Name = "DuongDanTrangChu";
            DuongDanTrangChu.Size = new Size(75, 18);
            DuongDanTrangChu.TabIndex = 2;
            DuongDanTrangChu.Text = "Trang chủ";
            // 
            // lbThongTinNguoiDung
            // 
            lbThongTinNguoiDung.AutoSize = true;
            lbThongTinNguoiDung.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbThongTinNguoiDung.ForeColor = Color.Transparent;
            lbThongTinNguoiDung.Location = new Point(47, 146);
            lbThongTinNguoiDung.Name = "lbThongTinNguoiDung";
            lbThongTinNguoiDung.Size = new Size(350, 37);
            lbThongTinNguoiDung.TabIndex = 7;
            lbThongTinNguoiDung.Text = "Thông tin người dùng";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(tbNgaySinh);
            panel1.Controls.Add(lbNgaySinh);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbSDT);
            panel1.Controls.Add(lbSoDienThoai);
            panel1.Controls.Add(lbHovaTen);
            panel1.Controls.Add(lbHoTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(56, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 341);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // tbNgaySinh
            // 
            tbNgaySinh.BackColor = Color.DimGray;
            tbNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            tbNgaySinh.ForeColor = Color.White;
            tbNgaySinh.Location = new Point(671, 206);
            tbNgaySinh.Multiline = true;
            tbNgaySinh.Name = "tbNgaySinh";
            tbNgaySinh.Size = new Size(319, 42);
            tbNgaySinh.TabIndex = 18;
            // 
            // lbNgaySinh
            // 
            lbNgaySinh.AutoSize = true;
            lbNgaySinh.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNgaySinh.ForeColor = Color.White;
            lbNgaySinh.Location = new Point(671, 183);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(68, 20);
            lbNgaySinh.TabIndex = 17;
            lbNgaySinh.Text = "Ngày sinh";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.DimGray;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.ForeColor = Color.White;
            tbEmail.Location = new Point(346, 206);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(319, 42);
            tbEmail.TabIndex = 16;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(346, 183);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(42, 20);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Email";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.DimGray;
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.ForeColor = Color.White;
            tbUsername.Location = new Point(346, 93);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(319, 42);
            tbUsername.TabIndex = 14;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(346, 70);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(70, 20);
            lbUsername.TabIndex = 13;
            lbUsername.Text = "Username";
            // 
            // tbSDT
            // 
            tbSDT.BackColor = Color.DimGray;
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.ForeColor = Color.White;
            tbSDT.Location = new Point(26, 206);
            tbSDT.Multiline = true;
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(314, 42);
            tbSDT.TabIndex = 12;
            // 
            // lbSoDienThoai
            // 
            lbSoDienThoai.AutoSize = true;
            lbSoDienThoai.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSoDienThoai.ForeColor = Color.White;
            lbSoDienThoai.Location = new Point(26, 183);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(92, 20);
            lbSoDienThoai.TabIndex = 11;
            lbSoDienThoai.Text = "Số điện thoại";
            // 
            // lbHovaTen
            // 
            lbHovaTen.BackColor = Color.DimGray;
            lbHovaTen.BorderStyle = BorderStyle.FixedSingle;
            lbHovaTen.ForeColor = Color.White;
            lbHovaTen.Location = new Point(26, 93);
            lbHovaTen.Multiline = true;
            lbHovaTen.Name = "lbHovaTen";
            lbHovaTen.Size = new Size(314, 42);
            lbHovaTen.TabIndex = 10;
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHoTen.ForeColor = Color.White;
            lbHoTen.Location = new Point(26, 70);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(71, 20);
            lbHoTen.TabIndex = 9;
            lbHoTen.Text = "Họ và Tên";
            lbHoTen.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(26, 18);
            label4.Name = "label4";
            label4.Size = new Size(178, 22);
            label4.TabIndex = 8;
            label4.Text = "Thông tin cá nhân";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(53, 18);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // ThongTInTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(1119, 644);
            Controls.Add(panel1);
            Controls.Add(lbThongTinNguoiDung);
            Controls.Add(PanelDuongDan);
            Controls.Add(PanelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTInTaiKhoan";
            Text = "ThongTInTaiKhoan";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            PanelDuongDan.ResumeLayout(false);
            PanelDuongDan.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private PictureBox Logo;
        private TextBox TimKiem;
        private Button TaiKhoan;
        private Button PhimHot;
        private Button UuDai;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private Panel PanelDuongDan;
        private Label DuongDanTrangChu;
        private Label label2;
        private Label DuongDanTaiKhoan;
        private Label label1;
        private Label DuongDanThongTinTaiKhoan;
        private Label lbThongTinNguoiDung;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TextBox lbHovaTen;
        private Label lbHoTen;
        private TextBox tbSDT;
        private Label lbSoDienThoai;
        private TextBox tbUsername;
        private Label lbUsername;
        private TextBox tbNgaySinh;
        private Label lbNgaySinh;
        private TextBox tbEmail;
        private Label lbEmail;
    }
}