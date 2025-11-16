namespace CinemaManagement
{
    partial class PhanQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhanQuenMatKhau));
            TrangThaiGuiMail = new Label();
            MaPhucHoi = new TextBox();
            EmailPhucHoi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            NutXacNhan = new Button();
            label1 = new Label();
            NutGuiMaDenEmail = new Button();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // TrangThaiGuiMail
            // 
            TrangThaiGuiMail.AutoSize = true;
            TrangThaiGuiMail.BackColor = SystemColors.WindowText;
            TrangThaiGuiMail.Font = new Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TrangThaiGuiMail.ForeColor = SystemColors.Window;
            TrangThaiGuiMail.Location = new Point(373, 380);
            TrangThaiGuiMail.Name = "TrangThaiGuiMail";
            TrangThaiGuiMail.Size = new Size(179, 22);
            TrangThaiGuiMail.TabIndex = 19;
            TrangThaiGuiMail.Text = "Chưa Gửi Đến Email";
            // 
            // MaPhucHoi
            // 
            MaPhucHoi.Location = new Point(357, 265);
            MaPhucHoi.Margin = new Padding(3, 5, 3, 5);
            MaPhucHoi.Name = "MaPhucHoi";
            MaPhucHoi.PasswordChar = '*';
            MaPhucHoi.Size = new Size(398, 31);
            MaPhucHoi.TabIndex = 18;
            // 
            // EmailPhucHoi
            // 
            EmailPhucHoi.Location = new Point(310, 209);
            EmailPhucHoi.Margin = new Padding(3, 5, 3, 5);
            EmailPhucHoi.Name = "EmailPhucHoi";
            EmailPhucHoi.Size = new Size(445, 31);
            EmailPhucHoi.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(185, 263);
            label3.Name = "label3";
            label3.Size = new Size(166, 31);
            label3.TabIndex = 16;
            label3.Text = "Mã Xác Nhận:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Epilogue", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(185, 207);
            label2.Name = "label2";
            label2.Size = new Size(80, 31);
            label2.TabIndex = 15;
            label2.Text = "Email:";
            // 
            // NutXacNhan
            // 
            NutXacNhan.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutXacNhan.Location = new Point(357, 414);
            NutXacNhan.Margin = new Padding(3, 2, 3, 2);
            NutXacNhan.Name = "NutXacNhan";
            NutXacNhan.Size = new Size(207, 60);
            NutXacNhan.TabIndex = 14;
            NutXacNhan.Text = "Xác Nhận";
            NutXacNhan.UseVisualStyleBackColor = true;
            NutXacNhan.Click += NutXacNhan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Epilogue ExtraBold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(310, 60);
            label1.Name = "label1";
            label1.Size = new Size(339, 56);
            label1.TabIndex = 13;
            label1.Text = "Quên Mật Khẩu";
            // 
            // NutGuiMaDenEmail
            // 
            NutGuiMaDenEmail.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NutGuiMaDenEmail.Location = new Point(310, 315);
            NutGuiMaDenEmail.Margin = new Padding(3, 2, 3, 2);
            NutGuiMaDenEmail.Name = "NutGuiMaDenEmail";
            NutGuiMaDenEmail.Size = new Size(337, 45);
            NutGuiMaDenEmail.TabIndex = 20;
            NutGuiMaDenEmail.Text = "Gửi Mã Phục Hồi Đến Email";
            NutGuiMaDenEmail.UseVisualStyleBackColor = true;
            NutGuiMaDenEmail.Click += NutGuiMaDenEmail_Click;
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
            materialButton1.Location = new Point(670, 324);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(85, 36);
            materialButton1.TabIndex = 21;
            materialButton1.Text = "Quay Lại";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(744, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 153);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // PhanQuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(920, 513);
            Controls.Add(pictureBox1);
            Controls.Add(materialButton1);
            Controls.Add(NutGuiMaDenEmail);
            Controls.Add(TrangThaiGuiMail);
            Controls.Add(MaPhucHoi);
            Controls.Add(EmailPhucHoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NutXacNhan);
            Controls.Add(label1);
            Name = "PhanQuenMatKhau";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TrangThaiGuiMail;
        private TextBox MaPhucHoi;
        private TextBox EmailPhucHoi;
        private Label label3;
        private Label label2;
        private Button NutXacNhan;
        private Label label1;
        private Button NutGuiMaDenEmail;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox pictureBox1;
    }
}