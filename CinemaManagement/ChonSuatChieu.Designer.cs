namespace CinemaManagement
{
    partial class ChonSuatChieu
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
            btnQuaylai = new Button();
            panel1 = new Panel();
            panelKhungGio = new Panel();
            panelNgay = new Panel();
            lblTenPhim = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = SystemColors.Control;
            btnQuaylai.ForeColor = SystemColors.ControlText;
            btnQuaylai.Location = new Point(445, 11);
            btnQuaylai.Margin = new Padding(3, 2, 3, 2);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(82, 22);
            btnQuaylai.TabIndex = 0;
            btnQuaylai.Text = "Quay lại ";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panelKhungGio);
            panel1.Controls.Add(panelNgay);
            panel1.Controls.Add(lblTenPhim);
            panel1.Controls.Add(btnQuaylai);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 437);
            panel1.TabIndex = 0;
            // 
            // panelKhungGio
            // 
            panelKhungGio.Location = new Point(34, 210);
            panelKhungGio.Name = "panelKhungGio";
            panelKhungGio.Size = new Size(493, 164);
            panelKhungGio.TabIndex = 24;
            // 
            // panelNgay
            // 
            panelNgay.BackgroundImageLayout = ImageLayout.None;
            panelNgay.Location = new Point(34, 38);
            panelNgay.Name = "panelNgay";
            panelNgay.Size = new Size(493, 145);
            panelNgay.TabIndex = 23;
            // 
            // lblTenPhim
            // 
            lblTenPhim.AutoSize = true;
            lblTenPhim.ForeColor = SystemColors.Control;
            lblTenPhim.Location = new Point(34, 18);
            lblTenPhim.Name = "lblTenPhim";
            lblTenPhim.Size = new Size(57, 15);
            lblTenPhim.TabIndex = 22;
            lblTenPhim.Text = "Tên Phim";
            // 
            // button1
            // 
            button1.Location = new Point(452, 395);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "Chọn ghế";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ChonSuatChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(583, 457);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChonSuatChieu";
            Text = "ChonSuatChieu";
            Load += ChonSuatChieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuaylai;
        private Panel panel1;
        private Label lblTenPhim;
        private Panel panelKhungGio;
        private Panel panelNgay;
        private Button button1;
    }
}