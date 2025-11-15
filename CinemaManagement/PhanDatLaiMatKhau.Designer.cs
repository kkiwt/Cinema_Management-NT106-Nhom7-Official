namespace CinemaManagement
{
    partial class PhanDatLaiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanDatLaiMatKhau));
            MatKhau = new TextBox();
            MatKhauMoi = new TextBox();
            NhapLaiMatKhauMoi = new Label();
            label2 = new Label();
            label1 = new Label();
            NutXacNhan = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MatKhau
            // 
            MatKhau.Location = new Point(253, 265);
            MatKhau.Margin = new Padding(3, 5, 3, 5);
            MatKhau.Name = "MatKhau";
            MatKhau.PasswordChar = '*';
            MatKhau.Size = new Size(445, 31);
            MatKhau.TabIndex = 15;
            // 
            // MatKhauMoi
            // 
            MatKhauMoi.Location = new Point(253, 169);
            MatKhauMoi.Margin = new Padding(3, 5, 3, 5);
            MatKhauMoi.Name = "MatKhauMoi";
            MatKhauMoi.Size = new Size(445, 31);
            MatKhauMoi.TabIndex = 14;
            // 
            // NhapLaiMatKhauMoi
            // 
            NhapLaiMatKhauMoi.AutoSize = true;
            NhapLaiMatKhauMoi.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NhapLaiMatKhauMoi.ForeColor = SystemColors.ControlLightLight;
            NhapLaiMatKhauMoi.Location = new Point(253, 229);
            NhapLaiMatKhauMoi.Name = "NhapLaiMatKhauMoi";
            NhapLaiMatKhauMoi.Size = new Size(277, 31);
            NhapLaiMatKhauMoi.TabIndex = 13;
            NhapLaiMatKhauMoi.Text = "Nhập Laị Mật Khẩu Mới:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(247, 133);
            label2.Name = "label2";
            label2.Size = new Size(239, 31);
            label2.TabIndex = 12;
            label2.Text = "Nhập Mật Khẩu Mới:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Epilogue ExtraBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(271, 56);
            label1.Name = "label1";
            label1.Size = new Size(369, 56);
            label1.TabIndex = 11;
            label1.Text = "Đặt Lại Mật Khẩu";
            // 
            // NutXacNhan
            // 
            NutXacNhan.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutXacNhan.Location = new Point(365, 335);
            NutXacNhan.Margin = new Padding(3, 2, 3, 2);
            NutXacNhan.Name = "NutXacNhan";
            NutXacNhan.Size = new Size(207, 60);
            NutXacNhan.TabIndex = 16;
            NutXacNhan.Text = "Xác Nhận";
            NutXacNhan.UseVisualStyleBackColor = true;
            NutXacNhan.Click += NutXacNhan_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(758, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 153);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // PhanDatLaiMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(961, 527);
            Controls.Add(pictureBox1);
            Controls.Add(NutXacNhan);
            Controls.Add(MatKhau);
            Controls.Add(MatKhauMoi);
            Controls.Add(NhapLaiMatKhauMoi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PhanDatLaiMatKhau";
            Text = "PhanDatLaiMatKhau";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MatKhau;
        private TextBox MatKhauMoi;
        private Label NhapLaiMatKhauMoi;
        private Label label2;
        private Label label1;
        private Button NutXacNhan;
        private PictureBox pictureBox1;
    }
}