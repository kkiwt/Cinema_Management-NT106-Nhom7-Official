namespace CinemaManagement
{
    partial class PhimHot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhimHot));
            PanelHeader = new Panel();
            Logo = new PictureBox();
            TaiKhoan = new Button();
            DanhSachPhimHot = new Button();
            UuDai = new Button();
            PanelDuongDan = new Panel();
            House = new PictureBox();
            LinkTrangChuChinh = new LinkLabel();
            DanhSachCacPhim = new Label();
            flpDanhSachPhim = new FlowLayoutPanel();
            MenuTaiKhoan = new ContextMenuStrip(components);
            ThongTinTaiKhoan = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            NutBapNuoc = new Button();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            PanelDuongDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)House).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(NutBapNuoc);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Controls.Add(TaiKhoan);
            PanelHeader.Controls.Add(DanhSachPhimHot);
            PanelHeader.Controls.Add(UuDai);
            PanelHeader.Location = new Point(2, 0);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1120, 89);
            PanelHeader.TabIndex = 2;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(77, 8);
            Logo.Name = "Logo";
            Logo.Size = new Size(83, 75);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
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
            // DanhSachPhimHot
            // 
            DanhSachPhimHot.BackColor = Color.FromArgb(230, 57, 70);
            DanhSachPhimHot.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DanhSachPhimHot.ForeColor = SystemColors.Control;
            DanhSachPhimHot.Location = new Point(480, 18);
            DanhSachPhimHot.Margin = new Padding(3, 2, 3, 2);
            DanhSachPhimHot.Name = "DanhSachPhimHot";
            DanhSachPhimHot.Size = new Size(123, 42);
            DanhSachPhimHot.TabIndex = 1;
            DanhSachPhimHot.Text = "PHIM HOT";
            DanhSachPhimHot.UseVisualStyleBackColor = false;
            DanhSachPhimHot.Click += DanhSachPhimHot_Click;
            // 
            // UuDai
            // 
            UuDai.BackColor = Color.FromArgb(230, 57, 70);
            UuDai.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UuDai.ForeColor = SystemColors.Control;
            UuDai.Location = new Point(790, 18);
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
            PanelDuongDan.Controls.Add(House);
            PanelDuongDan.Controls.Add(LinkTrangChuChinh);
            PanelDuongDan.ForeColor = Color.Transparent;
            PanelDuongDan.Location = new Point(2, 88);
            PanelDuongDan.Margin = new Padding(3, 2, 3, 2);
            PanelDuongDan.Name = "PanelDuongDan";
            PanelDuongDan.Size = new Size(1117, 49);
            PanelDuongDan.TabIndex = 3;
            // 
            // House
            // 
            House.Image = (Image)resources.GetObject("House.Image");
            House.InitialImage = null;
            House.Location = new Point(27, 6);
            House.Name = "House";
            House.Size = new Size(41, 33);
            House.SizeMode = PictureBoxSizeMode.StretchImage;
            House.TabIndex = 1;
            House.TabStop = false;
            // 
            // LinkTrangChuChinh
            // 
            LinkTrangChuChinh.AutoSize = true;
            LinkTrangChuChinh.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTrangChuChinh.LinkColor = Color.Navy;
            LinkTrangChuChinh.Location = new Point(74, 15);
            LinkTrangChuChinh.Name = "LinkTrangChuChinh";
            LinkTrangChuChinh.Size = new Size(220, 18);
            LinkTrangChuChinh.TabIndex = 0;
            LinkTrangChuChinh.TabStop = true;
            LinkTrangChuChinh.Text = "Trang chủ chính >> Phim HOT  ";
            LinkTrangChuChinh.LinkClicked += LinkTrangChuChinh_LinkClicked;
            // 
            // DanhSachCacPhim
            // 
            DanhSachCacPhim.AutoSize = true;
            DanhSachCacPhim.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DanhSachCacPhim.ForeColor = Color.FromArgb(255, 212, 59);
            DanhSachCacPhim.Location = new Point(79, 166);
            DanhSachCacPhim.Name = "DanhSachCacPhim";
            DanhSachCacPhim.Size = new Size(502, 32);
            DanhSachCacPhim.TabIndex = 23;
            DanhSachCacPhim.Text = "DANH SÁCH CÁC PHIM ĐANG CHIẾU";
            // 
            // flpDanhSachPhim
            // 
            flpDanhSachPhim.AutoScroll = true;
            flpDanhSachPhim.Location = new Point(89, 201);
            flpDanhSachPhim.Name = "flpDanhSachPhim";
            flpDanhSachPhim.Size = new Size(1016, 497);
            flpDanhSachPhim.TabIndex = 24;
            // 
            // MenuTaiKhoan
            // 
            MenuTaiKhoan.ImageScalingSize = new Size(20, 20);
            MenuTaiKhoan.Items.AddRange(new ToolStripItem[] { ThongTinTaiKhoan, VeDaDat, DangXuat });
            MenuTaiKhoan.Name = "MenuTaiKhoan";
            MenuTaiKhoan.Size = new Size(240, 88);
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
            // 
            // DangXuat
            // 
            DangXuat.BackColor = Color.FromArgb(255, 235, 235);
            DangXuat.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DangXuat.ForeColor = Color.FromArgb(92, 77, 68);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(239, 28);
            DangXuat.Text = "Đăng xuất";
            DangXuat.Click += DangXuat_Click;
            // 
            // NutBapNuoc
            // 
            NutBapNuoc.BackColor = Color.FromArgb(230, 57, 70);
            NutBapNuoc.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutBapNuoc.ForeColor = SystemColors.Control;
            NutBapNuoc.Location = new Point(624, 18);
            NutBapNuoc.Margin = new Padding(3, 2, 3, 2);
            NutBapNuoc.Name = "NutBapNuoc";
            NutBapNuoc.Size = new Size(146, 42);
            NutBapNuoc.TabIndex = 6;
            NutBapNuoc.Text = "BẮP NƯỚC";
            NutBapNuoc.UseVisualStyleBackColor = false;
            NutBapNuoc.Click += NutBapNuoc_Click;
            // 
            // PhimHot
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(1104, 686);
            Controls.Add(flpDanhSachPhim);
            Controls.Add(DanhSachCacPhim);
            Controls.Add(PanelDuongDan);
            Controls.Add(PanelHeader);
            Name = "PhimHot";
            Text = "Solunar Cinema";
            FormClosed += PhimHot_FormClosed;
            PanelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            PanelDuongDan.ResumeLayout(false);
            PanelDuongDan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)House).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelHeader;
        private PictureBox Logo;
        private Button TaiKhoan;
        private Button DanhSachPhimHot;
        private Button UuDai;
        private Panel PanelDuongDan;
        private PictureBox House;
        private LinkLabel LinkTrangChuChinh;
        private Label DanhSachCacPhim;
        private FlowLayoutPanel flpDanhSachPhim;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem ThongTinTaiKhoan;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private Button NutBapNuoc;
    }
}