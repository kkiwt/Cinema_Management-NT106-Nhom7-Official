namespace CinemaManagement
{
    partial class DanhSachUuDai
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MenuTaiKhoan = new ContextMenuStrip(components);
            ThongTinTaiKhoan_Click = new ToolStripMenuItem();
            VeDaDat = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            PanelDuongDan = new Panel();
            DuongDanTaiKhoan = new Label();
            label1 = new Label();
            DuongDanThongTinTaiKhoan = new Label();
            DuongDanTrangChu = new Label();
            PanelHeader = new Panel();
            Logo = new PictureBox();
            TimKiem = new TextBox();
            TaiKhoan = new Button();
            UuDai = new Button();
            PhimHot = new Button();
            lbDanhSach = new Label();
            dataGridViewDanhSach = new DataGridView();
            ColTenUuDai = new DataGridViewTextBoxColumn();
            ColThoiGian = new DataGridViewTextBoxColumn();
            ColGiamGia = new DataGridViewTextBoxColumn();
            MenuTaiKhoan.SuspendLayout();
            PanelDuongDan.SuspendLayout();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDanhSach).BeginInit();
            SuspendLayout();
            // 
            // MenuTaiKhoan
            // 
            MenuTaiKhoan.ImageScalingSize = new Size(20, 20);
            MenuTaiKhoan.Items.AddRange(new ToolStripItem[] { ThongTinTaiKhoan_Click, VeDaDat, DangXuat });
            MenuTaiKhoan.Name = "MenuTaiKhoan";
            MenuTaiKhoan.Size = new Size(240, 88);
            // 
            // ThongTinTaiKhoan_Click
            // 
            ThongTinTaiKhoan_Click.BackColor = Color.FromArgb(255, 235, 235);
            ThongTinTaiKhoan_Click.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThongTinTaiKhoan_Click.ForeColor = Color.FromArgb(92, 77, 68);
            ThongTinTaiKhoan_Click.Name = "ThongTinTaiKhoan_Click";
            ThongTinTaiKhoan_Click.Size = new Size(239, 28);
            ThongTinTaiKhoan_Click.Text = "Thông tin tài khoản ";
            ThongTinTaiKhoan_Click.Click += toolStripMenuItem1_Click;
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
            // PanelDuongDan
            // 
            PanelDuongDan.BackColor = Color.LightBlue;
            PanelDuongDan.Controls.Add(DuongDanTaiKhoan);
            PanelDuongDan.Controls.Add(label1);
            PanelDuongDan.Controls.Add(DuongDanThongTinTaiKhoan);
            PanelDuongDan.Controls.Add(DuongDanTrangChu);
            PanelDuongDan.ForeColor = Color.Transparent;
            PanelDuongDan.Location = new Point(-1, 78);
            PanelDuongDan.Margin = new Padding(3, 2, 3, 2);
            PanelDuongDan.Name = "PanelDuongDan";
            PanelDuongDan.Size = new Size(1117, 39);
            PanelDuongDan.TabIndex = 4;
            // 
            // DuongDanTaiKhoan
            // 
            DuongDanTaiKhoan.AutoSize = true;
            DuongDanTaiKhoan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanTaiKhoan.ForeColor = Color.Navy;
            DuongDanTaiKhoan.Location = new Point(147, 12);
            DuongDanTaiKhoan.Name = "DuongDanTaiKhoan";
            DuongDanTaiKhoan.Size = new Size(59, 18);
            DuongDanTaiKhoan.TabIndex = 3;
            DuongDanTaiKhoan.Text = "Ưu Đãi";
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
            // 
            // DuongDanThongTinTaiKhoan
            // 
            DuongDanThongTinTaiKhoan.AutoSize = true;
            DuongDanThongTinTaiKhoan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanThongTinTaiKhoan.ForeColor = Color.Navy;
            DuongDanThongTinTaiKhoan.Location = new Point(248, 12);
            DuongDanThongTinTaiKhoan.Name = "DuongDanThongTinTaiKhoan";
            DuongDanThongTinTaiKhoan.Size = new Size(0, 18);
            DuongDanThongTinTaiKhoan.TabIndex = 4;
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
            // PanelHeader
            // 
            PanelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Controls.Add(TimKiem);
            PanelHeader.Controls.Add(TaiKhoan);
            PanelHeader.Controls.Add(UuDai);
            PanelHeader.Controls.Add(PhimHot);
            PanelHeader.Location = new Point(-1, 2);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 78);
            PanelHeader.TabIndex = 3;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Picture1;
            Logo.Location = new Point(107, 0);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(77, 76);
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
            TimKiem.Size = new Size(182, 26);
            TimKiem.TabIndex = 3;
            TimKiem.Text = "Tìm kiếm phim";
            TimKiem.TextChanged += TimKiem_TextChanged;
            // 
            // TaiKhoan
            // 
            TaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TaiKhoan.BackColor = Color.FromArgb(255, 87, 87);
            TaiKhoan.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaiKhoan.ForeColor = SystemColors.Control;
            TaiKhoan.Location = new Point(939, 18);
            TaiKhoan.Margin = new Padding(3, 2, 3, 2);
            TaiKhoan.Name = "TaiKhoan";
            TaiKhoan.Size = new Size(143, 42);
            TaiKhoan.TabIndex = 1;
            TaiKhoan.Text = "TÀI KHOẢN";
            TaiKhoan.UseVisualStyleBackColor = false;
            TaiKhoan.Click += TaiKhoan_Click;
            // 
            // UuDai
            // 
            UuDai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UuDai.BackColor = Color.FromArgb(230, 57, 70);
            UuDai.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UuDai.ForeColor = SystemColors.Control;
            UuDai.Location = new Point(769, 17);
            UuDai.Margin = new Padding(3, 2, 3, 2);
            UuDai.Name = "UuDai";
            UuDai.Size = new Size(137, 42);
            UuDai.TabIndex = 1;
            UuDai.Text = "ƯU ĐÃI";
            UuDai.UseVisualStyleBackColor = false;
            UuDai.Click += UuDai_Click;
            // 
            // PhimHot
            // 
            PhimHot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PhimHot.BackColor = Color.FromArgb(230, 57, 70);
            PhimHot.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhimHot.ForeColor = SystemColors.Control;
            PhimHot.Location = new Point(597, 18);
            PhimHot.Margin = new Padding(3, 2, 3, 2);
            PhimHot.Name = "PhimHot";
            PhimHot.Size = new Size(135, 42);
            PhimHot.TabIndex = 1;
            PhimHot.Text = "PHIM HOT";
            PhimHot.UseVisualStyleBackColor = false;
            // 
            // lbDanhSach
            // 
            lbDanhSach.AutoSize = true;
            lbDanhSach.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDanhSach.ForeColor = SystemColors.Control;
            lbDanhSach.Location = new Point(46, 136);
            lbDanhSach.Name = "lbDanhSach";
            lbDanhSach.Size = new Size(191, 26);
            lbDanhSach.TabIndex = 5;
            lbDanhSach.Text = "DANH SÁCH ƯU ĐÃI";
            // 
            // dataGridViewDanhSach
            // 
            dataGridViewDanhSach.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDanhSach.Columns.AddRange(new DataGridViewColumn[] { ColTenUuDai, ColThoiGian, ColGiamGia });
            dataGridViewDanhSach.EnableHeadersVisualStyles = false;
            dataGridViewDanhSach.Location = new Point(40, 180);
            dataGridViewDanhSach.Name = "dataGridViewDanhSach";
            dataGridViewDanhSach.RowHeadersVisible = false;
            dataGridViewDanhSach.Size = new Size(990, 367);
            dataGridViewDanhSach.TabIndex = 6;
            dataGridViewDanhSach.CellContentClick += dataGridViewDanhSach_CellContentClick;
            // 
            // ColTenUuDai
            // 
            ColTenUuDai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColTenUuDai.HeaderText = "TÊN ƯU ĐÃI";
            ColTenUuDai.Name = "ColTenUuDai";
            // 
            // ColThoiGian
            // 
            ColThoiGian.HeaderText = "THỜI GIAN";
            ColThoiGian.Name = "ColThoiGian";
            // 
            // ColGiamGia
            // 
            ColGiamGia.HeaderText = "GIẢM GIÁ";
            ColGiamGia.Name = "ColGiamGia";
            // 
            // DanhSachUuDai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1115, 644);
            Controls.Add(dataGridViewDanhSach);
            Controls.Add(lbDanhSach);
            Controls.Add(PanelDuongDan);
            Controls.Add(PanelHeader);
            Name = "DanhSachUuDai";
            Text = "DanhSachUuDai";
            Load += DanhSachUuDai_Load;
            MenuTaiKhoan.ResumeLayout(false);
            PanelDuongDan.ResumeLayout(false);
            PanelDuongDan.PerformLayout();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDanhSach).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem ThongTinTaiKhoan_Click;
        private ToolStripMenuItem VeDaDat;
        private ToolStripMenuItem DangXuat;
        private Panel PanelDuongDan;
        private Label DuongDanTaiKhoan;
        private Label label1;
        private Label DuongDanThongTinTaiKhoan;
        private Label DuongDanTrangChu;
        private Panel PanelHeader;
        private PictureBox Logo;
        private TextBox TimKiem;
        private Button TaiKhoan;
        private Button PhimHot;
        private Button UuDai;
        private Label lbDanhSach;
        private DataGridView dataGridViewDanhSach;
        private DataGridViewTextBoxColumn ColTenUuDai;
        private DataGridViewTextBoxColumn ColThoiGian;
        private DataGridViewTextBoxColumn ColGiamGia;
    }
}