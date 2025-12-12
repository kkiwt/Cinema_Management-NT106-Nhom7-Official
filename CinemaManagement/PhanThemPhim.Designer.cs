namespace CinemaManagement
{
    partial class PhanThemPhim
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
            NutQuayLai = new MaterialSkin.Controls.MaterialButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            ChieuTu = new DateTimePicker();
            ChieuDen = new DateTimePicker();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            TenBoPhim = new ReaLTaiizor.Controls.HopeTextBox();
            bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            TenDaoDien = new ReaLTaiizor.Controls.HopeTextBox();
            bigLabel12 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            DanDienVien = new ReaLTaiizor.Controls.HopeRichTextBox();
            bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            MoTaPhim = new ReaLTaiizor.Controls.HopeRichTextBox();
            bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel14 = new ReaLTaiizor.Controls.BigLabel();
            ChonDoTuoi = new ReaLTaiizor.Controls.HopeComboBox();
            bigLabel10 = new ReaLTaiizor.Controls.BigLabel();
            ChonQuocGia = new ReaLTaiizor.Controls.HopeComboBox();
            URLTrailerPhim = new ReaLTaiizor.Controls.HopeTextBox();
            bigLabel20 = new ReaLTaiizor.Controls.BigLabel();
            AnhSeDuocThem = new ReaLTaiizor.Controls.HopePictureBox();
            NutThemAnh = new ReaLTaiizor.Controls.SpaceButton();
            NutThemPhim = new ReaLTaiizor.Controls.SpaceButton();
            ThoiLuongText = new ReaLTaiizor.Controls.HopeTextBox();
            panel1 = new Panel();
            ChonNgonNgu = new ReaLTaiizor.Controls.HopeComboBox();
            bigLabel13 = new ReaLTaiizor.Controls.BigLabel();
            TheLoaiText = new ReaLTaiizor.Controls.HopeTextBox();
            parrotGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnhSeDuocThem).BeginInit();
            panel1.SuspendLayout();
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
            parrotGradientPanel1.Location = new Point(-1, 0);
            parrotGradientPanel1.Margin = new Padding(2);
            parrotGradientPanel1.Name = "parrotGradientPanel1";
            parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
            parrotGradientPanel1.PrimerColor = Color.IndianRed;
            parrotGradientPanel1.Size = new Size(969, 74);
            parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            parrotGradientPanel1.TabIndex = 4;
            parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            parrotGradientPanel1.TopLeft = Color.DeepSkyBlue;
            parrotGradientPanel1.TopRight = Color.FromArgb(0, 0, 64);
            // 
            // bigLabel1
            // 
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Epilogue", 20F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(207, 16);
            bigLabel1.Margin = new Padding(2, 0, 2, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(569, 43);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "Solunar Cinema Management System";
            bigLabel1.Click += bigLabel1_Click;
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
            NutQuayLai.Location = new Point(799, 85);
            NutQuayLai.Margin = new Padding(3, 4, 3, 4);
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Noto Sans SC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.White;
            bigLabel3.Location = new Point(420, 93);
            bigLabel3.Margin = new Padding(2, 0, 2, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(138, 32);
            bigLabel3.TabIndex = 47;
            bigLabel3.Text = "Thêm Phim";
            // 
            // ChieuTu
            // 
            ChieuTu.Location = new Point(291, 58);
            ChieuTu.Margin = new Padding(2);
            ChieuTu.Name = "ChieuTu";
            ChieuTu.Size = new Size(207, 23);
            ChieuTu.TabIndex = 5;
            // 
            // ChieuDen
            // 
            ChieuDen.Location = new Point(583, 55);
            ChieuDen.Margin = new Padding(2);
            ChieuDen.Name = "ChieuDen";
            ChieuDen.Size = new Size(216, 23);
            ChieuDen.TabIndex = 6;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.White;
            bigLabel2.Location = new Point(149, 58);
            bigLabel2.Margin = new Padding(2, 0, 2, 0);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(75, 21);
            bigLabel2.TabIndex = 7;
            bigLabel2.Text = "Chiếu Từ";
            bigLabel2.Click += bigLabel2_Click;
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.White;
            bigLabel4.Location = new Point(507, 58);
            bigLabel4.Margin = new Padding(2, 0, 2, 0);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(40, 21);
            bigLabel4.TabIndex = 8;
            bigLabel4.Text = "Đến";
            // 
            // bigLabel5
            // 
            bigLabel5.AutoSize = true;
            bigLabel5.BackColor = Color.Transparent;
            bigLabel5.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel5.ForeColor = Color.White;
            bigLabel5.Location = new Point(149, 21);
            bigLabel5.Margin = new Padding(2, 0, 2, 0);
            bigLabel5.Name = "bigLabel5";
            bigLabel5.Size = new Size(106, 21);
            bigLabel5.TabIndex = 9;
            bigLabel5.Text = "Tên Bộ Phim:";
            // 
            // TenBoPhim
            // 
            TenBoPhim.BackColor = Color.White;
            TenBoPhim.BaseColor = Color.FromArgb(44, 55, 66);
            TenBoPhim.BorderColorA = Color.FromArgb(64, 158, 255);
            TenBoPhim.BorderColorB = Color.FromArgb(220, 223, 230);
            TenBoPhim.Font = new Font("Segoe UI", 12F);
            TenBoPhim.ForeColor = Color.FromArgb(48, 49, 51);
            TenBoPhim.Hint = "";
            TenBoPhim.Location = new Point(291, 11);
            TenBoPhim.Margin = new Padding(2);
            TenBoPhim.MaxLength = 32767;
            TenBoPhim.Multiline = false;
            TenBoPhim.Name = "TenBoPhim";
            TenBoPhim.PasswordChar = '\0';
            TenBoPhim.ScrollBars = ScrollBars.None;
            TenBoPhim.SelectedText = "";
            TenBoPhim.SelectionLength = 0;
            TenBoPhim.SelectionStart = 0;
            TenBoPhim.Size = new Size(507, 38);
            TenBoPhim.TabIndex = 10;
            TenBoPhim.TabStop = false;
            TenBoPhim.UseSystemPasswordChar = false;
            // 
            // bigLabel11
            // 
            bigLabel11.AutoSize = true;
            bigLabel11.BackColor = Color.Transparent;
            bigLabel11.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel11.ForeColor = Color.White;
            bigLabel11.Location = new Point(25, 494);
            bigLabel11.Margin = new Padding(2, 0, 2, 0);
            bigLabel11.Name = "bigLabel11";
            bigLabel11.Size = new Size(78, 21);
            bigLabel11.TabIndex = 21;
            bigLabel11.Text = "Thể Loại:";
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel6.ForeColor = Color.White;
            bigLabel6.Location = new Point(149, 100);
            bigLabel6.Margin = new Padding(2, 0, 2, 0);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(82, 21);
            bigLabel6.TabIndex = 11;
            bigLabel6.Text = "Đạo Diễn:";
            // 
            // TenDaoDien
            // 
            TenDaoDien.BackColor = Color.White;
            TenDaoDien.BaseColor = Color.FromArgb(44, 55, 66);
            TenDaoDien.BorderColorA = Color.FromArgb(64, 158, 255);
            TenDaoDien.BorderColorB = Color.FromArgb(220, 223, 230);
            TenDaoDien.Font = new Font("Segoe UI", 12F);
            TenDaoDien.ForeColor = Color.FromArgb(48, 49, 51);
            TenDaoDien.Hint = "";
            TenDaoDien.Location = new Point(291, 91);
            TenDaoDien.Margin = new Padding(2);
            TenDaoDien.MaxLength = 32767;
            TenDaoDien.Multiline = false;
            TenDaoDien.Name = "TenDaoDien";
            TenDaoDien.PasswordChar = '\0';
            TenDaoDien.ScrollBars = ScrollBars.None;
            TenDaoDien.SelectedText = "";
            TenDaoDien.SelectionLength = 0;
            TenDaoDien.SelectionStart = 0;
            TenDaoDien.Size = new Size(507, 38);
            TenDaoDien.TabIndex = 12;
            TenDaoDien.TabStop = false;
            TenDaoDien.UseSystemPasswordChar = false;
            // 
            // bigLabel12
            // 
            bigLabel12.AutoSize = true;
            bigLabel12.BackColor = Color.Transparent;
            bigLabel12.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel12.ForeColor = Color.White;
            bigLabel12.Location = new Point(27, 536);
            bigLabel12.Margin = new Padding(2, 0, 2, 0);
            bigLabel12.Name = "bigLabel12";
            bigLabel12.Size = new Size(98, 21);
            bigLabel12.TabIndex = 23;
            bigLabel12.Text = "Thời Lượng:";
            // 
            // bigLabel7
            // 
            bigLabel7.AutoSize = true;
            bigLabel7.BackColor = Color.Transparent;
            bigLabel7.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel7.ForeColor = Color.White;
            bigLabel7.Location = new Point(149, 136);
            bigLabel7.Margin = new Padding(2, 0, 2, 0);
            bigLabel7.Name = "bigLabel7";
            bigLabel7.Size = new Size(119, 21);
            bigLabel7.TabIndex = 13;
            bigLabel7.Text = "Dàn Diễn Viên:";
            // 
            // DanDienVien
            // 
            DanDienVien.BorderColor = Color.FromArgb(220, 223, 230);
            DanDienVien.Font = new Font("Segoe UI", 12F);
            DanDienVien.ForeColor = Color.FromArgb(48, 49, 51);
            DanDienVien.Hint = "";
            DanDienVien.HoverBorderColor = Color.FromArgb(64, 158, 255);
            DanDienVien.Location = new Point(291, 133);
            DanDienVien.Margin = new Padding(2);
            DanDienVien.MaxLength = 32767;
            DanDienVien.Multiline = true;
            DanDienVien.Name = "DanDienVien";
            DanDienVien.PasswordChar = '\0';
            DanDienVien.ScrollBars = ScrollBars.None;
            DanDienVien.SelectedText = "";
            DanDienVien.SelectionLength = 0;
            DanDienVien.SelectionStart = 0;
            DanDienVien.Size = new Size(507, 88);
            DanDienVien.TabIndex = 14;
            DanDienVien.TabStop = false;
            DanDienVien.UseSystemPasswordChar = false;
            // 
            // bigLabel8
            // 
            bigLabel8.AutoSize = true;
            bigLabel8.BackColor = Color.Transparent;
            bigLabel8.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel8.ForeColor = Color.White;
            bigLabel8.Location = new Point(149, 231);
            bigLabel8.Margin = new Padding(2, 0, 2, 0);
            bigLabel8.Name = "bigLabel8";
            bigLabel8.Size = new Size(99, 21);
            bigLabel8.TabIndex = 15;
            bigLabel8.Text = "Mô Tả Phim:";
            // 
            // MoTaPhim
            // 
            MoTaPhim.BorderColor = Color.FromArgb(220, 223, 230);
            MoTaPhim.Font = new Font("Segoe UI", 12F);
            MoTaPhim.ForeColor = Color.FromArgb(48, 49, 51);
            MoTaPhim.Hint = "";
            MoTaPhim.HoverBorderColor = Color.FromArgb(64, 158, 255);
            MoTaPhim.Location = new Point(291, 231);
            MoTaPhim.Margin = new Padding(2);
            MoTaPhim.MaxLength = 32767;
            MoTaPhim.Multiline = true;
            MoTaPhim.Name = "MoTaPhim";
            MoTaPhim.PasswordChar = '\0';
            MoTaPhim.ScrollBars = ScrollBars.None;
            MoTaPhim.SelectedText = "";
            MoTaPhim.SelectionLength = 0;
            MoTaPhim.SelectionStart = 0;
            MoTaPhim.Size = new Size(508, 123);
            MoTaPhim.TabIndex = 16;
            MoTaPhim.TabStop = false;
            MoTaPhim.UseSystemPasswordChar = false;
            // 
            // bigLabel9
            // 
            bigLabel9.AutoSize = true;
            bigLabel9.BackColor = Color.Transparent;
            bigLabel9.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel9.ForeColor = Color.White;
            bigLabel9.Location = new Point(25, 445);
            bigLabel9.Margin = new Padding(2, 0, 2, 0);
            bigLabel9.Name = "bigLabel9";
            bigLabel9.Size = new Size(136, 21);
            bigLabel9.TabIndex = 17;
            bigLabel9.Text = "Giới Hạn Độ Tuổi:";
            // 
            // bigLabel14
            // 
            bigLabel14.AutoSize = true;
            bigLabel14.BackColor = Color.Transparent;
            bigLabel14.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel14.ForeColor = Color.White;
            bigLabel14.Location = new Point(234, 536);
            bigLabel14.Margin = new Padding(2, 0, 2, 0);
            bigLabel14.Name = "bigLabel14";
            bigLabel14.Size = new Size(46, 21);
            bigLabel14.TabIndex = 26;
            bigLabel14.Text = "Phút";
            bigLabel14.Click += bigLabel14_Click;
            // 
            // ChonDoTuoi
            // 
            ChonDoTuoi.DrawMode = DrawMode.OwnerDrawFixed;
            ChonDoTuoi.FlatStyle = FlatStyle.Flat;
            ChonDoTuoi.Font = new Font("Segoe UI", 12F);
            ChonDoTuoi.FormattingEnabled = true;
            ChonDoTuoi.ItemHeight = 30;
            ChonDoTuoi.Items.AddRange(new object[] { "Mọi Đối Tượng", "6+", "13+", "16+", "18+" });
            ChonDoTuoi.Location = new Point(165, 433);
            ChonDoTuoi.Margin = new Padding(2);
            ChonDoTuoi.Name = "ChonDoTuoi";
            ChonDoTuoi.Size = new Size(188, 36);
            ChonDoTuoi.TabIndex = 18;
            // 
            // bigLabel10
            // 
            bigLabel10.AutoSize = true;
            bigLabel10.BackColor = Color.Transparent;
            bigLabel10.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel10.ForeColor = Color.White;
            bigLabel10.Location = new Point(375, 444);
            bigLabel10.Margin = new Padding(2, 0, 2, 0);
            bigLabel10.Name = "bigLabel10";
            bigLabel10.Size = new Size(82, 21);
            bigLabel10.TabIndex = 19;
            bigLabel10.Text = "Quốc Gia:";
            // 
            // ChonQuocGia
            // 
            ChonQuocGia.DrawMode = DrawMode.OwnerDrawFixed;
            ChonQuocGia.FlatStyle = FlatStyle.Flat;
            ChonQuocGia.Font = new Font("Segoe UI", 9F);
            ChonQuocGia.FormattingEnabled = true;
            ChonQuocGia.ItemHeight = 30;
            ChonQuocGia.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, Democratic Republic of the", "Congo, Republic of the", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            ChonQuocGia.Location = new Point(467, 433);
            ChonQuocGia.Margin = new Padding(2);
            ChonQuocGia.Name = "ChonQuocGia";
            ChonQuocGia.Size = new Size(183, 36);
            ChonQuocGia.TabIndex = 20;
            // 
            // URLTrailerPhim
            // 
            URLTrailerPhim.BackColor = Color.White;
            URLTrailerPhim.BaseColor = Color.FromArgb(44, 55, 66);
            URLTrailerPhim.BorderColorA = Color.FromArgb(64, 158, 255);
            URLTrailerPhim.BorderColorB = Color.FromArgb(220, 223, 230);
            URLTrailerPhim.Font = new Font("Segoe UI", 12F);
            URLTrailerPhim.ForeColor = Color.FromArgb(48, 49, 51);
            URLTrailerPhim.Hint = "";
            URLTrailerPhim.Location = new Point(291, 380);
            URLTrailerPhim.Margin = new Padding(2);
            URLTrailerPhim.MaxLength = 32767;
            URLTrailerPhim.Multiline = false;
            URLTrailerPhim.Name = "URLTrailerPhim";
            URLTrailerPhim.PasswordChar = '\0';
            URLTrailerPhim.ScrollBars = ScrollBars.None;
            URLTrailerPhim.SelectedText = "";
            URLTrailerPhim.SelectionLength = 0;
            URLTrailerPhim.SelectionStart = 0;
            URLTrailerPhim.Size = new Size(507, 38);
            URLTrailerPhim.TabIndex = 40;
            URLTrailerPhim.TabStop = false;
            URLTrailerPhim.UseSystemPasswordChar = false;
            // 
            // bigLabel20
            // 
            bigLabel20.AutoSize = true;
            bigLabel20.BackColor = Color.Transparent;
            bigLabel20.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel20.ForeColor = Color.White;
            bigLabel20.Location = new Point(124, 394);
            bigLabel20.Margin = new Padding(2, 0, 2, 0);
            bigLabel20.Name = "bigLabel20";
            bigLabel20.Size = new Size(143, 21);
            bigLabel20.TabIndex = 41;
            bigLabel20.Text = "Link Trailer Phim:";
            // 
            // AnhSeDuocThem
            // 
            AnhSeDuocThem.BackColor = Color.FromArgb(192, 196, 204);
            AnhSeDuocThem.Location = new Point(682, 469);
            AnhSeDuocThem.Margin = new Padding(2);
            AnhSeDuocThem.Name = "AnhSeDuocThem";
            AnhSeDuocThem.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            AnhSeDuocThem.Size = new Size(171, 136);
            AnhSeDuocThem.SizeMode = PictureBoxSizeMode.StretchImage;
            AnhSeDuocThem.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            AnhSeDuocThem.TabIndex = 39;
            AnhSeDuocThem.TabStop = false;
            AnhSeDuocThem.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // NutThemAnh
            // 
            NutThemAnh.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            NutThemAnh.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutThemAnh.Image = null;
            NutThemAnh.Location = new Point(693, 433);
            NutThemAnh.Margin = new Padding(2);
            NutThemAnh.Name = "NutThemAnh";
            NutThemAnh.NoRounding = false;
            NutThemAnh.Size = new Size(141, 32);
            NutThemAnh.TabIndex = 45;
            NutThemAnh.Text = "Thêm Ảnh";
            NutThemAnh.TextAlignment = HorizontalAlignment.Center;
            NutThemAnh.Transparent = false;
            NutThemAnh.Click += NutThemAnh_Click;
            // 
            // NutThemPhim
            // 
            NutThemPhim.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            NutThemPhim.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutThemPhim.Image = null;
            NutThemPhim.Location = new Point(335, 586);
            NutThemPhim.Margin = new Padding(2);
            NutThemPhim.Name = "NutThemPhim";
            NutThemPhim.NoRounding = false;
            NutThemPhim.Size = new Size(249, 32);
            NutThemPhim.TabIndex = 44;
            NutThemPhim.Text = "Thêm Phim";
            NutThemPhim.TextAlignment = HorizontalAlignment.Center;
            NutThemPhim.Transparent = false;
            NutThemPhim.Click += NutThemPhim_Click;
            // 
            // ThoiLuongText
            // 
            ThoiLuongText.BackColor = Color.White;
            ThoiLuongText.BaseColor = Color.FromArgb(44, 55, 66);
            ThoiLuongText.BorderColorA = Color.FromArgb(64, 158, 255);
            ThoiLuongText.BorderColorB = Color.FromArgb(220, 223, 230);
            ThoiLuongText.Font = new Font("Segoe UI", 10F);
            ThoiLuongText.ForeColor = Color.FromArgb(48, 49, 51);
            ThoiLuongText.Hint = "";
            ThoiLuongText.Location = new Point(165, 529);
            ThoiLuongText.Margin = new Padding(2);
            ThoiLuongText.MaxLength = 32767;
            ThoiLuongText.Multiline = false;
            ThoiLuongText.Name = "ThoiLuongText";
            ThoiLuongText.PasswordChar = '\0';
            ThoiLuongText.ScrollBars = ScrollBars.None;
            ThoiLuongText.SelectedText = "";
            ThoiLuongText.SelectionLength = 0;
            ThoiLuongText.SelectionStart = 0;
            ThoiLuongText.Size = new Size(59, 34);
            ThoiLuongText.TabIndex = 46;
            ThoiLuongText.TabStop = false;
            ThoiLuongText.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(ChonNgonNgu);
            panel1.Controls.Add(bigLabel13);
            panel1.Controls.Add(TheLoaiText);
            panel1.Controls.Add(ThoiLuongText);
            panel1.Controls.Add(NutThemPhim);
            panel1.Controls.Add(NutThemAnh);
            panel1.Controls.Add(AnhSeDuocThem);
            panel1.Controls.Add(bigLabel20);
            panel1.Controls.Add(URLTrailerPhim);
            panel1.Controls.Add(ChonQuocGia);
            panel1.Controls.Add(bigLabel10);
            panel1.Controls.Add(ChonDoTuoi);
            panel1.Controls.Add(bigLabel14);
            panel1.Controls.Add(bigLabel9);
            panel1.Controls.Add(MoTaPhim);
            panel1.Controls.Add(bigLabel8);
            panel1.Controls.Add(DanDienVien);
            panel1.Controls.Add(bigLabel7);
            panel1.Controls.Add(bigLabel12);
            panel1.Controls.Add(TenDaoDien);
            panel1.Controls.Add(bigLabel6);
            panel1.Controls.Add(bigLabel11);
            panel1.Controls.Add(TenBoPhim);
            panel1.Controls.Add(bigLabel5);
            panel1.Controls.Add(bigLabel4);
            panel1.Controls.Add(bigLabel2);
            panel1.Controls.Add(ChieuDen);
            panel1.Controls.Add(ChieuTu);
            panel1.Location = new Point(11, 127);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(929, 377);
            panel1.TabIndex = 46;
            // 
            // ChonNgonNgu
            // 
            ChonNgonNgu.DrawMode = DrawMode.OwnerDrawFixed;
            ChonNgonNgu.FlatStyle = FlatStyle.Flat;
            ChonNgonNgu.Font = new Font("Segoe UI", 9F);
            ChonNgonNgu.FormattingEnabled = true;
            ChonNgonNgu.ItemHeight = 30;
            ChonNgonNgu.Items.AddRange(new object[] { "English", "Vietnamese", "Lồng Tiếng Tiếng Việt", "Chinese", "Japanese", "Korean", "French", "German", "Spanish", "Portuguese", "Italian", "Russian", "Arabic", "Hindi", "Bengali", "Urdu", "Thai", "Indonesian", "Malay", "Philippine (Tagalog)", "Punjabi", "Turkish", "Dutch", "Polish", "Ukrainian", "Czech", "Slovak", "Swedish", "Norwegian", "Danish", "Finnish", "Greek", "Hebrew", "Hungarian", "Romanian", "Bulgarian", "Serbian", "Croatian", "Slovenian", "Latvian", "Lithuanian", "Estonian", "Icelandic", "Swahili", "Persian (Farsi)", "Tamil", "Telugu", "Marathi", "Gujarati", "Nepali", "Sinhala" });
            ChonNgonNgu.Location = new Point(467, 529);
            ChonNgonNgu.Margin = new Padding(2);
            ChonNgonNgu.Name = "ChonNgonNgu";
            ChonNgonNgu.Size = new Size(183, 36);
            ChonNgonNgu.TabIndex = 50;
            // 
            // bigLabel13
            // 
            bigLabel13.AutoSize = true;
            bigLabel13.BackColor = Color.Transparent;
            bigLabel13.Font = new Font("Noto Sans SC", 10.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel13.ForeColor = Color.White;
            bigLabel13.Location = new Point(335, 536);
            bigLabel13.Margin = new Padding(2, 0, 2, 0);
            bigLabel13.Name = "bigLabel13";
            bigLabel13.Size = new Size(87, 21);
            bigLabel13.TabIndex = 49;
            bigLabel13.Text = "Ngôn Ngữ:";
            // 
            // TheLoaiText
            // 
            TheLoaiText.BackColor = Color.White;
            TheLoaiText.BaseColor = Color.FromArgb(44, 55, 66);
            TheLoaiText.BorderColorA = Color.FromArgb(64, 158, 255);
            TheLoaiText.BorderColorB = Color.FromArgb(220, 223, 230);
            TheLoaiText.Font = new Font("Segoe UI", 10F);
            TheLoaiText.ForeColor = Color.FromArgb(48, 49, 51);
            TheLoaiText.Hint = "";
            TheLoaiText.Location = new Point(165, 487);
            TheLoaiText.Margin = new Padding(2);
            TheLoaiText.MaxLength = 32767;
            TheLoaiText.Multiline = false;
            TheLoaiText.Name = "TheLoaiText";
            TheLoaiText.PasswordChar = '\0';
            TheLoaiText.ScrollBars = ScrollBars.None;
            TheLoaiText.SelectedText = "";
            TheLoaiText.SelectionLength = 0;
            TheLoaiText.SelectionStart = 0;
            TheLoaiText.Size = new Size(485, 34);
            TheLoaiText.TabIndex = 47;
            TheLoaiText.TabStop = false;
            TheLoaiText.UseSystemPasswordChar = false;
            // 
            // PhanThemPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(946, 538);
            Controls.Add(bigLabel3);
            Controls.Add(NutQuayLai);
            Controls.Add(parrotGradientPanel1);
            Controls.Add(panel1);
            ForeColor = Color.Coral;
            Margin = new Padding(2);
            Name = "PhanThemPhim";
            Text = "Form4";
            Load += PhanThemPhim_Load;
            parrotGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnhSeDuocThem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private MaterialSkin.Controls.MaterialButton NutQuayLai;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private DateTimePicker ChieuTu;
        private DateTimePicker ChieuDen;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.HopeTextBox TenBoPhim;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.HopeTextBox TenDaoDien;
        private ReaLTaiizor.Controls.BigLabel bigLabel12;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.HopeRichTextBox DanDienVien;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.HopeRichTextBox MoTaPhim;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.BigLabel bigLabel14;
        private ReaLTaiizor.Controls.HopeComboBox ChonDoTuoi;
        private ReaLTaiizor.Controls.BigLabel bigLabel10;
        private ReaLTaiizor.Controls.HopeComboBox ChonQuocGia;
        private ReaLTaiizor.Controls.HopeTextBox URLTrailerPhim;
        private ReaLTaiizor.Controls.BigLabel bigLabel20;
        private ReaLTaiizor.Controls.HopePictureBox AnhSeDuocThem;
        private ReaLTaiizor.Controls.SpaceButton NutThemAnh;
        private ReaLTaiizor.Controls.SpaceButton NutThemPhim;
        private ReaLTaiizor.Controls.HopeTextBox ThoiLuongText;
        private Panel panel1;
        private ReaLTaiizor.Controls.HopeTextBox TheLoaiText;
        private ReaLTaiizor.Controls.HopeComboBox ChonNgonNgu;
        private ReaLTaiizor.Controls.BigLabel bigLabel13;
    }
}