namespace CinemaManagement
{
    partial class PhanDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanDangNhap));
            label1 = new Label();
            NutDangNhap = new Button();
            DangKyLinkLabel = new LinkLabel();
            label2 = new Label();
            label3 = new Label();
            TenDangNhap = new TextBox();
            MatKhau = new TextBox();
            label10 = new Label();
            LabelQuenMatKhau = new LinkLabel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Epilogue ExtraBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(178, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 38);
            label1.TabIndex = 2;
            label1.Text = "Đăng Nhập Tài Khoản";
            // 
            // NutDangNhap
            // 
            NutDangNhap.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDangNhap.Location = new Point(264, 220);
            NutDangNhap.Margin = new Padding(2, 1, 2, 1);
            NutDangNhap.Name = "NutDangNhap";
            NutDangNhap.Size = new Size(145, 36);
            NutDangNhap.TabIndex = 3;
            NutDangNhap.Text = "Đăng Nhập";
            NutDangNhap.UseVisualStyleBackColor = true;
            NutDangNhap.Click += NutDangNhap_Click;
            // 
            // DangKyLinkLabel
            // 
            DangKyLinkLabel.ActiveLinkColor = Color.RoyalBlue;
            DangKyLinkLabel.AutoSize = true;
            DangKyLinkLabel.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DangKyLinkLabel.ForeColor = SystemColors.Control;
            DangKyLinkLabel.LinkColor = SystemColors.Control;
            DangKyLinkLabel.Location = new Point(444, 195);
            DangKyLinkLabel.Margin = new Padding(2, 0, 2, 0);
            DangKyLinkLabel.Name = "DangKyLinkLabel";
            DangKyLinkLabel.Size = new Size(56, 15);
            DangKyLinkLabel.TabIndex = 5;
            DangKyLinkLabel.TabStop = true;
            DangKyLinkLabel.Text = "Đăng Ký";
            DangKyLinkLabel.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(162, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 21);
            label2.TabIndex = 7;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(166, 148);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            // 
            // TenDangNhap
            // 
            TenDangNhap.Location = new Point(166, 112);
            TenDangNhap.Margin = new Padding(2, 3, 2, 3);
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Size = new Size(313, 23);
            TenDangNhap.TabIndex = 9;
            // 
            // MatKhau
            // 
            MatKhau.Location = new Point(166, 169);
            MatKhau.Margin = new Padding(2, 3, 2, 3);
            MatKhau.Name = "MatKhau";
            MatKhau.PasswordChar = '*';
            MatKhau.Size = new Size(313, 23);
            MatKhau.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(303, 196);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(137, 15);
            label10.TabIndex = 12;
            label10.Text = "Bạn chưa có tài khoản?";
            // 
            // LabelQuenMatKhau
            // 
            LabelQuenMatKhau.ActiveLinkColor = Color.RoyalBlue;
            LabelQuenMatKhau.AutoSize = true;
            LabelQuenMatKhau.BackColor = Color.Transparent;
            LabelQuenMatKhau.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelQuenMatKhau.ForeColor = SystemColors.Control;
            LabelQuenMatKhau.LinkColor = SystemColors.Control;
            LabelQuenMatKhau.Location = new Point(162, 195);
            LabelQuenMatKhau.Margin = new Padding(2, 0, 2, 0);
            LabelQuenMatKhau.Name = "LabelQuenMatKhau";
            LabelQuenMatKhau.Size = new Size(95, 15);
            LabelQuenMatKhau.TabIndex = 14;
            LabelQuenMatKhau.TabStop = true;
            LabelQuenMatKhau.Text = "Quên Mật Khẩu";
            LabelQuenMatKhau.LinkClicked += LabelQuenMatKhau_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(524, 20);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 101);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // PhanDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(671, 365);
            Controls.Add(pictureBox2);
            Controls.Add(LabelQuenMatKhau);
            Controls.Add(label10);
            Controls.Add(MatKhau);
            Controls.Add(TenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DangKyLinkLabel);
            Controls.Add(NutDangNhap);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            Name = "PhanDangNhap";
            Text = "Đăng Nhập";
            Load += PhanDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NutDangNhap;
        private System.Windows.Forms.LinkLabel DangKyLinkLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenDangNhap;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private LinkLabel LabelQuenMatKhau;
        private PictureBox pictureBox2;
    }
}