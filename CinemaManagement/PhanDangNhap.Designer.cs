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
            linkLabel1 = new LinkLabel();
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
            label1.Location = new Point(255, 73);
            label1.Name = "label1";
            label1.Size = new Size(454, 56);
            label1.TabIndex = 2;
            label1.Text = "Đăng Nhập Tài Khoản";
            // 
            // NutDangNhap
            // 
            NutDangNhap.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutDangNhap.Location = new Point(381, 364);
            NutDangNhap.Margin = new Padding(3, 2, 3, 2);
            NutDangNhap.Name = "NutDangNhap";
            NutDangNhap.Size = new Size(207, 60);
            NutDangNhap.TabIndex = 3;
            NutDangNhap.Text = "Đăng Nhập";
            NutDangNhap.UseVisualStyleBackColor = true;
            NutDangNhap.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.RoyalBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.Control;
            linkLabel1.LinkColor = SystemColors.Control;
            linkLabel1.Location = new Point(626, 319);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(83, 21);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng Ký";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(231, 150);
            label2.Name = "label2";
            label2.Size = new Size(179, 31);
            label2.TabIndex = 7;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(237, 246);
            label3.Name = "label3";
            label3.Size = new Size(120, 31);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            // 
            // TenDangNhap
            // 
            TenDangNhap.Location = new Point(237, 186);
            TenDangNhap.Margin = new Padding(3, 5, 3, 5);
            TenDangNhap.Name = "TenDangNhap";
            TenDangNhap.Size = new Size(445, 31);
            TenDangNhap.TabIndex = 9;
            // 
            // MatKhau
            // 
            MatKhau.Location = new Point(237, 282);
            MatKhau.Margin = new Padding(3, 5, 3, 5);
            MatKhau.Name = "MatKhau";
            MatKhau.PasswordChar = '*';
            MatKhau.Size = new Size(445, 31);
            MatKhau.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(420, 318);
            label10.Name = "label10";
            label10.Size = new Size(200, 22);
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
            LabelQuenMatKhau.Location = new Point(231, 318);
            LabelQuenMatKhau.Name = "LabelQuenMatKhau";
            LabelQuenMatKhau.Size = new Size(142, 21);
            LabelQuenMatKhau.TabIndex = 14;
            LabelQuenMatKhau.TabStop = true;
            LabelQuenMatKhau.Text = "Quên Mật Khẩu";
            LabelQuenMatKhau.LinkClicked += LabelQuenMatKhau_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(749, 34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(171, 168);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // PhanDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(958, 608);
            Controls.Add(pictureBox2);
            Controls.Add(LabelQuenMatKhau);
            Controls.Add(label10);
            Controls.Add(MatKhau);
            Controls.Add(TenDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(NutDangNhap);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
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