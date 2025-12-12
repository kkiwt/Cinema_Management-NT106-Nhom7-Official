namespace CinemaManagement
{
    partial class PhanLichSu
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            BangLichSu = new DataGridView();
            MaKH = new DataGridViewTextBoxColumn();
            TenKH = new DataGridViewTextBoxColumn();
            TenPhim = new DataGridViewTextBoxColumn();
            Ghe = new DataGridViewTextBoxColumn();
            PhongChieu = new DataGridViewTextBoxColumn();
            TenBapNuoc = new DataGridViewTextBoxColumn();
            NgayDat = new DataGridViewTextBoxColumn();
            GioBatDau = new DataGridViewTextBoxColumn();
            TimTenKH = new TextBox();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            NutReload = new ReaLTaiizor.Controls.AirButton();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BangLichSu).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(195, 22);
            bigLabel1.Margin = new Padding(2, 0, 2, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(569, 43);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Solunar Cinema Management System";
            // 
            // parrotGradientPanel1
            // 
            parrotGradientPanel1.BackgroundImageLayout = ImageLayout.None;
            parrotGradientPanel1.BorderStyle = BorderStyle.FixedSingle;
            parrotGradientPanel1.BottomLeft = Color.Black;
            parrotGradientPanel1.BottomRight = Color.Purple;
            parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.GammaCorrected;
            parrotGradientPanel1.Controls.Add(bigLabel1);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            parrotGradientPanel1.Location = new Point(1, 0);
            parrotGradientPanel1.Margin = new Padding(2);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            parrotGradientPanel1.PrimerColor = Color.IndianRed;
            parrotGradientPanel1.Size = new Size(915, 78);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 6;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.FromArgb(0, 0, 64);
            parrotGradientPanel1.Paint += parrotGradientPanel1_Paint;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Noto Sans SC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.White;
            bigLabel3.Location = new Point(255, 92);
            bigLabel3.Margin = new Padding(2, 0, 2, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(427, 32);
            bigLabel3.TabIndex = 48;
            bigLabel3.Text = "Lịch Sử Các Vé Đã Đặt Của Khách Hàng";
            // 
            // BangLichSu
            // 
            BangLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BangLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BangLichSu.Columns.AddRange(new DataGridViewColumn[] { MaKH, TenKH, TenPhim, Ghe, PhongChieu, TenBapNuoc, NgayDat, GioBatDau });
            BangLichSu.Location = new Point(12, 143);
            BangLichSu.Name = "BangLichSu";
            BangLichSu.Size = new Size(901, 303);
            BangLichSu.TabIndex = 49;
            // 
            // MaKH
            // 
            MaKH.HeaderText = "Mã Khách Hàng";
            MaKH.Name = "MaKH";
            MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            TenKH.FillWeight = 130F;
            TenKH.HeaderText = "Tên Khách Hàng";
            TenKH.Name = "TenKH";
            TenKH.ReadOnly = true;
            // 
            // TenPhim
            // 
            TenPhim.FillWeight = 150F;
            TenPhim.HeaderText = "Tên Phim Đã Đặt";
            TenPhim.Name = "TenPhim";
            TenPhim.ReadOnly = true;
            // 
            // Ghe
            // 
            Ghe.FillWeight = 70F;
            Ghe.HeaderText = "Ghế";
            Ghe.Name = "Ghe";
            Ghe.ReadOnly = true;
            // 
            // PhongChieu
            // 
            PhongChieu.FillWeight = 90F;
            PhongChieu.HeaderText = "Phòng Chiếu";
            PhongChieu.Name = "PhongChieu";
            PhongChieu.ReadOnly = true;
            // 
            // TenBapNuoc
            // 
            TenBapNuoc.HeaderText = "Bắp Nước";
            TenBapNuoc.Name = "TenBapNuoc";
            TenBapNuoc.ReadOnly = true;
            // 
            // NgayDat
            // 
            NgayDat.HeaderText = "Ngày Đặt";
            NgayDat.Name = "NgayDat";
            NgayDat.ReadOnly = true;
            // 
            // GioBatDau
            // 
            GioBatDau.HeaderText = "Giờ Bắt Đầu";
            GioBatDau.Name = "GioBatDau";
            GioBatDau.ReadOnly = true;
            // 
            // TimTenKH
            // 
            TimTenKH.Location = new Point(37, 102);
            TimTenKH.Name = "TimTenKH";
            TimTenKH.Size = new Size(198, 23);
            TimTenKH.TabIndex = 50;
            TimTenKH.Text = "Tìm Tên KH";
            TimTenKH.TextChanged += TimTenKH_TextChanged;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.None;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Noto Sans SC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(789, 92);
            materialButton1.Margin = new Padding(3, 4, 3, 4);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(85, 36);
            materialButton1.TabIndex = 51;
            materialButton1.Text = "Quay Lại";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += NutQuayLai_Click;
            // 
            // NutReload
            // 
            NutReload.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            NutReload.Font = new Font("Segoe UI", 9F);
            NutReload.Image = null;
            NutReload.Location = new Point(687, 95);
            NutReload.Name = "NutReload";
            NutReload.NoRounding = false;
            NutReload.Size = new Size(82, 30);
            NutReload.TabIndex = 52;
            NutReload.Text = "Reload";
            NutReload.Transparent = false;
            NutReload.Click += NutReload_Click;
            // 
            // PhanLichSu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(914, 458);
            Controls.Add(NutReload);
            Controls.Add(materialButton1);
            Controls.Add(TimTenKH);
            Controls.Add(BangLichSu);
            Controls.Add(bigLabel3);
            Controls.Add(parrotGradientPanel1);
            Name = "PhanLichSu";
            Text = "PhanLichSu";
            Load += PhanLichSu_Load;
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BangLichSu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private DataGridView BangLichSu;
        private TextBox TimTenKH;
        private DataGridViewTextBoxColumn MaKH;
        private DataGridViewTextBoxColumn TenKH;
        private DataGridViewTextBoxColumn TenPhim;
        private DataGridViewTextBoxColumn Ghe;
        private DataGridViewTextBoxColumn PhongChieu;
        private DataGridViewTextBoxColumn TenBapNuoc;
        private DataGridViewTextBoxColumn NgayDat;
        private DataGridViewTextBoxColumn GioBatDau;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.AirButton NutReload;
    }
}