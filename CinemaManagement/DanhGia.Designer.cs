namespace CinemaManagement
{
    partial class DanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhGia));
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
            panelDuongDan = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            House = new PictureBox();
            LinkTenPhim = new LinkLabel();
            LinkTrangChuChinh = new LinkLabel();
            PanelChinh = new Panel();
            pnlMyStars = new Panel();
            Sao1 = new Button();
            Sao2 = new Button();
            Sao3 = new Button();
            Sao4 = new Button();
            Sao5 = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            Loc = new ComboBox();
            Gui = new Button();
            Xoa = new Button();
            NoiDungDanhGia = new TextBox();
            label1 = new Label();
            pnlReviewSummary = new Panel();
            TongLuotDanhGia = new Label();
            DiemDanhGia = new Label();
            TongSao = new Label();
            PhimDangChieu = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            panelDuongDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)House).BeginInit();
            PanelChinh.SuspendLayout();
            pnlMyStars.SuspendLayout();
            pnlReviewSummary.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            PanelHeader.Size = new Size(1120, 86);
            PanelHeader.TabIndex = 1;
            // 
            // Logo
            // 
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(74, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(83, 75);
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
            // panelDuongDan
            // 
            panelDuongDan.BackColor = Color.LightBlue;
            panelDuongDan.Controls.Add(flowLayoutPanel2);
            panelDuongDan.Controls.Add(flowLayoutPanel1);
            panelDuongDan.Controls.Add(House);
            panelDuongDan.Controls.Add(LinkTenPhim);
            panelDuongDan.Controls.Add(LinkTrangChuChinh);
            panelDuongDan.ForeColor = Color.Transparent;
            panelDuongDan.Location = new Point(0, 81);
            panelDuongDan.Margin = new Padding(3, 2, 3, 2);
            panelDuongDan.Name = "panelDuongDan";
            panelDuongDan.Size = new Size(1137, 53);
            panelDuongDan.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(0, 50);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1188, 564);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1476, 547);
            flowLayoutPanel1.TabIndex = 4;
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
            LinkTenPhim.Size = new Size(167, 18);
            LinkTenPhim.TabIndex = 4;
            LinkTenPhim.TabStop = true;
            LinkTenPhim.Text = "Tên Phim >>  Đánh giá";
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
            // 
            // PanelChinh
            // 
            PanelChinh.BackColor = Color.FromArgb(21, 3, 27);
            PanelChinh.Controls.Add(pnlMyStars);
            PanelChinh.Controls.Add(flowLayoutPanel);
            PanelChinh.Controls.Add(Loc);
            PanelChinh.Controls.Add(Gui);
            PanelChinh.Controls.Add(Xoa);
            PanelChinh.Controls.Add(NoiDungDanhGia);
            PanelChinh.Controls.Add(label1);
            PanelChinh.Controls.Add(pnlReviewSummary);
            PanelChinh.Controls.Add(PhimDangChieu);
            PanelChinh.Location = new Point(-13, 131);
            PanelChinh.Name = "PanelChinh";
            PanelChinh.Size = new Size(1359, 649);
            PanelChinh.TabIndex = 4;
            // 
            // pnlMyStars
            // 
            pnlMyStars.Controls.Add(Sao1);
            pnlMyStars.Controls.Add(Sao2);
            pnlMyStars.Controls.Add(Sao3);
            pnlMyStars.Controls.Add(Sao4);
            pnlMyStars.Controls.Add(Sao5);
            pnlMyStars.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMyStars.Location = new Point(643, 62);
            pnlMyStars.Name = "pnlMyStars";
            pnlMyStars.Size = new Size(388, 87);
            pnlMyStars.TabIndex = 39;
            // 
            // Sao1
            // 
            Sao1.Location = new Point(12, 15);
            Sao1.Name = "Sao1";
            Sao1.Size = new Size(57, 55);
            Sao1.TabIndex = 29;
            Sao1.Text = "button1";
            Sao1.UseVisualStyleBackColor = true;
            // 
            // Sao2
            // 
            Sao2.Location = new Point(84, 15);
            Sao2.Name = "Sao2";
            Sao2.Size = new Size(57, 55);
            Sao2.TabIndex = 30;
            Sao2.Text = "button2";
            Sao2.UseVisualStyleBackColor = true;
            // 
            // Sao3
            // 
            Sao3.Location = new Point(158, 17);
            Sao3.Name = "Sao3";
            Sao3.Size = new Size(57, 55);
            Sao3.TabIndex = 31;
            Sao3.Text = "button3";
            Sao3.UseVisualStyleBackColor = true;
            // 
            // Sao4
            // 
            Sao4.Location = new Point(230, 17);
            Sao4.Name = "Sao4";
            Sao4.Size = new Size(57, 55);
            Sao4.TabIndex = 32;
            Sao4.Text = "button4";
            Sao4.UseVisualStyleBackColor = true;
            // 
            // Sao5
            // 
            Sao5.Location = new Point(304, 17);
            Sao5.Name = "Sao5";
            Sao5.Size = new Size(57, 55);
            Sao5.TabIndex = 33;
            Sao5.Text = "button5";
            Sao5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(55, 168);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(517, 432);
            flowLayoutPanel.TabIndex = 38;
            // 
            // Loc
            // 
            Loc.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loc.FormattingEnabled = true;
            Loc.Location = new Point(407, 126);
            Loc.Name = "Loc";
            Loc.Size = new Size(146, 26);
            Loc.TabIndex = 37;
            Loc.Text = "Lọc theo";
            // 
            // Gui
            // 
            Gui.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Gui.BackColor = Color.FromArgb(230, 57, 70);
            Gui.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gui.ForeColor = SystemColors.Control;
            Gui.Location = new Point(692, 552);
            Gui.Margin = new Padding(3, 2, 3, 2);
            Gui.Name = "Gui";
            Gui.Size = new Size(122, 38);
            Gui.TabIndex = 36;
            Gui.Text = "GỬI";
            Gui.UseCompatibleTextRendering = true;
            Gui.UseVisualStyleBackColor = false;
            // 
            // Xoa
            // 
            Xoa.BackColor = Color.Pink;
            Xoa.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.ForeColor = Color.Maroon;
            Xoa.Location = new Point(893, 553);
            Xoa.Margin = new Padding(3, 2, 3, 2);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(122, 38);
            Xoa.TabIndex = 35;
            Xoa.Text = "XÓA";
            Xoa.UseVisualStyleBackColor = false;
            // 
            // NoiDungDanhGia
            // 
            NoiDungDanhGia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoiDungDanhGia.Location = new Point(601, 154);
            NoiDungDanhGia.Multiline = true;
            NoiDungDanhGia.Name = "NoiDungDanhGia";
            NoiDungDanhGia.Size = new Size(482, 372);
            NoiDungDanhGia.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 212, 59);
            label1.Location = new Point(584, 27);
            label1.Name = "label1";
            label1.Size = new Size(352, 32);
            label1.TabIndex = 28;
            label1.Text = "VIẾT ĐÁNH GIÁ CỦA BẠN";
            // 
            // pnlReviewSummary
            // 
            pnlReviewSummary.Controls.Add(TongLuotDanhGia);
            pnlReviewSummary.Controls.Add(DiemDanhGia);
            pnlReviewSummary.Controls.Add(TongSao);
            pnlReviewSummary.Location = new Point(96, 62);
            pnlReviewSummary.Name = "pnlReviewSummary";
            pnlReviewSummary.Size = new Size(287, 87);
            pnlReviewSummary.TabIndex = 27;
            // 
            // TongLuotDanhGia
            // 
            TongLuotDanhGia.AutoSize = true;
            TongLuotDanhGia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TongLuotDanhGia.ForeColor = SystemColors.ControlLightLight;
            TongLuotDanhGia.Location = new Point(134, 15);
            TongLuotDanhGia.Name = "TongLuotDanhGia";
            TongLuotDanhGia.Size = new Size(141, 18);
            TongLuotDanhGia.TabIndex = 24;
            TongLuotDanhGia.Text = "5003 lượt đánh giá";
            // 
            // DiemDanhGia
            // 
            DiemDanhGia.AutoSize = true;
            DiemDanhGia.Font = new Font("Arial", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DiemDanhGia.ForeColor = Color.FromArgb(255, 128, 0);
            DiemDanhGia.Location = new Point(23, 17);
            DiemDanhGia.Name = "DiemDanhGia";
            DiemDanhGia.Size = new Size(91, 55);
            DiemDanhGia.TabIndex = 23;
            DiemDanhGia.Text = "4.3";
            // 
            // TongSao
            // 
            TongSao.AutoSize = true;
            TongSao.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TongSao.ForeColor = Color.Gold;
            TongSao.Location = new Point(134, 35);
            TongSao.Name = "TongSao";
            TongSao.Size = new Size(109, 35);
            TongSao.TabIndex = 25;
            TongSao.Text = "⭐⭐⭐⭐✰";
            // 
            // PhimDangChieu
            // 
            PhimDangChieu.AutoSize = true;
            PhimDangChieu.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhimDangChieu.ForeColor = Color.FromArgb(255, 212, 59);
            PhimDangChieu.Location = new Point(87, 27);
            PhimDangChieu.Name = "PhimDangChieu";
            PhimDangChieu.Size = new Size(224, 32);
            PhimDangChieu.TabIndex = 22;
            PhimDangChieu.Text = "ĐÁNH GIÁ PHIM";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            contextMenuStrip1.Name = "MenuTaiKhoan";
            contextMenuStrip1.Size = new Size(240, 88);
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
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.FromArgb(247, 201, 201);
            toolStripMenuItem2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = Color.FromArgb(92, 77, 68);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(239, 28);
            toolStripMenuItem2.Text = "Vé đã đặt";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = Color.FromArgb(255, 235, 235);
            toolStripMenuItem3.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem3.ForeColor = Color.FromArgb(92, 77, 68);
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(239, 28);
            toolStripMenuItem3.Text = "Đăng xuất";
            // 
            // DanhGia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 745);
            Controls.Add(PanelChinh);
            Controls.Add(panelDuongDan);
            Controls.Add(PanelHeader);
            Name = "DanhGia";
            Text = "DanhGia";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            panelDuongDan.ResumeLayout(false);
            panelDuongDan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)House).EndInit();
            PanelChinh.ResumeLayout(false);
            PanelChinh.PerformLayout();
            pnlMyStars.ResumeLayout(false);
            pnlReviewSummary.ResumeLayout(false);
            pnlReviewSummary.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelHeader;
        private PictureBox Logo;
        private TextBox TimKiem;
        private Button TaiKhoan;
        private Button PhimHot;
        private Button UuDai;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem ThongTinTaiKhoan;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private Panel panelDuongDan;
        private PictureBox House;
        private LinkLabel LinkTenPhim;
        private LinkLabel LinkTrangChuChinh;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel PanelChinh;
        private Label PhimDangChieu;
        private Panel pnlReviewSummary;
        private Label TongLuotDanhGia;
        private Label DiemDanhGia;
        private Label TongSao;
        private TextBox NoiDungDanhGia;
        private Button Sao5;
        private Button Sao4;
        private Button Sao3;
        private Button Sao2;
        private Button Sao1;
        private Label label1;
        private Button Xoa;
        private Button Gui;
        private ComboBox Loc;
        private FlowLayoutPanel flowLayoutPanel;
        private Panel pnlMyStars;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}