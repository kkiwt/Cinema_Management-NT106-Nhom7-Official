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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTInTaiKhoan));
            PanelHeader = new Panel();
            label1 = new Label();
            Logo = new PictureBox();
            MenuTaiKhoan = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            lbThongTinNguoiDung = new Label();
            panel1 = new Panel();
            label5 = new Label();
            ID = new TextBox();
            tbNgaySinh = new TextBox();
            lbNgaySinh = new Label();
            tbEmail = new TextBox();
            lbEmail = new Label();
            tbUsername = new TextBox();
            lbUsername = new Label();
            tbSDT = new TextBox();
            lbSoDienThoai = new Label();
            tbHovaTen = new TextBox();
            lbHoTen = new Label();
            label4 = new Label();
            label3 = new Label();
            NutQuayLai = new MaterialSkin.Controls.MaterialButton();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(label1);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 130);
            PanelHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(333, 42);
            label1.Name = "label1";
            label1.Size = new Size(525, 37);
            label1.TabIndex = 8;
            label1.Text = "Solunar Cinema User Information";
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(37, 5);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(152, 117);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
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
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ID);
            panel1.Controls.Add(tbNgaySinh);
            panel1.Controls.Add(lbNgaySinh);
            panel1.Controls.Add(tbEmail);
            panel1.Controls.Add(lbEmail);
            panel1.Controls.Add(tbUsername);
            panel1.Controls.Add(lbUsername);
            panel1.Controls.Add(tbSDT);
            panel1.Controls.Add(lbSoDienThoai);
            panel1.Controls.Add(tbHovaTen);
            panel1.Controls.Add(lbHoTen);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(47, 196);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 341);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(669, 70);
            label5.Name = "label5";
            label5.Size = new Size(25, 19);
            label5.TabIndex = 20;
            label5.Text = "ID";
            // 
            // ID
            // 
            ID.BackColor = Color.DimGray;
            ID.BorderStyle = BorderStyle.FixedSingle;
            ID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ID.ForeColor = Color.White;
            ID.Location = new Point(671, 93);
            ID.Multiline = true;
            ID.Name = "ID";
            ID.Size = new Size(319, 42);
            ID.TabIndex = 19;
            // 
            // tbNgaySinh
            // 
            tbNgaySinh.BackColor = Color.DimGray;
            tbNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            tbNgaySinh.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lbNgaySinh.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNgaySinh.ForeColor = Color.White;
            lbNgaySinh.Location = new Point(671, 183);
            lbNgaySinh.Name = "lbNgaySinh";
            lbNgaySinh.Size = new Size(88, 19);
            lbNgaySinh.TabIndex = 17;
            lbNgaySinh.Text = "Ngày Sinh";
            // 
            // tbEmail
            // 
            tbEmail.BackColor = Color.DimGray;
            tbEmail.BorderStyle = BorderStyle.FixedSingle;
            tbEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lbEmail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.White;
            lbEmail.Location = new Point(346, 183);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(51, 19);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Email";
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.DimGray;
            tbUsername.BorderStyle = BorderStyle.FixedSingle;
            tbUsername.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbUsername.ForeColor = Color.White;
            tbUsername.Location = new Point(346, 93);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(319, 42);
            tbUsername.TabIndex = 14;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.ForeColor = Color.White;
            lbUsername.Location = new Point(346, 70);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(87, 19);
            lbUsername.TabIndex = 13;
            lbUsername.Text = "Username";
            // 
            // tbSDT
            // 
            tbSDT.BackColor = Color.DimGray;
            tbSDT.BorderStyle = BorderStyle.FixedSingle;
            tbSDT.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            lbSoDienThoai.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoDienThoai.ForeColor = Color.White;
            lbSoDienThoai.Location = new Point(26, 183);
            lbSoDienThoai.Name = "lbSoDienThoai";
            lbSoDienThoai.Size = new Size(116, 19);
            lbSoDienThoai.TabIndex = 11;
            lbSoDienThoai.Text = "Số Điện Thoại";
            // 
            // tbHovaTen
            // 
            tbHovaTen.BackColor = Color.DimGray;
            tbHovaTen.BorderStyle = BorderStyle.FixedSingle;
            tbHovaTen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbHovaTen.ForeColor = Color.White;
            tbHovaTen.Location = new Point(26, 93);
            tbHovaTen.Multiline = true;
            tbHovaTen.Name = "tbHovaTen";
            tbHovaTen.Size = new Size(314, 42);
            tbHovaTen.TabIndex = 10;
            // 
            // lbHoTen
            // 
            lbHoTen.AutoSize = true;
            lbHoTen.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHoTen.ForeColor = Color.White;
            lbHoTen.Location = new Point(26, 70);
            lbHoTen.Name = "lbHoTen";
            lbHoTen.Size = new Size(88, 19);
            lbHoTen.TabIndex = 9;
            lbHoTen.Text = "Họ Và Tên";
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
            // NutQuayLai
            // 
            NutQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NutQuayLai.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NutQuayLai.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            NutQuayLai.Depth = 0;
            NutQuayLai.Font = new Font("Noto Sans SC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutQuayLai.HighEmphasis = true;
            NutQuayLai.Icon = null;
            NutQuayLai.Location = new Point(953, 146);
            NutQuayLai.Margin = new Padding(4, 6, 4, 6);
            NutQuayLai.MouseState = MaterialSkin.MouseState.HOVER;
            NutQuayLai.Name = "NutQuayLai";
            NutQuayLai.NoAccentTextColor = Color.Empty;
            NutQuayLai.Size = new Size(85, 36);
            NutQuayLai.TabIndex = 9;
            NutQuayLai.Text = "Quay Lại";
            NutQuayLai.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            NutQuayLai.UseAccentColor = false;
            NutQuayLai.UseVisualStyleBackColor = true;
            NutQuayLai.Click += NutQuayLai_Click;
            // 
            // ThongTInTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(1119, 583);
            Controls.Add(NutQuayLai);
            Controls.Add(panel1);
            Controls.Add(lbThongTinNguoiDung);
            Controls.Add(PanelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ThongTInTaiKhoan";
            Text = "ThongTInTaiKhoan";
            Load += ThongTInTaiKhoan_Load;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private PictureBox Logo;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private Label lbThongTinNguoiDung;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TextBox tbHovaTen;
        private Label lbHoTen;
        private TextBox tbSDT;
        private Label lbSoDienThoai;
        private TextBox tbUsername;
        private Label lbUsername;
        private TextBox tbNgaySinh;
        private Label lbNgaySinh;
        private TextBox tbEmail;
        private Label lbEmail;
        private Label label5;
        private TextBox ID;
        private MaterialSkin.Controls.MaterialButton NutQuayLai;
        private Label label1;
    }
}