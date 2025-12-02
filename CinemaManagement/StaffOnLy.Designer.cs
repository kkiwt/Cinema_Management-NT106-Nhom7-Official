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
            TreeNode treeNode1 = new TreeNode("Số Lượng Vé Thường Đã Bán Ra:");
            TreeNode treeNode2 = new TreeNode("Số Lượng Vé Vip Đã Bán Ra:");
            TreeNode treeNode3 = new TreeNode("Số Lượng Vé Đã Bán Ra:", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("Phim:");
            TreeNode treeNode5 = new TreeNode("Bắp Nước:");
            TreeNode treeNode6 = new TreeNode("Tổng Doanh Thu Của Rạp", new TreeNode[] { treeNode4, treeNode5 });
            TreeNode treeNode7 = new TreeNode("Số Phim Đang Chiếu:");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffOnLy));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            NutQuayLai = new MaterialSkin.Controls.MaterialButton();
            ThongKeVeDoanhThu = new TreeView();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            bindingSource1 = new BindingSource(components);
            NutThemPhim = new ReaLTaiizor.Controls.HopeButton();
            NutThemUuDai = new ReaLTaiizor.Controls.HopeButton();
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
            bigLabel1.Location = new Point(190, 26);
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
            // NutQuayLai
            // 
            NutQuayLai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NutQuayLai.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NutQuayLai.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            NutQuayLai.Depth = 0;
            NutQuayLai.Font = new Font("Noto Sans SC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutQuayLai.HighEmphasis = true;
            NutQuayLai.Icon = null;
            NutQuayLai.Location = new Point(834, 694);
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
            // ThongKeVeDoanhThu
            // 
            ThongKeVeDoanhThu.BackColor = Color.OldLace;
            ThongKeVeDoanhThu.Font = new Font("Epilogue", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ThongKeVeDoanhThu.ForeColor = Color.IndianRed;
            ThongKeVeDoanhThu.Location = new Point(16, 15);
            ThongKeVeDoanhThu.Name = "ThongKeVeDoanhThu";
            treeNode1.Name = "VeThuongChild";
            treeNode1.Text = "Số Lượng Vé Thường Đã Bán Ra:";
            treeNode2.Name = "VeVipChild";
            treeNode2.Text = "Số Lượng Vé Vip Đã Bán Ra:";
            treeNode3.Name = "SoLuongVeRoot";
            treeNode3.Text = "Số Lượng Vé Đã Bán Ra:";
            treeNode4.Name = "NodePhim";
            treeNode4.Text = "Phim:";
            treeNode5.Name = "NodeBapNuoc";
            treeNode5.Text = "Bắp Nước:";
            treeNode6.Name = "DoanhThuRoot";
            treeNode6.Text = "Tổng Doanh Thu Của Rạp";
            treeNode7.Name = "RootSoPhim";
            treeNode7.Text = "Số Phim Đang Chiếu:";
            ThongKeVeDoanhThu.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode6, treeNode7 });
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
            metroPanel1.Size = new Size(887, 500);
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
            NutThemPhim.Location = new Point(47, 669);
            NutThemPhim.Name = "NutThemPhim";
            NutThemPhim.PrimaryColor = Color.SlateBlue;
            NutThemPhim.Size = new Size(175, 61);
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
            NutThemUuDai.Location = new Point(379, 669);
            NutThemUuDai.Name = "NutThemUuDai";
            NutThemUuDai.PrimaryColor = Color.SlateBlue;
            NutThemUuDai.Size = new Size(191, 61);
            NutThemUuDai.SuccessColor = Color.FromArgb(103, 194, 58);
            NutThemUuDai.TabIndex = 7;
            NutThemUuDai.Text = "Thêm Ưu Đãi";
            NutThemUuDai.TextColor = Color.White;
            NutThemUuDai.WarningColor = Color.FromArgb(230, 162, 60);
            NutThemUuDai.Click += NutThemUuDai_Click;
            // 
            // StaffOnLy
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(953, 782);
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
        private MaterialSkin.Controls.MaterialButton NutQuayLai;
        private TreeView ThongKeVeDoanhThu;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.HopeButton NutThemPhim;
        private ReaLTaiizor.Controls.HopeButton NutThemUuDai;
    }
}