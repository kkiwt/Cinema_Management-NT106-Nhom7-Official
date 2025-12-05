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
            PanelHeader = new Panel();
            Logo = new PictureBox();
            lbDanhSach = new Label();
            dataGridViewDanhSach = new DataGridView();
            ColTenUuDai = new DataGridViewTextBoxColumn();
            ColThoiGian = new DataGridViewTextBoxColumn();
            ColGiamGia = new DataGridViewTextBoxColumn();
            label1 = new Label();
            NutQuayLai = new MaterialSkin.Controls.MaterialButton();
            MenuTaiKhoan.SuspendLayout();
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
            // PanelHeader
            // 
            PanelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Controls.Add(lbDanhSach);
            PanelHeader.Location = new Point(-1, 2);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 129);
            PanelHeader.TabIndex = 3;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.Picture1;
            Logo.Location = new Point(59, 2);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(145, 115);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // lbDanhSach
            // 
            lbDanhSach.AutoSize = true;
            lbDanhSach.Font = new Font("Epilogue Black", 27.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDanhSach.ForeColor = SystemColors.Control;
            lbDanhSach.Location = new Point(341, 39);
            lbDanhSach.Name = "lbDanhSach";
            lbDanhSach.Size = new Size(460, 54);
            lbDanhSach.TabIndex = 5;
            lbDanhSach.Text = "DANH SÁCH MÃ ƯU ĐÃI";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 152);
            label1.Name = "label1";
            label1.Size = new Size(288, 25);
            label1.TabIndex = 7;
            label1.Text = "Các mã giảm giá còn hiệu lực:";
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
            NutQuayLai.Location = new Point(935, 139);
            NutQuayLai.Margin = new Padding(4, 6, 4, 6);
            NutQuayLai.MouseState = MaterialSkin.MouseState.HOVER;
            NutQuayLai.Name = "NutQuayLai";
            NutQuayLai.NoAccentTextColor = Color.Empty;
            NutQuayLai.Size = new Size(85, 36);
            NutQuayLai.TabIndex = 10;
            NutQuayLai.Text = "Quay Lại";
            NutQuayLai.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            NutQuayLai.UseAccentColor = false;
            NutQuayLai.UseVisualStyleBackColor = true;
            NutQuayLai.Click += NutQuayLai_Click;
            // 
            // DanhSachUuDai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1115, 597);
            Controls.Add(NutQuayLai);
            Controls.Add(label1);
            Controls.Add(dataGridViewDanhSach);
            Controls.Add(PanelHeader);
            Name = "DanhSachUuDai";
            Text = "DanhSachUuDai";
            Load += DanhSachUuDai_Load;
            MenuTaiKhoan.ResumeLayout(false);
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
        private Panel PanelHeader;
        private PictureBox Logo;
        private Label lbDanhSach;
        private DataGridView dataGridViewDanhSach;
        private DataGridViewTextBoxColumn ColTenUuDai;
        private DataGridViewTextBoxColumn ColThoiGian;
        private DataGridViewTextBoxColumn ColGiamGia;
        private Label label1;
        private MaterialSkin.Controls.MaterialButton NutQuayLai;
    }
}