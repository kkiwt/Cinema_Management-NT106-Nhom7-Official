namespace CinemaManagement
{
    partial class ChiTietPhim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietPhim));
            panelDuongDan = new Panel();
            House = new PictureBox();
            LinkTenPhim = new LinkLabel();
            LinkTrangChuChinh = new LinkLabel();
            PanelChinh = new Panel();
            NoiDungPhim = new Label();
            DanhGia = new Button();
            Trailer = new Button();
            DatVe = new Button();
            PanelChiTietPhim = new Panel();
            MoTa = new TextBox();
            DienVien = new TextBox();
            TenPhim = new Label();
            ThoiLuong = new Label();
            DoTuoi = new Label();
            QuocGia = new Label();
            NgonNgu = new Label();
            TheLoai = new Label();
            DaoDien = new Label();
            PosterPhim = new PictureBox();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            PanelHeader = new Panel();
            Logo = new PictureBox();
            TimKiem = new TextBox();
            TaiKhoan = new Button();
            PhimHot = new Button();
            UuDai = new Button();
            MenuTaiKhoan = new ContextMenuStrip(components);
            ThongTinTaiKhoan = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            panelDuongDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)House).BeginInit();
            PanelChinh.SuspendLayout();
            PanelChiTietPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PosterPhim).BeginInit();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            SuspendLayout();
            // 
            // panelDuongDan
            // 
            panelDuongDan.BackColor = Color.LightBlue;
            panelDuongDan.Controls.Add(House);
            panelDuongDan.Controls.Add(LinkTenPhim);
            panelDuongDan.Controls.Add(LinkTrangChuChinh);
            panelDuongDan.ForeColor = Color.Transparent;
            panelDuongDan.Location = new Point(0, 72);
            panelDuongDan.Margin = new Padding(3, 2, 3, 2);
            panelDuongDan.Name = "panelDuongDan";
            panelDuongDan.Size = new Size(1117, 53);
            panelDuongDan.TabIndex = 2;
            // 
            // House
            // 
            House.Image = (Image)resources.GetObject("House.Image");
            House.InitialImage = null;
            House.Location = new Point(40, 11);
            House.Name = "House";
            House.Size = new Size(37, 33);
            House.SizeMode = PictureBoxSizeMode.StretchImage;
            House.TabIndex = 6;
            House.TabStop = false;
            // 
            // LinkTenPhim
            // 
            LinkTenPhim.AutoSize = true;
            LinkTenPhim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTenPhim.LinkColor = Color.Navy;
            LinkTenPhim.Location = new Point(236, 17);
            LinkTenPhim.Name = "LinkTenPhim";
            LinkTenPhim.Size = new Size(74, 18);
            LinkTenPhim.TabIndex = 4;
            LinkTenPhim.TabStop = true;
            LinkTenPhim.Text = "Tên Phim";
            LinkTenPhim.LinkClicked += LinkTenPhim_LinkClicked;
            // 
            // LinkTrangChuChinh
            // 
            LinkTrangChuChinh.AutoSize = true;
            LinkTrangChuChinh.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkTrangChuChinh.LinkColor = Color.Navy;
            LinkTrangChuChinh.Location = new Point(83, 17);
            LinkTrangChuChinh.Name = "LinkTrangChuChinh";
            LinkTrangChuChinh.Size = new Size(136, 18);
            LinkTrangChuChinh.TabIndex = 3;
            LinkTrangChuChinh.TabStop = true;
            LinkTrangChuChinh.Text = "Trang chủ chính >>";
            LinkTrangChuChinh.LinkClicked += LinkTrangChuChinh_LinkClicked;
            // 
            // PanelChinh
            // 
            PanelChinh.BackColor = Color.FromArgb(21, 3, 27);
            PanelChinh.Controls.Add(NoiDungPhim);
            PanelChinh.Controls.Add(DanhGia);
            PanelChinh.Controls.Add(Trailer);
            PanelChinh.Controls.Add(DatVe);
            PanelChinh.Controls.Add(PanelChiTietPhim);
            PanelChinh.Location = new Point(3, 121);
            PanelChinh.Margin = new Padding(3, 2, 3, 2);
            PanelChinh.Name = "PanelChinh";
            PanelChinh.Size = new Size(1117, 570);
            PanelChinh.TabIndex = 4;
            // 
            // NoiDungPhim
            // 
            NoiDungPhim.AutoSize = true;
            NoiDungPhim.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoiDungPhim.ForeColor = Color.FromArgb(255, 212, 59);
            NoiDungPhim.Location = new Point(80, 34);
            NoiDungPhim.Name = "NoiDungPhim";
            NoiDungPhim.Size = new Size(227, 32);
            NoiDungPhim.TabIndex = 10;
            NoiDungPhim.Text = "NỘI DUNG PHIM";
            // 
            // DanhGia
            // 
            DanhGia.BackColor = Color.Pink;
            DanhGia.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DanhGia.ForeColor = Color.Maroon;
            DanhGia.Location = new Point(710, 507);
            DanhGia.Margin = new Padding(3, 2, 3, 2);
            DanhGia.Name = "DanhGia";
            DanhGia.Size = new Size(122, 38);
            DanhGia.TabIndex = 9;
            DanhGia.Text = "ĐÁNH GIÁ ";
            DanhGia.UseVisualStyleBackColor = false;
            DanhGia.Click += DanhGia_Click;
            // 
            // Trailer
            // 
            Trailer.BackColor = Color.Pink;
            Trailer.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Trailer.ForeColor = Color.Maroon;
            Trailer.Location = new Point(301, 507);
            Trailer.Margin = new Padding(3, 2, 3, 2);
            Trailer.Name = "Trailer";
            Trailer.Size = new Size(122, 38);
            Trailer.TabIndex = 8;
            Trailer.Text = "TRAILER";
            Trailer.UseVisualStyleBackColor = false;
            Trailer.Click += Trailer_Click;
            // 
            // DatVe
            // 
            DatVe.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DatVe.BackColor = Color.FromArgb(230, 57, 70);
            DatVe.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatVe.ForeColor = SystemColors.Control;
            DatVe.Location = new Point(511, 507);
            DatVe.Margin = new Padding(3, 2, 3, 2);
            DatVe.Name = "DatVe";
            DatVe.Size = new Size(122, 38);
            DatVe.TabIndex = 7;
            DatVe.Text = "ĐẶT VÉ";
            DatVe.UseCompatibleTextRendering = true;
            DatVe.UseVisualStyleBackColor = false;
            // 
            // PanelChiTietPhim
            // 
            PanelChiTietPhim.Controls.Add(MoTa);
            PanelChiTietPhim.Controls.Add(DienVien);
            PanelChiTietPhim.Controls.Add(TenPhim);
            PanelChiTietPhim.Controls.Add(ThoiLuong);
            PanelChiTietPhim.Controls.Add(DoTuoi);
            PanelChiTietPhim.Controls.Add(QuocGia);
            PanelChiTietPhim.Controls.Add(NgonNgu);
            PanelChiTietPhim.Controls.Add(TheLoai);
            PanelChiTietPhim.Controls.Add(DaoDien);
            PanelChiTietPhim.Controls.Add(PosterPhim);
            PanelChiTietPhim.Controls.Add(label1);
            PanelChiTietPhim.Controls.Add(label8);
            PanelChiTietPhim.Controls.Add(label7);
            PanelChiTietPhim.Controls.Add(label6);
            PanelChiTietPhim.Controls.Add(label5);
            PanelChiTietPhim.Controls.Add(label4);
            PanelChiTietPhim.Controls.Add(label3);
            PanelChiTietPhim.Controls.Add(label2);
            PanelChiTietPhim.Location = new Point(44, 68);
            PanelChiTietPhim.Margin = new Padding(3, 2, 3, 2);
            PanelChiTietPhim.Name = "PanelChiTietPhim";
            PanelChiTietPhim.Size = new Size(1026, 435);
            PanelChiTietPhim.TabIndex = 5;
            // 
            // MoTa
            // 
            MoTa.BackColor = Color.FromArgb(21, 3, 27);
            MoTa.BorderStyle = BorderStyle.None;
            MoTa.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoTa.ForeColor = Color.White;
            MoTa.Location = new Point(446, 325);
            MoTa.Multiline = true;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            MoTa.ScrollBars = ScrollBars.Both;
            MoTa.Size = new Size(565, 107);
            MoTa.TabIndex = 71;
            MoTa.Text = "Konnichiwa";
            // 
            // DienVien
            // 
            DienVien.BackColor = Color.FromArgb(21, 3, 27);
            DienVien.BorderStyle = BorderStyle.None;
            DienVien.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DienVien.ForeColor = Color.White;
            DienVien.Location = new Point(447, 99);
            DienVien.Multiline = true;
            DienVien.Name = "DienVien";
            DienVien.ReadOnly = true;
            DienVien.Size = new Size(565, 58);
            DienVien.TabIndex = 70;
            DienVien.Text = "Konnichiwa";
            // 
            // TenPhim
            // 
            TenPhim.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TenPhim.ForeColor = Color.DarkOrange;
            TenPhim.Location = new Point(281, 0);
            TenPhim.Name = "TenPhim";
            TenPhim.Size = new Size(700, 50);
            TenPhim.TabIndex = 69;
            TenPhim.Text = "NGÀY XƯA CÓ MỘT CHUYỆN TÌNH";
            TenPhim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ThoiLuong
            // 
            ThoiLuong.AutoSize = true;
            ThoiLuong.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThoiLuong.ForeColor = SystemColors.ControlLightLight;
            ThoiLuong.Location = new Point(447, 197);
            ThoiLuong.Name = "ThoiLuong";
            ThoiLuong.Size = new Size(94, 18);
            ThoiLuong.TabIndex = 67;
            ThoiLuong.Text = "Thời lượng: ";
            // 
            // DoTuoi
            // 
            DoTuoi.AutoSize = true;
            DoTuoi.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoTuoi.ForeColor = SystemColors.ControlLightLight;
            DoTuoi.Location = new Point(448, 230);
            DoTuoi.Name = "DoTuoi";
            DoTuoi.Size = new Size(62, 18);
            DoTuoi.TabIndex = 66;
            DoTuoi.Text = "Độ tuổi:";
            // 
            // QuocGia
            // 
            QuocGia.AutoSize = true;
            QuocGia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QuocGia.ForeColor = SystemColors.ControlLightLight;
            QuocGia.Location = new Point(447, 296);
            QuocGia.Name = "QuocGia";
            QuocGia.Size = new Size(79, 18);
            QuocGia.TabIndex = 65;
            QuocGia.Text = "Quốc gia :";
            // 
            // NgonNgu
            // 
            NgonNgu.AutoSize = true;
            NgonNgu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgonNgu.ForeColor = SystemColors.ControlLightLight;
            NgonNgu.Location = new Point(448, 262);
            NgonNgu.Name = "NgonNgu";
            NgonNgu.Size = new Size(81, 18);
            NgonNgu.TabIndex = 64;
            NgonNgu.Text = "Ngôn ngữ:";
            // 
            // TheLoai
            // 
            TheLoai.AutoSize = true;
            TheLoai.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TheLoai.ForeColor = SystemColors.ControlLightLight;
            TheLoai.Location = new Point(448, 166);
            TheLoai.Name = "TheLoai";
            TheLoai.Size = new Size(71, 18);
            TheLoai.TabIndex = 63;
            TheLoai.Text = "Thể loại: ";
            // 
            // DaoDien
            // 
            DaoDien.AutoSize = true;
            DaoDien.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DaoDien.ForeColor = SystemColors.ControlLightLight;
            DaoDien.Location = new Point(446, 67);
            DaoDien.Name = "DaoDien";
            DaoDien.Size = new Size(80, 18);
            DaoDien.TabIndex = 61;
            DaoDien.Text = "Đạo diễn: ";
            // 
            // PosterPhim
            // 
            PosterPhim.Location = new Point(37, 61);
            PosterPhim.Name = "PosterPhim";
            PosterPhim.Size = new Size(242, 322);
            PosterPhim.SizeMode = PictureBoxSizeMode.StretchImage;
            PosterPhim.TabIndex = 60;
            PosterPhim.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(340, 325);
            label1.Name = "label1";
            label1.Size = new Size(51, 18);
            label1.TabIndex = 59;
            label1.Text = "Mô tả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(340, 197);
            label8.Name = "label8";
            label8.Size = new Size(94, 18);
            label8.TabIndex = 58;
            label8.Text = "Thời lượng: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(340, 230);
            label7.Name = "label7";
            label7.Size = new Size(62, 18);
            label7.TabIndex = 57;
            label7.Text = "Độ tuổi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(339, 296);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 56;
            label6.Text = "Quốc gia :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(340, 262);
            label5.Name = "label5";
            label5.Size = new Size(81, 18);
            label5.TabIndex = 55;
            label5.Text = "Ngôn ngữ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(340, 166);
            label4.Name = "label4";
            label4.Size = new Size(71, 18);
            label4.TabIndex = 54;
            label4.Text = "Thể loại: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(339, 99);
            label3.Name = "label3";
            label3.Size = new Size(81, 18);
            label3.TabIndex = 53;
            label3.Text = "Diễn viên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(338, 67);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 52;
            label2.Text = "Đạo diễn: ";
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Controls.Add(TimKiem);
            PanelHeader.Controls.Add(TaiKhoan);
            PanelHeader.Controls.Add(PhimHot);
            PanelHeader.Controls.Add(UuDai);
            PanelHeader.Location = new Point(0, -4);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 80);
            PanelHeader.TabIndex = 5;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(84, 3);
            Logo.Name = "Logo";
            Logo.Size = new Size(83, 77);
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
            TaiKhoan.Size = new Size(139, 42);
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
            // ChiTietPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 3, 27);
            ClientSize = new Size(1114, 693);
            Controls.Add(PanelHeader);
            Controls.Add(PanelChinh);
            Controls.Add(panelDuongDan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChiTietPhim";
            Text = "Solunar Cinema";
            panelDuongDan.ResumeLayout(false);
            panelDuongDan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)House).EndInit();
            PanelChinh.ResumeLayout(false);
            PanelChinh.PerformLayout();
            PanelChiTietPhim.ResumeLayout(false);
            PanelChiTietPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PosterPhim).EndInit();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelDuongDan;
        private PictureBox Poster;
        private Panel PanelChinh;
        private Panel PanelChiTietPhim;
        private TextBox textBox2;
        private Button DatVe;
        private Button Trailer;
        private Button DanhGia;
        private Label NoiDungPhim;
        private Panel PanelHeader;
        private TextBox TimKiem;
        private Button TaiKhoan;
        private Button PhimHot;
        private Button UuDai;
        private Label TenPhim;
        private Label ThoiLuong;
        private Label DoTuoi;
        private Label QuocGia;
        private Label NgonNgu;
        private Label TheLoai;
        private Label DaoDien;
        private PictureBox PosterPhim;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private LinkLabel LinkTrangChuChinh;
        private LinkLabel LinkTenPhim;
        private TextBox DienVien;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem ThongTinTaiKhoan;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private PictureBox House;
        private PictureBox Logo;
        private TextBox MoTa;
    }
}