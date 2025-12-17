namespace CinemaManagement
{
    partial class PhanDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanDangKy));
            NutDangKy = new Button();
            label1 = new Label();
            NutDangNHap = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            HoTen = new TextBox();
            SoDienThoai = new TextBox();
            Email = new TextBox();
            Username = new TextBox();
            MatKhau = new TextBox();
            label9 = new Label();
            XacNhanMatKhau = new TextBox();
            label10 = new Label();
            NgayThangNamSinh = new DateTimePicker();
            label11 = new Label();
            GioiTinh = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // NutDangKy
            // 
            NutDangKy.BackColor = Color.FromArgb(161, 8, 86);
            NutDangKy.Font = new Font("Epilogue", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDangKy.ForeColor = SystemColors.Window;
            NutDangKy.Location = new Point(426, 439);
            NutDangKy.Margin = new Padding(2, 1, 2, 1);
            NutDangKy.Name = "NutDangKy";
            NutDangKy.Size = new Size(203, 51);
            NutDangKy.TabIndex = 0;
            NutDangKy.Text = "ĐĂNG KÝ";
            NutDangKy.UseVisualStyleBackColor = false;
            NutDangKy.Click += NutDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Epilogue ExtraBold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(387, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 43);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // NutDangNHap
            // 
            NutDangNHap.ActiveLinkColor = SystemColors.WindowText;
            NutDangNHap.AutoSize = true;
            NutDangNHap.BackColor = Color.FromArgb(4, 21, 49);
            NutDangNHap.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDangNHap.ForeColor = SystemColors.Window;
            NutDangNHap.LinkColor = Color.White;
            NutDangNHap.Location = new Point(785, 438);
            NutDangNHap.Margin = new Padding(2, 0, 2, 0);
            NutDangNHap.Name = "NutDangNHap";
            NutDangNHap.Size = new Size(86, 18);
            NutDangNHap.TabIndex = 2;
            NutDangNHap.TabStop = true;
            NutDangNHap.Text = "Đăng Nhập";
            NutDangNHap.VisitedLinkColor = Color.Transparent;
            NutDangNHap.LinkClicked += NutDangNhap_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(223, 126);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(4, 21, 49);
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(484, 163);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 19);
            label3.TabIndex = 3;
            label3.Text = "Ngày/tháng/năm sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(223, 205);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(223, 255);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(225, 363);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 22);
            label7.TabIndex = 3;
            label7.Text = "Mật khẩu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(223, 401);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(192, 22);
            label8.TabIndex = 3;
            label8.Text = "Xác nhận lại mật khẩu:";
            // 
            // HoTen
            // 
            HoTen.BackColor = SystemColors.WindowText;
            HoTen.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoTen.ForeColor = SystemColors.Window;
            HoTen.Location = new Point(359, 118);
            HoTen.Margin = new Padding(2, 3, 2, 3);
            HoTen.Multiline = true;
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(476, 33);
            HoTen.TabIndex = 4;
            // 
            // SoDienThoai
            // 
            SoDienThoai.BackColor = SystemColors.WindowText;
            SoDienThoai.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoDienThoai.ForeColor = SystemColors.Window;
            SoDienThoai.Location = new Point(359, 197);
            SoDienThoai.Margin = new Padding(2, 3, 2, 3);
            SoDienThoai.Multiline = true;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Size = new Size(476, 33);
            SoDienThoai.TabIndex = 4;
            // 
            // Email
            // 
            Email.BackColor = SystemColors.WindowText;
            Email.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.Window;
            Email.Location = new Point(359, 247);
            Email.Margin = new Padding(2, 3, 2, 3);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.Size = new Size(476, 33);
            Email.TabIndex = 4;
            // 
            // Username
            // 
            Username.BackColor = SystemColors.WindowText;
            Username.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = SystemColors.Window;
            Username.Location = new Point(359, 295);
            Username.Margin = new Padding(2, 3, 2, 3);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.Size = new Size(476, 33);
            Username.TabIndex = 4;
            // 
            // MatKhau
            // 
            MatKhau.BackColor = SystemColors.WindowText;
            MatKhau.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MatKhau.ForeColor = SystemColors.Window;
            MatKhau.Location = new Point(426, 352);
            MatKhau.Margin = new Padding(2, 3, 2, 3);
            MatKhau.Multiline = true;
            MatKhau.Name = "MatKhau";
            MatKhau.PasswordChar = '*';
            MatKhau.Size = new Size(410, 33);
            MatKhau.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(223, 304);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 22);
            label9.TabIndex = 3;
            label9.Text = "Tên Tài Khoản:";
            // 
            // XacNhanMatKhau
            // 
            XacNhanMatKhau.BackColor = SystemColors.WindowText;
            XacNhanMatKhau.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            XacNhanMatKhau.ForeColor = SystemColors.Window;
            XacNhanMatKhau.Location = new Point(426, 393);
            XacNhanMatKhau.Margin = new Padding(2, 3, 2, 3);
            XacNhanMatKhau.Multiline = true;
            XacNhanMatKhau.Name = "XacNhanMatKhau";
            XacNhanMatKhau.PasswordChar = '*';
            XacNhanMatKhau.Size = new Size(410, 33);
            XacNhanMatKhau.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(4, 21, 49);
            label10.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(633, 439);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(142, 16);
            label10.TabIndex = 6;
            label10.Text = "Bạn đã có tài khoản?";
            label10.Click += label10_Click;
            // 
            // NgayThangNamSinh
            // 
            NgayThangNamSinh.CalendarForeColor = SystemColors.InfoText;
            NgayThangNamSinh.CalendarMonthBackground = SystemColors.InactiveCaptionText;
            NgayThangNamSinh.CalendarTitleBackColor = SystemColors.WindowText;
            NgayThangNamSinh.CalendarTitleForeColor = SystemColors.MenuBar;
            NgayThangNamSinh.CustomFormat = "";
            NgayThangNamSinh.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NgayThangNamSinh.Format = DateTimePickerFormat.Short;
            NgayThangNamSinh.Location = new Point(681, 163);
            NgayThangNamSinh.Margin = new Padding(2, 3, 2, 3);
            NgayThangNamSinh.Name = "NgayThangNamSinh";
            NgayThangNamSinh.Size = new Size(154, 24);
            NgayThangNamSinh.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(223, 163);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(80, 22);
            label11.TabIndex = 8;
            label11.Text = "Giới tính:";
            // 
            // GioiTinh
            // 
            GioiTinh.BackColor = SystemColors.InfoText;
            GioiTinh.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GioiTinh.ForeColor = SystemColors.Window;
            GioiTinh.FormattingEnabled = true;
            GioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Không Muốn Nói", "Không Xác Định" });
            GioiTinh.Location = new Point(359, 163);
            GioiTinh.Margin = new Padding(2, 3, 2, 3);
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Size = new Size(119, 24);
            GioiTinh.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(872, 14);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 113);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(-1, 352);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 173);
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // PhanDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(4, 21, 49);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1034, 524);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(GioiTinh);
            Controls.Add(label11);
            Controls.Add(NgayThangNamSinh);
            Controls.Add(label10);
            Controls.Add(XacNhanMatKhau);
            Controls.Add(MatKhau);
            Controls.Add(Username);
            Controls.Add(Email);
            Controls.Add(SoDienThoai);
            Controls.Add(HoTen);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NutDangNHap);
            Controls.Add(label1);
            Controls.Add(NutDangKy);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "PhanDangKy";
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NutDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel NutDangNHap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox HoTen;
        private System.Windows.Forms.TextBox SoDienThoai;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox XacNhanMatKhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker NgayThangNamSinh;
        private Label label11;
        private ComboBox GioiTinh;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

