namespace CinemaManagement
{
    partial class PhanDanhSachPhim
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
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            dataGridView1 = new DataGridView();
            IdPhim = new DataGridViewTextBoxColumn();
            TenPhim = new DataGridViewTextBoxColumn();
            ChieuTu = new DataGridViewTextBoxColumn();
            DenNgay = new DataGridViewTextBoxColumn();
            NutQuayLai = new MaterialSkin.Controls.MaterialButton();
            NutReload = new ReaLTaiizor.Controls.AirButton();
            NutXoaPhim = new ReaLTaiizor.Controls.AirButton();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            parrotGradientPanel1.Location = new Point(3, 0);
            parrotGradientPanel1.Margin = new Padding(2);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            parrotGradientPanel1.PrimerColor = Color.IndianRed;
            parrotGradientPanel1.Size = new Size(896, 78);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 7;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.FromArgb(0, 0, 64);
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(181, 18);
            bigLabel1.Margin = new Padding(2, 0, 2, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(569, 43);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Solunar Cinema Management System";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Noto Sans SC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.White;
            bigLabel3.Location = new Point(254, 90);
            bigLabel3.Margin = new Padding(2, 0, 2, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(363, 32);
            bigLabel3.TabIndex = 49;
            bigLabel3.Text = "Danh Sách Các Phim Đang Chiếu";
            bigLabel3.Click += bigLabel3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdPhim, TenPhim, ChieuTu, DenNgay });
            dataGridView1.Location = new Point(30, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(827, 299);
            dataGridView1.TabIndex = 50;
            // 
            // IdPhim
            // 
            IdPhim.HeaderText = "ID Phim";
            IdPhim.Name = "IdPhim";
            IdPhim.ReadOnly = true;
            // 
            // TenPhim
            // 
            TenPhim.FillWeight = 200F;
            TenPhim.HeaderText = "Tên Phim";
            TenPhim.Name = "TenPhim";
            TenPhim.ReadOnly = true;
            // 
            // ChieuTu
            // 
            ChieuTu.HeaderText = "Chiếu Từ";
            ChieuTu.Name = "ChieuTu";
            ChieuTu.ReadOnly = true;
            // 
            // DenNgay
            // 
            DenNgay.HeaderText = "Đến Ngày";
            DenNgay.Name = "DenNgay";
            DenNgay.ReadOnly = true;
            // 
            // NutQuayLai
            // 
            NutQuayLai.Anchor = AnchorStyles.None;
            NutQuayLai.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NutQuayLai.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            NutQuayLai.Depth = 0;
            NutQuayLai.Font = new Font("Noto Sans SC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutQuayLai.HighEmphasis = true;
            NutQuayLai.Icon = null;
            NutQuayLai.Location = new Point(754, 86);
            NutQuayLai.Margin = new Padding(4, 6, 4, 6);
            NutQuayLai.MouseState = MaterialSkin.MouseState.HOVER;
            NutQuayLai.Name = "NutQuayLai";
            NutQuayLai.NoAccentTextColor = Color.Empty;
            NutQuayLai.Size = new Size(85, 36);
            NutQuayLai.TabIndex = 51;
            NutQuayLai.Text = "Quay Lại";
            NutQuayLai.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            NutQuayLai.UseAccentColor = false;
            NutQuayLai.UseVisualStyleBackColor = true;
            NutQuayLai.Click += NutQuayLai_Click;
            // 
            // NutReload
            // 
            NutReload.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            NutReload.Font = new Font("Segoe UI", 9F);
            NutReload.Image = null;
            NutReload.Location = new Point(642, 90);
            NutReload.Name = "NutReload";
            NutReload.NoRounding = false;
            NutReload.Size = new Size(82, 30);
            NutReload.TabIndex = 53;
            NutReload.Text = "Reload";
            NutReload.Transparent = false;
            NutReload.Click += NutReload_Click;
            // 
            // NutXoaPhim
            // 
            NutXoaPhim.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            NutXoaPhim.Font = new Font("Segoe UI", 9F);
            NutXoaPhim.Image = null;
            NutXoaPhim.Location = new Point(76, 92);
            NutXoaPhim.Name = "NutXoaPhim";
            NutXoaPhim.NoRounding = false;
            NutXoaPhim.Size = new Size(133, 30);
            NutXoaPhim.TabIndex = 54;
            NutXoaPhim.Text = "Xoá Phim Được Chọn";
            NutXoaPhim.Transparent = true;
            NutXoaPhim.Click += NutXoaPhim_Click;
            // 
            // PhanDanhSachPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(897, 450);
            Controls.Add(NutXoaPhim);
            Controls.Add(NutReload);
            Controls.Add(NutQuayLai);
            Controls.Add(dataGridView1);
            Controls.Add(bigLabel3);
            Controls.Add(parrotGradientPanel1);
            Name = "PhanDanhSachPhim";
            Text = "Danh Sách Các Phim Đang Chiếu";
            Load += PhanDanhSachPhim_Load;
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton NutQuayLai;
        private DataGridViewTextBoxColumn IdPhim;
        private DataGridViewTextBoxColumn TenPhim;
        private DataGridViewTextBoxColumn ChieuTu;
        private DataGridViewTextBoxColumn DenNgay;
        private ReaLTaiizor.Controls.AirButton NutReload;
        private ReaLTaiizor.Controls.AirButton NutXoaPhim;
    }
}