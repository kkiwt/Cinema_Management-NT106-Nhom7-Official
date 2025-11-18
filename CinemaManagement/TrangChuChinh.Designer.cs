namespace CinemaManagement
{
    partial class TrangChuChinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelHeader = new Panel();
            Logo = new PictureBox();
            TimKiem = new TextBox();
            TaiKhoan = new Button();
            MenuTaiKhoan = new ContextMenuStrip(components);
            ThongTinTaiKhoan = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            PhimHot = new Button();
            UuDai = new Button();
            PanelDuongDan = new Panel();
            DuongDan = new Label();
            Phim1 = new MetroFramework.Controls.MetroUserControl();
            ChiTietPhim1 = new Button();
            PanelChinh = new Panel();
            TenPhim3 = new Label();
            TenPhim2 = new Label();
            TenPhim1 = new Label();
            PhimDangChieu = new Label();
            Next = new Button();
            Prev = new Button();
            DatVePhim3 = new Button();
            ChiTietPhim3 = new Button();
            PosterPhim3 = new PictureBox();
            Phim3 = new MetroFramework.Controls.MetroUserControl();
            DatVePhim2 = new Button();
            ChiTietPhim2 = new Button();
            PosterPhim2 = new PictureBox();
            Phim2 = new MetroFramework.Controls.MetroUserControl();
            DatVePhim1 = new Button();
            PosterPhim1 = new PictureBox();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            PanelDuongDan.SuspendLayout();
            PanelChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PosterPhim3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PosterPhim2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PosterPhim1).BeginInit();
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
            PanelHeader.Location = new Point(0, 1);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 78);
            PanelHeader.TabIndex = 0;
            // 
            // Logo
            // 
            Logo.Location = new Point(74, 10);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(84, 58);
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
            TaiKhoan.ContextMenuStrip = MenuTaiKhoan;
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
            // MenuTaiKhoan
            // 
            MenuTaiKhoan.ImageScalingSize = new Size(20, 20);
            MenuTaiKhoan.Items.AddRange(new ToolStripItem[] { ThongTinTaiKhoan, VeDaDat, DangXuat });
            MenuTaiKhoan.Name = "MenuTaiKhoan";
            MenuTaiKhoan.Size = new Size(240, 88);
            MenuTaiKhoan.Opening += MenuTaiKhoan_Opening;
            // 
            // ThongTinTaiKhoan
            // 
            ThongTinTaiKhoan.BackColor = Color.FromArgb(255, 235, 235);
            ThongTinTaiKhoan.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThongTinTaiKhoan.ForeColor = Color.FromArgb(92, 77, 68);
            ThongTinTaiKhoan.Name = "ThongTinTaiKhoan";
            ThongTinTaiKhoan.Size = new Size(239, 28);
            ThongTinTaiKhoan.Text = "Thông tin tài khoản ";
            ThongTinTaiKhoan.Click += ThongTinTaiKhoan_Click;
            // 
            // VeDaDat
            // 
            VeDaDat.BackColor = Color.FromArgb(247, 201, 201);
            VeDaDat.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VeDaDat.ForeColor = Color.FromArgb(92, 77, 68);
            VeDaDat.Name = "VeDaDat";
            VeDaDat.Size = new Size(239, 28);
            VeDaDat.Text = "Vé đã đặt";
            VeDaDat.Click += VeDaDat_Click;
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
            PhimHot.Click += PhimHot_Click;
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
            UuDai.Click += UuDai_Click;
            // 
            // PanelDuongDan
            // 
            PanelDuongDan.BackColor = Color.LightBlue;
            PanelDuongDan.Controls.Add(DuongDan);
            PanelDuongDan.ForeColor = Color.Transparent;
            PanelDuongDan.Location = new Point(0, 76);
            PanelDuongDan.Margin = new Padding(3, 2, 3, 2);
            PanelDuongDan.Name = "PanelDuongDan";
            PanelDuongDan.Size = new Size(1117, 39);
            PanelDuongDan.TabIndex = 1;
            // 
            // DuongDan
            // 
            DuongDan.AutoSize = true;
            DuongDan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDan.ForeColor = Color.Navy;
            DuongDan.Location = new Point(47, 12);
            DuongDan.Name = "DuongDan";
            DuongDan.Size = new Size(75, 18);
            DuongDan.TabIndex = 2;
            DuongDan.Text = "Trang chủ";
            DuongDan.Click += DuongDan_Click;
            // 
            // Phim1
            // 
            Phim1.BackColor = SystemColors.ControlLightLight;
            Phim1.CustomBackground = false;
            Phim1.Location = new Point(107, 65);
            Phim1.Margin = new Padding(3, 2, 3, 2);
            Phim1.Name = "Phim1";
            Phim1.Size = new Size(261, 332);
            Phim1.Style = MetroFramework.MetroColorStyle.Magenta;
            Phim1.StyleManager = null;
            Phim1.TabIndex = 3;
            Phim1.Theme = MetroFramework.MetroThemeStyle.Dark;
            Phim1.Load += Phim_Load;
            // 
            // ChiTietPhim1
            // 
            ChiTietPhim1.BackColor = Color.Pink;
            ChiTietPhim1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChiTietPhim1.ForeColor = Color.Maroon;
            ChiTietPhim1.Location = new Point(123, 365);
            ChiTietPhim1.Margin = new Padding(3, 2, 3, 2);
            ChiTietPhim1.Name = "ChiTietPhim1";
            ChiTietPhim1.Size = new Size(94, 32);
            ChiTietPhim1.TabIndex = 5;
            ChiTietPhim1.Text = "CHI TIẾT";
            ChiTietPhim1.UseVisualStyleBackColor = false;
            ChiTietPhim1.Click += ChiTietPhim1_Click;
            // 
            // PanelChinh
            // 
            PanelChinh.BackColor = Color.FromArgb(4, 21, 49);
            PanelChinh.Controls.Add(TenPhim3);
            PanelChinh.Controls.Add(TenPhim2);
            PanelChinh.Controls.Add(TenPhim1);
            PanelChinh.Controls.Add(PhimDangChieu);
            PanelChinh.Controls.Add(Next);
            PanelChinh.Controls.Add(Prev);
            PanelChinh.Controls.Add(DatVePhim3);
            PanelChinh.Controls.Add(ChiTietPhim3);
            PanelChinh.Controls.Add(PosterPhim3);
            PanelChinh.Controls.Add(Phim3);
            PanelChinh.Controls.Add(DatVePhim2);
            PanelChinh.Controls.Add(ChiTietPhim2);
            PanelChinh.Controls.Add(PosterPhim2);
            PanelChinh.Controls.Add(Phim2);
            PanelChinh.Controls.Add(DatVePhim1);
            PanelChinh.Controls.Add(ChiTietPhim1);
            PanelChinh.Controls.Add(PosterPhim1);
            PanelChinh.Controls.Add(Phim1);
            PanelChinh.Location = new Point(0, 108);
            PanelChinh.Margin = new Padding(3, 2, 3, 2);
            PanelChinh.Name = "PanelChinh";
            PanelChinh.Size = new Size(1117, 497);
            PanelChinh.TabIndex = 3;
            PanelChinh.Paint += PanelChinh_Paint;
            // 
            // TenPhim3
            // 
            TenPhim3.AutoSize = true;
            TenPhim3.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenPhim3.ForeColor = SystemColors.Menu;
            TenPhim3.Location = new Point(835, 338);
            TenPhim3.Name = "TenPhim3";
            TenPhim3.Size = new Size(106, 26);
            TenPhim3.TabIndex = 24;
            TenPhim3.Text = "EXHUMA";
            TenPhim3.Click += TenPhim3_Click;
            // 
            // TenPhim2
            // 
            TenPhim2.AutoSize = true;
            TenPhim2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenPhim2.ForeColor = SystemColors.Menu;
            TenPhim2.Location = new Point(492, 338);
            TenPhim2.Name = "TenPhim2";
            TenPhim2.Size = new Size(123, 26);
            TenPhim2.TabIndex = 23;
            TenPhim2.Text = "TEEYOD 3";
            TenPhim2.Click += TenPhim2_Click;
            // 
            // TenPhim1
            // 
            TenPhim1.AutoSize = true;
            TenPhim1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenPhim1.ForeColor = SystemColors.Menu;
            TenPhim1.Location = new Point(206, 338);
            TenPhim1.Name = "TenPhim1";
            TenPhim1.Size = new Size(49, 26);
            TenPhim1.TabIndex = 22;
            TenPhim1.Text = "MAI";
            // 
            // PhimDangChieu
            // 
            PhimDangChieu.AutoSize = true;
            PhimDangChieu.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhimDangChieu.ForeColor = Color.FromArgb(255, 212, 59);
            PhimDangChieu.Location = new Point(74, 21);
            PhimDangChieu.Name = "PhimDangChieu";
            PhimDangChieu.Size = new Size(263, 32);
            PhimDangChieu.TabIndex = 21;
            PhimDangChieu.Text = "PHIM ĐANG CHIẾU";
            // 
            // Next
            // 
            Next.BackColor = Color.FromArgb(21, 3, 27);
            Next.FlatAppearance.BorderSize = 0;
            Next.FlatStyle = FlatStyle.Flat;
            Next.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Next.ForeColor = SystemColors.Control;
            Next.Location = new Point(1040, 169);
            Next.Margin = new Padding(3, 2, 3, 2);
            Next.Name = "Next";
            Next.Size = new Size(53, 74);
            Next.TabIndex = 20;
            Next.Text = ">";
            Next.UseVisualStyleBackColor = false;
            Next.Click += Next_Click;
            // 
            // Prev
            // 
            Prev.BackColor = Color.FromArgb(21, 3, 27);
            Prev.FlatAppearance.BorderSize = 0;
            Prev.FlatStyle = FlatStyle.Flat;
            Prev.Font = new Font("Arial Narrow", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Prev.ForeColor = SystemColors.Control;
            Prev.Location = new Point(33, 169);
            Prev.Margin = new Padding(3, 2, 3, 2);
            Prev.Name = "Prev";
            Prev.Size = new Size(53, 74);
            Prev.TabIndex = 19;
            Prev.Text = "<";
            Prev.UseVisualStyleBackColor = false;
            Prev.Click += Prev_Click;
            // 
            // DatVePhim3
            // 
            DatVePhim3.BackColor = Color.FromArgb(230, 57, 70);
            DatVePhim3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatVePhim3.ForeColor = SystemColors.Control;
            DatVePhim3.Location = new Point(900, 365);
            DatVePhim3.Margin = new Padding(3, 2, 3, 2);
            DatVePhim3.Name = "DatVePhim3";
            DatVePhim3.Size = new Size(94, 33);
            DatVePhim3.TabIndex = 16;
            DatVePhim3.Text = "ĐẶT VÉ";
            DatVePhim3.UseCompatibleTextRendering = true;
            DatVePhim3.UseVisualStyleBackColor = false;
            // 
            // ChiTietPhim3
            // 
            ChiTietPhim3.BackColor = Color.Pink;
            ChiTietPhim3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChiTietPhim3.ForeColor = Color.Maroon;
            ChiTietPhim3.Location = new Point(772, 365);
            ChiTietPhim3.Margin = new Padding(3, 2, 3, 2);
            ChiTietPhim3.Name = "ChiTietPhim3";
            ChiTietPhim3.Size = new Size(94, 32);
            ChiTietPhim3.TabIndex = 15;
            ChiTietPhim3.Text = "CHI TIẾT";
            ChiTietPhim3.UseVisualStyleBackColor = false;
            // 
            // PosterPhim3
            // 
            PosterPhim3.Location = new Point(757, 65);
            PosterPhim3.Margin = new Padding(3, 2, 3, 2);
            PosterPhim3.Name = "PosterPhim3";
            PosterPhim3.Size = new Size(259, 263);
            PosterPhim3.SizeMode = PictureBoxSizeMode.Zoom;
            PosterPhim3.TabIndex = 14;
            PosterPhim3.TabStop = false;
            // 
            // Phim3
            // 
            Phim3.BackColor = SystemColors.ControlLightLight;
            Phim3.CustomBackground = false;
            Phim3.Location = new Point(755, 65);
            Phim3.Margin = new Padding(3, 2, 3, 2);
            Phim3.Name = "Phim3";
            Phim3.Size = new Size(261, 332);
            Phim3.Style = MetroFramework.MetroColorStyle.Magenta;
            Phim3.StyleManager = null;
            Phim3.TabIndex = 13;
            Phim3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DatVePhim2
            // 
            DatVePhim2.BackColor = Color.FromArgb(230, 57, 70);
            DatVePhim2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatVePhim2.ForeColor = SystemColors.Control;
            DatVePhim2.Location = new Point(573, 365);
            DatVePhim2.Margin = new Padding(3, 2, 3, 2);
            DatVePhim2.Name = "DatVePhim2";
            DatVePhim2.Size = new Size(94, 33);
            DatVePhim2.TabIndex = 11;
            DatVePhim2.Text = "ĐẶT VÉ";
            DatVePhim2.UseCompatibleTextRendering = true;
            DatVePhim2.UseVisualStyleBackColor = false;
            // 
            // ChiTietPhim2
            // 
            ChiTietPhim2.BackColor = Color.Pink;
            ChiTietPhim2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChiTietPhim2.ForeColor = Color.Maroon;
            ChiTietPhim2.Location = new Point(445, 365);
            ChiTietPhim2.Margin = new Padding(3, 2, 3, 2);
            ChiTietPhim2.Name = "ChiTietPhim2";
            ChiTietPhim2.Size = new Size(94, 32);
            ChiTietPhim2.TabIndex = 10;
            ChiTietPhim2.Text = "CHI TIẾT";
            ChiTietPhim2.UseVisualStyleBackColor = false;
            // 
            // PosterPhim2
            // 
            PosterPhim2.Location = new Point(430, 65);
            PosterPhim2.Margin = new Padding(3, 2, 3, 2);
            PosterPhim2.Name = "PosterPhim2";
            PosterPhim2.Size = new Size(259, 263);
            PosterPhim2.SizeMode = PictureBoxSizeMode.Zoom;
            PosterPhim2.TabIndex = 9;
            PosterPhim2.TabStop = false;
            // 
            // Phim2
            // 
            Phim2.BackColor = SystemColors.ControlLightLight;
            Phim2.CustomBackground = false;
            Phim2.Location = new Point(429, 65);
            Phim2.Margin = new Padding(3, 2, 3, 2);
            Phim2.Name = "Phim2";
            Phim2.Size = new Size(261, 332);
            Phim2.Style = MetroFramework.MetroColorStyle.Magenta;
            Phim2.StyleManager = null;
            Phim2.TabIndex = 8;
            Phim2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DatVePhim1
            // 
            DatVePhim1.BackColor = Color.FromArgb(230, 57, 70);
            DatVePhim1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatVePhim1.ForeColor = SystemColors.Control;
            DatVePhim1.Location = new Point(251, 365);
            DatVePhim1.Margin = new Padding(3, 2, 3, 2);
            DatVePhim1.Name = "DatVePhim1";
            DatVePhim1.Size = new Size(94, 33);
            DatVePhim1.TabIndex = 6;
            DatVePhim1.Text = "ĐẶT VÉ";
            DatVePhim1.UseCompatibleTextRendering = true;
            DatVePhim1.UseVisualStyleBackColor = false;
            // 
            // PosterPhim1
            // 
            PosterPhim1.Location = new Point(108, 65);
            PosterPhim1.Margin = new Padding(3, 2, 3, 2);
            PosterPhim1.Name = "PosterPhim1";
            PosterPhim1.Size = new Size(259, 263);
            PosterPhim1.SizeMode = PictureBoxSizeMode.Zoom;
            PosterPhim1.TabIndex = 4;
            PosterPhim1.TabStop = false;
            PosterPhim1.Click += Poster_Click;
            // 
            // TrangChuChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 3, 27);
            ClientSize = new Size(1117, 597);
            Controls.Add(PanelChinh);
            Controls.Add(PanelDuongDan);
            Controls.Add(PanelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TrangChuChinh";
            Text = "Solunar Cinema";
            Load += TrangChuChinh_Load;
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            PanelDuongDan.ResumeLayout(false);
            PanelDuongDan.PerformLayout();
            PanelChinh.ResumeLayout(false);
            PanelChinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PosterPhim3).EndInit();
            ((System.ComponentModel.ISupportInitialize)PosterPhim2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PosterPhim1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeader;
        private Button PhimHot;
        private Button UuDai;
        private Button TaiKhoan;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem ThongTinTaiKhoan;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private Panel PanelDuongDan;
        private Label DuongDan;
        private MetroFramework.Controls.MetroUserControl Phim1;
        private Button ChiTietPhim1;
        private Panel PanelChinh;
        private Button DatVePhim1;
        private Button DatVePhim3;
        private Button ChiTietPhim3;
        private MetroFramework.Controls.MetroUserControl Phim3;
        private Button DatVePhim2;
        private Button ChiTietPhim2;
        private MetroFramework.Controls.MetroUserControl Phim2;
        private Button Prev;
        private Button Next;
        private TextBox TimKiem;
        private Label PhimDangChieu;
        private Label TenPhim1;
        private Label TenPhim3;
        private Label TenPhim2;
        private PictureBox Logo;
        private PictureBox PosterPhim3;
        private PictureBox PosterPhim2;
        private PictureBox PosterPhim1;
    }
}
