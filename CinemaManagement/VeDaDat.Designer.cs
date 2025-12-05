namespace CinemaManagement
{
    partial class VeDaDat
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
            PanelDuongDan = new Panel();
            label2 = new Label();
            DuongDanTaiKhoan = new Label();
            label1 = new Label();
            DuongDanVeDaDat = new Label();
            DuongDanTrangChu = new Label();
            PanelHeader = new Panel();
            Logo = new PictureBox();
            TimKiem = new TextBox();
            TaiKhoan = new Button();
            PhimHot = new Button();
            UuDai = new Button();
            MenuTaiKhoan = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            DangXuat = new ToolStripMenuItem();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            PanelDuongDan.SuspendLayout();
            PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            MenuTaiKhoan.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDuongDan
            // 
            PanelDuongDan.BackColor = Color.LightBlue;
            PanelDuongDan.Controls.Add(label2);
            PanelDuongDan.Controls.Add(DuongDanTaiKhoan);
            PanelDuongDan.Controls.Add(label1);
            PanelDuongDan.Controls.Add(DuongDanVeDaDat);
            PanelDuongDan.Controls.Add(DuongDanTrangChu);
            PanelDuongDan.ForeColor = Color.Transparent;
            PanelDuongDan.Location = new Point(0, 76);
            PanelDuongDan.Margin = new Padding(3, 2, 3, 2);
            PanelDuongDan.Name = "PanelDuongDan";
            PanelDuongDan.Size = new Size(1117, 39);
            PanelDuongDan.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(229, 12);
            label2.Name = "label2";
            label2.Size = new Size(13, 18);
            label2.TabIndex = 6;
            label2.Text = "-";
            // 
            // DuongDanTaiKhoan
            // 
            DuongDanTaiKhoan.AutoSize = true;
            DuongDanTaiKhoan.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanTaiKhoan.ForeColor = Color.Navy;
            DuongDanTaiKhoan.Location = new Point(147, 12);
            DuongDanTaiKhoan.Name = "DuongDanTaiKhoan";
            DuongDanTaiKhoan.Size = new Size(76, 18);
            DuongDanTaiKhoan.TabIndex = 3;
            DuongDanTaiKhoan.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(128, 12);
            label1.Name = "label1";
            label1.Size = new Size(13, 18);
            label1.TabIndex = 5;
            label1.Text = "-";
            // 
            // DuongDanVeDaDat
            // 
            DuongDanVeDaDat.AutoSize = true;
            DuongDanVeDaDat.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanVeDaDat.ForeColor = Color.Navy;
            DuongDanVeDaDat.Location = new Point(248, 12);
            DuongDanVeDaDat.Name = "DuongDanVeDaDat";
            DuongDanVeDaDat.Size = new Size(76, 18);
            DuongDanVeDaDat.TabIndex = 4;
            DuongDanVeDaDat.Text = "Vé đã đặt";
            // 
            // DuongDanTrangChu
            // 
            DuongDanTrangChu.AutoSize = true;
            DuongDanTrangChu.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DuongDanTrangChu.ForeColor = Color.Navy;
            DuongDanTrangChu.Location = new Point(47, 12);
            DuongDanTrangChu.Name = "DuongDanTrangChu";
            DuongDanTrangChu.Size = new Size(75, 18);
            DuongDanTrangChu.TabIndex = 2;
            DuongDanTrangChu.Text = "Trang chủ";
            // 
            // PanelHeader
            // 
            PanelHeader.BackColor = Color.FromArgb(30, 27, 58);
            PanelHeader.Controls.Add(Logo);
            PanelHeader.Controls.Add(TimKiem);
            PanelHeader.Controls.Add(TaiKhoan);
            PanelHeader.Controls.Add(PhimHot);
            PanelHeader.Controls.Add(UuDai);
            PanelHeader.Location = new Point(0, 0);
            PanelHeader.Margin = new Padding(3, 2, 3, 2);
            PanelHeader.Name = "PanelHeader";
            PanelHeader.Size = new Size(1117, 78);
            PanelHeader.TabIndex = 3;
            // 
            // Logo
            // 
            Logo.Location = new Point(107, 0);
            Logo.Margin = new Padding(3, 2, 3, 2);
            Logo.Name = "Logo";
            Logo.Size = new Size(91, 71);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 4;
            Logo.TabStop = false;
            // 
            // TimKiem
            // 
            TimKiem.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimKiem.Location = new Point(394, 28);
            TimKiem.Margin = new Padding(3, 2, 3, 2);
            TimKiem.Name = "TimKiem";
            TimKiem.Size = new Size(181, 26);
            TimKiem.TabIndex = 3;
            TimKiem.Text = "Tìm kiếm phim";
            // 
            // TaiKhoan
            // 
            TaiKhoan.BackColor = Color.FromArgb(255, 87, 87);
            TaiKhoan.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TaiKhoan.ForeColor = SystemColors.Control;
            TaiKhoan.Location = new Point(934, 18);
            TaiKhoan.Margin = new Padding(3, 2, 3, 2);
            TaiKhoan.Name = "TaiKhoan";
            TaiKhoan.Size = new Size(136, 42);
            TaiKhoan.TabIndex = 1;
            TaiKhoan.Text = "TÀI KHOẢN";
            TaiKhoan.UseVisualStyleBackColor = false;
            TaiKhoan.Click += TaiKhoan_Click;
            // 
            // PhimHot
            // 
            PhimHot.BackColor = Color.FromArgb(230, 57, 70);
            PhimHot.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhimHot.ForeColor = SystemColors.Control;
            PhimHot.Location = new Point(607, 18);
            PhimHot.Margin = new Padding(3, 2, 3, 2);
            PhimHot.Name = "PhimHot";
            PhimHot.Size = new Size(123, 42);
            PhimHot.TabIndex = 1;
            PhimHot.Text = "PHIM HOT";
            PhimHot.UseVisualStyleBackColor = false;
            // 
            // UuDai
            // 
            UuDai.BackColor = Color.FromArgb(230, 57, 70);
            UuDai.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UuDai.ForeColor = SystemColors.Control;
            UuDai.Location = new Point(769, 18);
            UuDai.Margin = new Padding(3, 2, 3, 2);
            UuDai.Name = "UuDai";
            UuDai.Size = new Size(123, 42);
            UuDai.TabIndex = 1;
            UuDai.Text = "ƯU ĐÃI";
            UuDai.UseVisualStyleBackColor = false;
            UuDai.Click += UuDai_Click;
            // 
            // MenuTaiKhoan
            // 
            MenuTaiKhoan.ImageScalingSize = new Size(20, 20);
            MenuTaiKhoan.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, DangXuat });
            MenuTaiKhoan.Name = "MenuTaiKhoan";
            MenuTaiKhoan.Size = new Size(240, 88);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = Color.FromArgb(255, 235, 235);
            toolStripMenuItem1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = Color.FromArgb(92, 77, 68);
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(239, 28);
            toolStripMenuItem1.Text = "Thông tin tài khoản ";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.BackColor = Color.FromArgb(247, 201, 201);
            toolStripMenuItem2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripMenuItem2.ForeColor = Color.FromArgb(92, 77, 68);
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(239, 28);
            toolStripMenuItem2.Text = "Vé đã đặt";
            // 
            // DangXuat
            // 
            DangXuat.BackColor = Color.FromArgb(255, 235, 235);
            DangXuat.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DangXuat.ForeColor = Color.FromArgb(92, 77, 68);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(239, 28);
            DangXuat.Text = "Đăng xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(47, 144);
            label3.Name = "label3";
            label3.Size = new Size(193, 29);
            label3.TabIndex = 5;
            label3.Text = "Danh sách vé đã đặt";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(51, 195);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1019, 371);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // VeDaDat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1117, 597);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(PanelDuongDan);
            Controls.Add(PanelHeader);
            Name = "VeDaDat";
            Text = "VeDaDat";
            Load += VeDaDat_Load;
            PanelDuongDan.ResumeLayout(false);
            PanelDuongDan.PerformLayout();
            PanelHeader.ResumeLayout(false);
            PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            MenuTaiKhoan.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelDuongDan;
        private Label label2;
        private Label DuongDanTaiKhoan;
        private Label label1;
        private Label DuongDanVeDaDat;
        private Label DuongDanTrangChu;
        private Panel PanelHeader;
        private PictureBox Logo;
        private TextBox TimKiem;
        private Button TaiKhoan;
        private Button PhimHot;
        private Button UuDai;
        private ContextMenuStrip MenuTaiKhoan;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem DangXuat;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}