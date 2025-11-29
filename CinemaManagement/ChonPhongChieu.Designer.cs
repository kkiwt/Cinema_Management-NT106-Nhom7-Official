namespace CinemaManagement
{
    partial class ChonPhongChieu
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
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            panel1 = new Panel();
            lblTenPhim = new Label();
            button15 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnQuaylai
            // 
            btnQuaylai.BackColor = SystemColors.Control;
            btnQuaylai.ForeColor = SystemColors.ControlText;
            btnQuaylai.Location = new Point(594, 2);
            btnQuaylai.Margin = new Padding(3, 2, 3, 2);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(82, 22);
            btnQuaylai.TabIndex = 0;
            btnQuaylai.Text = "Quay lại ";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // button18
            // 
            button18.Location = new Point(34, 208);
            button18.Margin = new Padding(3, 2, 3, 2);
            button18.Name = "button18";
            button18.Size = new Size(82, 22);
            button18.TabIndex = 18;
            button18.Text = "10:10";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(122, 208);
            button19.Margin = new Padding(3, 2, 3, 2);
            button19.Name = "button19";
            button19.Size = new Size(82, 22);
            button19.TabIndex = 19;
            button19.Text = "15:30";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(209, 208);
            button20.Margin = new Padding(3, 2, 3, 2);
            button20.Name = "button20";
            button20.Size = new Size(82, 22);
            button20.TabIndex = 20;
            button20.Text = "18:00";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(297, 208);
            button21.Margin = new Padding(3, 2, 3, 2);
            button21.Name = "button21";
            button21.Size = new Size(82, 22);
            button21.TabIndex = 21;
            button21.Text = "21:30";
            button21.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.None;
            panel1.Controls.Add(lblTenPhim);
            panel1.Controls.Add(button21);
            panel1.Controls.Add(button20);
            panel1.Controls.Add(button19);
            panel1.Controls.Add(button18);
            panel1.Controls.Add(button15);
            panel1.Controls.Add(btnQuaylai);
            panel1.Location = new Point(10, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 320);
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
            // button15
            // 
            button15.Location = new Point(34, 157);
            button15.Margin = new Padding(3, 2, 3, 2);
            button15.Name = "button15";
            button15.Size = new Size(198, 22);
            button15.TabIndex = 15;
            button15.Text = "Vi Du: 12/12/2025";
            button15.UseVisualStyleBackColor = true;
            // 
            // ChonPhongChieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ChonPhongChieu";
            Text = "ChonPhongChieu";
            Load += ChonPhongChieu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnQuaylai;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Panel panel1;
        private Button button15;
        private Label lblTenPhim;
    }
}