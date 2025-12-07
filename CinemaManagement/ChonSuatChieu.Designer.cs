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
            lblTenPhim = new Label();
            flowLayoutPanelNgay = new FlowLayoutPanel();
            flowLayoutPanelKhungGio = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = SystemColors.Control;
            btnQuaylai.ForeColor = SystemColors.ControlText;
            btnQuaylai.Location = new Point(784, 11);
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
            panel1.Controls.Add(flowLayoutPanelKhungGio);
            panel1.Controls.Add(flowLayoutPanelNgay);
            panel1.Controls.Add(lblTenPhim);
            panel1.Controls.Add(btnQuaylai);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(879, 510);
            panel1.TabIndex = 0;
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
            // flowLayoutPanelNgay
            // 
            flowLayoutPanelNgay.Location = new Point(34, 55);
            flowLayoutPanelNgay.Name = "flowLayoutPanelNgay";
            flowLayoutPanelNgay.Size = new Size(832, 170);
            flowLayoutPanelNgay.TabIndex = 23;
            // 
            // flowLayoutPanelKhungGio
            // 
            flowLayoutPanelKhungGio.Location = new Point(34, 251);
            flowLayoutPanelKhungGio.Name = "flowLayoutPanelKhungGio";
            flowLayoutPanelKhungGio.Size = new Size(832, 236);
            flowLayoutPanelKhungGio.TabIndex = 24;
            // 
            // ChonSuatChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(901, 530);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChonSuatChieu";
            Text = "ChonPhongChieu";
            Load += ChonPhongChieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuaylai;
        private Panel panel1;
        private Label lblTenPhim;
        private FlowLayoutPanel flowLayoutPanelKhungGio;
        private FlowLayoutPanel flowLayoutPanelNgay;
    }
}