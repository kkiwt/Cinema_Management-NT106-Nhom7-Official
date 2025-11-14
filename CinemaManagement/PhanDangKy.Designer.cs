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
            SuspendLayout();
            // 
            // NutDangKy
            // 
            NutDangKy.BackColor = Color.FromArgb(161, 8, 86);
            NutDangKy.Font = new Font("Epilogue", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDangKy.ForeColor = SystemColors.Window;
            NutDangKy.Location = new Point(608, 732);
            NutDangKy.Margin = new Padding(3, 2, 3, 2);
            NutDangKy.Name = "NutDangKy";
            NutDangKy.Size = new Size(290, 85);
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
            label1.Location = new Point(553, 86);
            label1.Name = "label1";
            label1.Size = new Size(466, 62);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // NutDangNHap
            // 
            NutDangNHap.ActiveLinkColor = SystemColors.WindowText;
            NutDangNHap.AutoSize = true;
            NutDangNHap.BackColor = SystemColors.WindowText;
            NutDangNHap.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDangNHap.ForeColor = SystemColors.Window;
            NutDangNHap.LinkColor = Color.White;
            NutDangNHap.Location = new Point(1122, 730);
            NutDangNHap.Name = "NutDangNHap";
            NutDangNHap.Size = new Size(126, 26);
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
            label2.Location = new Point(319, 210);
            label2.Name = "label2";
            label2.Size = new Size(137, 34);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowText;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(691, 272);
            label3.Name = "label3";
            label3.Size = new Size(264, 29);
            label3.TabIndex = 3;
            label3.Text = "Ngày/tháng/năm sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(319, 341);
            label4.Name = "label4";
            label4.Size = new Size(182, 34);
            label4.TabIndex = 3;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(319, 425);
            label5.Name = "label5";
            label5.Size = new Size(86, 34);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(322, 605);
            label7.Name = "label7";
            label7.Size = new Size(136, 34);
            label7.TabIndex = 3;
            label7.Text = "Mật khẩu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(319, 669);
            label8.Name = "label8";
            label8.Size = new Size(287, 34);
            label8.TabIndex = 3;
            label8.Text = "Xác nhận lại mật khẩu:";
            // 
            // HoTen
            // 
            HoTen.BackColor = SystemColors.WindowText;
            HoTen.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoTen.ForeColor = SystemColors.Window;
            HoTen.Location = new Point(513, 196);
            HoTen.Margin = new Padding(3, 5, 3, 5);
            HoTen.Multiline = true;
            HoTen.Name = "HoTen";
            HoTen.Size = new Size(679, 53);
            HoTen.TabIndex = 4;
            // 
            // SoDienThoai
            // 
            SoDienThoai.BackColor = SystemColors.WindowText;
            SoDienThoai.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SoDienThoai.ForeColor = SystemColors.Window;
            SoDienThoai.Location = new Point(513, 328);
            SoDienThoai.Margin = new Padding(3, 5, 3, 5);
            SoDienThoai.Multiline = true;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.Size = new Size(679, 53);
            SoDienThoai.TabIndex = 4;
            // 
            // Email
            // 
            Email.BackColor = SystemColors.WindowText;
            Email.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.ForeColor = SystemColors.Window;
            Email.Location = new Point(513, 412);
            Email.Margin = new Padding(3, 5, 3, 5);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.Size = new Size(679, 53);
            Email.TabIndex = 4;
            // 
            // Username
            // 
            Username.BackColor = SystemColors.WindowText;
            Username.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = SystemColors.Window;
            Username.Location = new Point(513, 491);
            Username.Margin = new Padding(3, 5, 3, 5);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.Size = new Size(679, 53);
            Username.TabIndex = 4;
            // 
            // MatKhau
            // 
            MatKhau.BackColor = SystemColors.WindowText;
            MatKhau.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MatKhau.ForeColor = SystemColors.Window;
            MatKhau.Location = new Point(608, 586);
            MatKhau.Margin = new Padding(3, 5, 3, 5);
            MatKhau.Multiline = true;
            MatKhau.Name = "MatKhau";
            MatKhau.PasswordChar = '*';
            MatKhau.Size = new Size(584, 53);
            MatKhau.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(319, 506);
            label9.Name = "label9";
            label9.Size = new Size(187, 34);
            label9.TabIndex = 3;
            label9.Text = "Tên Tài Khoản:";
            // 
            // XacNhanMatKhau
            // 
            XacNhanMatKhau.BackColor = SystemColors.WindowText;
            XacNhanMatKhau.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            XacNhanMatKhau.ForeColor = SystemColors.Window;
            XacNhanMatKhau.Location = new Point(608, 655);
            XacNhanMatKhau.Margin = new Padding(3, 5, 3, 5);
            XacNhanMatKhau.Multiline = true;
            XacNhanMatKhau.Name = "XacNhanMatKhau";
            XacNhanMatKhau.PasswordChar = '*';
            XacNhanMatKhau.Size = new Size(584, 53);
            XacNhanMatKhau.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.WindowText;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(904, 732);
            label10.Name = "label10";
            label10.Size = new Size(212, 24);
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
            NgayThangNamSinh.Location = new Point(973, 272);
            NgayThangNamSinh.Margin = new Padding(3, 5, 3, 5);
            NgayThangNamSinh.Name = "NgayThangNamSinh";
            NgayThangNamSinh.Size = new Size(219, 32);
            NgayThangNamSinh.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Epilogue", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.HighlightText;
            label11.Location = new Point(319, 272);
            label11.Name = "label11";
            label11.Size = new Size(121, 34);
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
            GioiTinh.Location = new Point(513, 272);
            GioiTinh.Margin = new Padding(3, 5, 3, 5);
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Size = new Size(168, 33);
            GioiTinh.TabIndex = 9;
            // 
            // PhanDangKy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(4, 21, 49);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1477, 873);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "PhanDangKy";
            Text = "Đăng ký tài khoản";
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
    }
}

