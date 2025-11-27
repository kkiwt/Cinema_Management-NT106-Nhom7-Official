namespace CinemaManagement
{
    partial class DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMatKhau));
            label1 = new Label();
            lbMatKhauMoi = new Label();
            txtMatKhauMoi = new TextBox();
            pictureBox1 = new PictureBox();
            txtXacNhanMK = new TextBox();
            lbNhapLaiMK = new Label();
            NutXacNhan = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(220, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(215, 31);
            label1.TabIndex = 14;
            label1.Text = "Quên Mật Khẩu";
            // 
            // lbMatKhauMoi
            // 
            lbMatKhauMoi.AutoSize = true;
            lbMatKhauMoi.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMatKhauMoi.ForeColor = SystemColors.ControlLightLight;
            lbMatKhauMoi.Location = new Point(69, 142);
            lbMatKhauMoi.Margin = new Padding(2, 0, 2, 0);
            lbMatKhauMoi.Name = "lbMatKhauMoi";
            lbMatKhauMoi.Size = new Size(120, 18);
            lbMatKhauMoi.TabIndex = 16;
            lbMatKhauMoi.Text = "Mật khẩu mới: ";
            // 
            // txtMatKhauMoi
            // 
            txtMatKhauMoi.Location = new Point(193, 142);
            txtMatKhauMoi.Margin = new Padding(2, 3, 2, 3);
            txtMatKhauMoi.Name = "txtMatKhauMoi";
            txtMatKhauMoi.Size = new Size(326, 23);
            txtMatKhauMoi.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(529, 24);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 94);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(220, 193);
            txtXacNhanMK.Margin = new Padding(2, 3, 2, 3);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(299, 23);
            txtXacNhanMK.TabIndex = 25;
            // 
            // lbNhapLaiMK
            // 
            lbNhapLaiMK.AutoSize = true;
            lbNhapLaiMK.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNhapLaiMK.ForeColor = SystemColors.ControlLightLight;
            lbNhapLaiMK.Location = new Point(69, 193);
            lbNhapLaiMK.Margin = new Padding(2, 0, 2, 0);
            lbNhapLaiMK.Name = "lbNhapLaiMK";
            lbNhapLaiMK.Size = new Size(153, 18);
            lbNhapLaiMK.TabIndex = 24;
            lbNhapLaiMK.Text = "Nhập lại mật khẩu: ";
            // 
            // NutXacNhan
            // 
            NutXacNhan.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutXacNhan.Location = new Point(253, 250);
            NutXacNhan.Margin = new Padding(2, 1, 2, 1);
            NutXacNhan.Name = "NutXacNhan";
            NutXacNhan.Size = new Size(145, 36);
            NutXacNhan.TabIndex = 26;
            NutXacNhan.Text = "Xác Nhận";
            NutXacNhan.UseVisualStyleBackColor = true;
            NutXacNhan.Click += NutXacNhan_Click;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(655, 341);
            Controls.Add(NutXacNhan);
            Controls.Add(txtXacNhanMK);
            Controls.Add(lbNhapLaiMK);
            Controls.Add(pictureBox1);
            Controls.Add(txtMatKhauMoi);
            Controls.Add(lbMatKhauMoi);
            Controls.Add(label1);
            Name = "DoiMatKhau";
            Text = "DoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbMatKhauMoi;
        private TextBox txtMatKhauMoi;
        private PictureBox pictureBox1;
        private TextBox txtXacNhanMK;
        private Label lbNhapLaiMK;
        private Button NutXacNhan;
    }
}