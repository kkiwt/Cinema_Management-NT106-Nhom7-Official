namespace CinemaManagement
{
    partial class StaffOnLy
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
            TreeNode treeNode1 = new TreeNode("Số Lượng Vé Đã Bán Ra:");
            TreeNode treeNode2 = new TreeNode("Phim:");
            TreeNode treeNode3 = new TreeNode("Bắp Nước:");
            TreeNode treeNode4 = new TreeNode("Tổng Doanh Thu Của Rạp", new TreeNode[] { treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Số Phim Đang Chiếu:");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffOnLy));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            ThongKeVeDoanhThu = new TreeView();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            bindingSource1 = new BindingSource(components);
            NutThemPhim = new ReaLTaiizor.Controls.HopeButton();
            NutThemUuDai = new ReaLTaiizor.Controls.HopeButton();
            NutQuayLai = new MaterialSkin.Controls.MaterialButton();
            NutLichSu = new ReaLTaiizor.Controls.HopeButton();
            NutXemDanhSachPhim = new ReaLTaiizor.Controls.HopeButton();
            parrotGradientPanel1.SuspendLayout();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Epilogue", 13.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(227, 26);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(595, 71);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Solunar Cinema Management System";
            bigLabel1.Click += bigLabel1_Click;
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
            parrotGradientPanel1.Location = new Point(-2, -1);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            parrotGradientPanel1.PrimerColor = Color.IndianRed;
            parrotGradientPanel1.Size = new Size(956, 109);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 3;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.FromArgb(0, 0, 64);
            // 
            // ThongKeVeDoanhThu
            // 
            ThongKeVeDoanhThu.BackColor = Color.OldLace;
            ThongKeVeDoanhThu.Font = new Font("Epilogue", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThongKeVeDoanhThu.ForeColor = Color.IndianRed;
            ThongKeVeDoanhThu.Location = new Point(16, 16);
            ThongKeVeDoanhThu.Name = "ThongKeVeDoanhThu";
            treeNode1.Name = "SoLuongVeRoot";
            treeNode1.Text = "Số Lượng Vé Đã Bán Ra:";
            treeNode2.Name = "NodePhim";
            treeNode2.Text = "Phim:";
            treeNode3.Name = "NodeBapNuoc";
            treeNode3.Text = "Bắp Nước:";
            treeNode4.Name = "DoanhThuRoot";
            treeNode4.Text = "Tổng Doanh Thu Của Rạp";
            treeNode5.Name = "RootSoPhim";
            treeNode5.Text = "Số Phim Đang Chiếu:";
            ThongKeVeDoanhThu.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode4, treeNode5 });
            ThongKeVeDoanhThu.Size = new Size(851, 271);
            ThongKeVeDoanhThu.TabIndex = 0;
            ThongKeVeDoanhThu.AfterSelect += treeView1_AfterSelect_1;
            // 
            // metroPanel1
            // 
            metroPanel1.BackgroundImage = (Image)resources.GetObject("metroPanel1.BackgroundImage");
            metroPanel1.Controls.Add(ThongKeVeDoanhThu);
            metroPanel1.CustomBackground = false;
            metroPanel1.ForeColor = Color.Transparent;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(32, 127);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(887, 306);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 4;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // NutThemPhim
            // 
            NutThemPhim.BorderColor = Color.FromArgb(220, 223, 230);
            NutThemPhim.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            NutThemPhim.DangerColor = Color.FromArgb(245, 108, 108);
            NutThemPhim.DefaultColor = Color.FromArgb(255, 255, 255);
            NutThemPhim.Font = new Font("Segoe UI", 12F);
            NutThemPhim.HoverTextColor = Color.FromArgb(48, 49, 51);
            NutThemPhim.InfoColor = Color.FromArgb(144, 147, 153);
            NutThemPhim.Location = new Point(226, 439);
            NutThemPhim.Name = "NutThemPhim";
            NutThemPhim.PrimaryColor = Color.SlateBlue;
            NutThemPhim.Size = new Size(142, 61);
            NutThemPhim.SuccessColor = Color.FromArgb(103, 194, 58);
            NutThemPhim.TabIndex = 6;
            NutThemPhim.Text = "Thêm Phim";
            NutThemPhim.TextColor = Color.White;
            NutThemPhim.WarningColor = Color.FromArgb(230, 162, 60);
            NutThemPhim.Click += ThemPhim_Click;
            // 
            // NutThemUuDai
            // 
            NutThemUuDai.BorderColor = Color.FromArgb(220, 223, 230);
            NutThemUuDai.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            NutThemUuDai.DangerColor = Color.FromArgb(245, 108, 108);
            NutThemUuDai.DefaultColor = Color.FromArgb(255, 255, 255);
            NutThemUuDai.Font = new Font("Segoe UI", 12F);
            NutThemUuDai.HoverTextColor = Color.FromArgb(48, 49, 51);
            NutThemUuDai.InfoColor = Color.FromArgb(144, 147, 153);
            NutThemUuDai.Location = new Point(411, 439);
            NutThemUuDai.Name = "NutThemUuDai";
            NutThemUuDai.PrimaryColor = Color.SlateBlue;
            NutThemUuDai.Size = new Size(142, 61);
            NutThemUuDai.SuccessColor = Color.FromArgb(103, 194, 58);
            NutThemUuDai.TabIndex = 7;
            NutThemUuDai.Text = "Thêm Ưu Đãi";
            NutThemUuDai.TextColor = Color.White;
            NutThemUuDai.WarningColor = Color.FromArgb(230, 162, 60);
            NutThemUuDai.Click += NutThemUuDai_Click;
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
            NutQuayLai.Location = new Point(814, 454);
            NutQuayLai.Margin = new Padding(4, 6, 4, 6);
            NutQuayLai.MouseState = MaterialSkin.MouseState.HOVER;
            NutQuayLai.Name = "NutQuayLai";
            NutQuayLai.NoAccentTextColor = Color.Empty;
            NutQuayLai.Size = new Size(85, 36);
            NutQuayLai.TabIndex = 5;
            NutQuayLai.Text = "Quay Lại";
            NutQuayLai.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            NutQuayLai.UseAccentColor = false;
            NutQuayLai.UseVisualStyleBackColor = true;
            NutQuayLai.Click += NutQuayLai_Click;
            // 
            // NutLichSu
            // 
            NutLichSu.BorderColor = Color.FromArgb(220, 223, 230);
            NutLichSu.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            NutLichSu.DangerColor = Color.FromArgb(245, 108, 108);
            NutLichSu.DefaultColor = Color.FromArgb(255, 255, 255);
            NutLichSu.Font = new Font("Segoe UI", 12F);
            NutLichSu.HoverTextColor = Color.FromArgb(48, 49, 51);
            NutLichSu.InfoColor = Color.FromArgb(144, 147, 153);
            NutLichSu.Location = new Point(48, 439);
            NutLichSu.Name = "NutLichSu";
            NutLichSu.PrimaryColor = Color.SlateBlue;
            NutLichSu.Size = new Size(142, 61);
            NutLichSu.SuccessColor = Color.FromArgb(103, 194, 58);
            NutLichSu.TabIndex = 8;
            NutLichSu.Text = "Vé Đã Đặt Của Khách Hàng";
            NutLichSu.TextColor = Color.White;
            NutLichSu.WarningColor = Color.FromArgb(230, 162, 60);
            NutLichSu.Click += NutLichSu_Click;
            // 
            // NutXemDanhSachPhim
            // 
            NutXemDanhSachPhim.BorderColor = Color.FromArgb(220, 223, 230);
            NutXemDanhSachPhim.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            NutXemDanhSachPhim.DangerColor = Color.FromArgb(245, 108, 108);
            NutXemDanhSachPhim.DefaultColor = Color.FromArgb(255, 255, 255);
            NutXemDanhSachPhim.Font = new Font("Segoe UI", 12F);
            NutXemDanhSachPhim.HoverTextColor = Color.FromArgb(48, 49, 51);
            NutXemDanhSachPhim.InfoColor = Color.FromArgb(144, 147, 153);
            NutXemDanhSachPhim.Location = new Point(590, 439);
            NutXemDanhSachPhim.Name = "NutXemDanhSachPhim";
            NutXemDanhSachPhim.PrimaryColor = Color.SlateBlue;
            NutXemDanhSachPhim.Size = new Size(142, 61);
            NutXemDanhSachPhim.SuccessColor = Color.FromArgb(103, 194, 58);
            NutXemDanhSachPhim.TabIndex = 9;
            NutXemDanhSachPhim.Text = "Xem Danh Sách Phim Đang Chiếu";
            NutXemDanhSachPhim.TextColor = Color.White;
            NutXemDanhSachPhim.WarningColor = Color.FromArgb(230, 162, 60);
            NutXemDanhSachPhim.Click += NutXemDanhSachPhim_Click;
            // 
            // StaffOnLy
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(937, 535);
            Controls.Add(NutXemDanhSachPhim);
            Controls.Add(NutLichSu);
            Controls.Add(NutQuayLai);
            Controls.Add(NutThemUuDai);
            Controls.Add(NutThemPhim);
            Controls.Add(metroPanel1);
            Controls.Add(parrotGradientPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "StaffOnLy";
            Text = "Form3";
            Load += StaffOnLy_Load;
            parrotGradientPanel1.ResumeLayout(false);
            metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private PictureBox pictureBox1;
        private TreeView ThongKeVeDoanhThu;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.HopeButton NutThemPhim;
        private ReaLTaiizor.Controls.HopeButton NutThemUuDai;
        private MaterialSkin.Controls.MaterialButton NutQuayLai;
        private ReaLTaiizor.Controls.HopeButton NutLichSu;
        private ReaLTaiizor.Controls.HopeButton NutXemDanhSachPhim;
    }
}