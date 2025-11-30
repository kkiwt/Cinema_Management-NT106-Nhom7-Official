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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffOnLy));
            TreeNode treeNode1 = new TreeNode("Số Lượng Vé Thường Đã Bán Ra:");
            TreeNode treeNode2 = new TreeNode("Số Lượng Vé Vip Đã Bán Ra:");
            TreeNode treeNode3 = new TreeNode("Số Lượng Vé Couple Đã Bán Ra:");
            TreeNode treeNode4 = new TreeNode("Số Lượng Vé Đã Bán Ra", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Phim");
            TreeNode treeNode6 = new TreeNode("Bắp Nước:");
            TreeNode treeNode7 = new TreeNode("Tổng Doanh Thu Của Rạp", new TreeNode[] { treeNode5, treeNode6 });
            TreeNode treeNode8 = new TreeNode("Số Phim Đang Chiếu:");
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            nightPanel1 = new ReaLTaiizor.Controls.NightPanel();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            treeView1 = new TreeView();
            metroPanel1 = new MetroFramework.Controls.MetroPanel();
            panelChart = new Panel();
            bindingSource1 = new BindingSource(components);
            NutThemPhim = new ReaLTaiizor.Controls.HopeButton();
            NutThemUuDai = new ReaLTaiizor.Controls.HopeButton();
            parrotGradientPanel1.SuspendLayout();
            nightPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Epilogue", 20F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(161, 22);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(813, 71);
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
            parrotGradientPanel1.Controls.Add(nightPanel1);
            parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            parrotGradientPanel1.Location = new Point(-4, 0);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            parrotGradientPanel1.PrimerColor = Color.IndianRed;
            parrotGradientPanel1.Size = new Size(1218, 187);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 3;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.FromArgb(0, 0, 64);
            // 
            // nightPanel1
            // 
            nightPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nightPanel1.Controls.Add(materialButton1);
            nightPanel1.Controls.Add(pictureBox1);
            nightPanel1.ForeColor = Color.White;
            nightPanel1.LeftSideColor = Color.Black;
            nightPanel1.Location = new Point(3, 123);
            nightPanel1.Name = "nightPanel1";
            nightPanel1.RightSideColor = Color.FromArgb(41, 44, 61);
            nightPanel1.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Right;
            nightPanel1.Size = new Size(1223, 61);
            nightPanel1.TabIndex = 4;
            nightPanel1.Paint += nightPanel1_Paint;
            // 
            // materialButton1
            // 
            materialButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Noto Sans SC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1085, 17);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(85, 36);
            materialButton1.TabIndex = 5;
            materialButton1.Text = "Quay Lại";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(42, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 51);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.OldLace;
            treeView1.Font = new Font("Epilogue SemiBold", 13.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            treeView1.ForeColor = Color.IndianRed;
            treeView1.Location = new Point(16, 15);
            treeView1.Name = "treeView1";
            treeNode1.Name = "VeThuongChild";
            treeNode1.Text = "Số Lượng Vé Thường Đã Bán Ra:";
            treeNode2.Name = "VeVipChild";
            treeNode2.Text = "Số Lượng Vé Vip Đã Bán Ra:";
            treeNode3.Name = "VeCoupleChild";
            treeNode3.Text = "Số Lượng Vé Couple Đã Bán Ra:";
            treeNode4.Name = "SoLuongVeRoot";
            treeNode4.Text = "Số Lượng Vé Đã Bán Ra";
            treeNode5.Name = "NodePhim";
            treeNode5.Text = "Phim";
            treeNode6.Name = "NodeBapNuoc";
            treeNode6.Text = "Bắp Nước:";
            treeNode7.Name = "DoanhThuRoot";
            treeNode7.Text = "Tổng Doanh Thu Của Rạp";
            treeNode8.Name = "RootSoPhim";
            treeNode8.Text = "Số Phim Đang Chiếu:";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7, treeNode8 });
            treeView1.Size = new Size(523, 407);
            treeView1.TabIndex = 0;
            // 
            // metroPanel1
            // 
            metroPanel1.BackgroundImage = (Image)resources.GetObject("metroPanel1.BackgroundImage");
            metroPanel1.Controls.Add(treeView1);
            metroPanel1.CustomBackground = false;
            metroPanel1.ForeColor = Color.Transparent;
            metroPanel1.HorizontalScrollbar = false;
            metroPanel1.HorizontalScrollbarBarColor = true;
            metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            metroPanel1.HorizontalScrollbarSize = 10;
            metroPanel1.Location = new Point(31, 209);
            metroPanel1.Name = "metroPanel1";
            metroPanel1.Size = new Size(561, 437);
            metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            metroPanel1.StyleManager = null;
            metroPanel1.TabIndex = 4;
            metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroPanel1.VerticalScrollbar = false;
            metroPanel1.VerticalScrollbarBarColor = true;
            metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panelChart
            // 
            panelChart.Location = new Point(641, 209);
            panelChart.Name = "panelChart";
            panelChart.Size = new Size(540, 521);
            panelChart.TabIndex = 5;
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
            ClientSize = new Size(1205, 782);
            Controls.Add(NutThemUuDai);
            Controls.Add(NutThemPhim);
            Controls.Add(panelChart);
            Controls.Add(metroPanel1);
            Controls.Add(parrotGradientPanel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "StaffOnLy";
            Text = "Form3";
            Load += Form3_Load;
            parrotGradientPanel1.ResumeLayout(false);
            nightPanel1.ResumeLayout(false);
            nightPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.NightPanel nightPanel1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private TreeView treeView1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private Panel panelChart;
        private BindingSource bindingSource1;
        private ReaLTaiizor.Controls.HopeButton NutThemPhim;
        private ReaLTaiizor.Controls.HopeButton NutThemUuDai;
    }
}