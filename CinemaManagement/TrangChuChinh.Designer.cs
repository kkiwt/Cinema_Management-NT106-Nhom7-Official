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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuChinh));
            PanelHeader = new Panel();
            pictureBox1 = new PictureBox();
            TimKiem = new TextBox();
            TaiKhoan = new Button();
            MenuTaiKhoan = new ContextMenuStrip(components);
            ThongTinTaiKhoan = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            PhimHot = new Button();
            UuDai = new Button();
            PanelDuongDan = new Panel();
            House = new PictureBox();
            LinkTrangChuChinh = new LinkLabel();
            PanelChinh = new Panel();
            Trang = new Label();
            BangPhim = new FlowLayoutPanel();
            PhimDangChieu = new Label();
            Next = new Button();
            Prev = new Button();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            PanelDuongDan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)House).BeginInit();
            PanelChinh.SuspendLayout();
            SuspendLayout();
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(pictureBox1);
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            // PanelDuongDan
            // 
            PanelDuongDan.BackColor = Color.LightBlue;
            PanelDuongDan.Controls.Add(House);
            PanelDuongDan.Controls.Add(LinkTrangChuChinh);
            PanelDuongDan.ForeColor = Color.Transparent;
            PanelDuongDan.Location = new Point(0, 76);
            PanelDuongDan.Margin = new Padding(3, 2, 3, 2);
            PanelDuongDan.Name = "PanelDuongDan";
            PanelDuongDan.Size = new Size(1117, 49);
            PanelDuongDan.TabIndex = 1;
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
            LinkTrangChuChinh.Size = new Size(114, 18);
            LinkTrangChuChinh.TabIndex = 0;
            LinkTrangChuChinh.TabStop = true;
            LinkTrangChuChinh.Text = "Trang chủ chính";
            LinkTrangChuChinh.LinkClicked += LinkTrangChuChinh_LinkClicked;
            // 
            // PanelChinh
            // 
            PanelChinh.Controls.Add(Trang);
            PanelChinh.Controls.Add(BangPhim);
            PanelChinh.Controls.Add(PhimDangChieu);
            PanelChinh.Controls.Add(Next);
            PanelChinh.Controls.Add(Prev);
            PanelChinh.Location = new Point(0, 120);
            PanelChinh.Margin = new Padding(3, 2, 3, 2);
            PanelChinh.Name = "PanelChinh";
            PanelChinh.Size = new Size(1117, 528);
            PanelChinh.TabIndex = 3;
            // 
            // Trang
            // 
            Trang.AutoSize = true;
            Trang.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Trang.ForeColor = SystemColors.Control;
            Trang.Location = new Point(496, 492);
            Trang.Name = "Trang";
            Trang.Size = new Size(68, 22);
            Trang.TabIndex = 24;
            Trang.Text = "Trang: ";
            // 
            // BangPhim
            // 
            BangPhim.Location = new Point(103, 67);
            BangPhim.Margin = new Padding(3, 2, 3, 2);
            BangPhim.Name = "BangPhim";
            BangPhim.Size = new Size(934, 423);
            BangPhim.TabIndex = 23;
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
            Next.Location = new Point(1043, 208);
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
            Prev.Location = new Point(21, 208);
            Prev.Margin = new Padding(3, 2, 3, 2);
            Prev.Name = "Prev";
            Prev.Size = new Size(53, 74);
            Prev.TabIndex = 19;
            Prev.Text = "<";
            Prev.UseVisualStyleBackColor = false;
            Prev.Click += Prev_Click;
            // 
            // TrangChuChinh
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 3, 27);
            ClientSize = new Size(1117, 643);
            Controls.Add(PanelChinh);
            Controls.Add(PanelDuongDan);
            Controls.Add(PanelHeader);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TrangChuChinh";
            Text = "Solunar Cinema";
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            PanelDuongDan.ResumeLayout(false);
            PanelDuongDan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)House).EndInit();
            PanelChinh.ResumeLayout(false);
            PanelChinh.PerformLayout();
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
        private Panel PanelChinh;
        private Button Prev;
        private Button Next;
        private TextBox TimKiem;
        private Label PhimDangChieu;
        private Label Trang;
        private FlowLayoutPanel BangPhim;
        private LinkLabel LinkTrangChuChinh;
        private PictureBox House;
        private PictureBox pictureBox1;
    }
}
