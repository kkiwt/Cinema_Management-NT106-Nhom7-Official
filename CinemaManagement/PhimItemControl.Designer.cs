namespace CinemaManagement
{
    partial class PhimItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PosterPhim = new PictureBox();
            TenPhim = new Label();
            ChiTiet = new Button();
            DatVe = new Button();
            ((System.ComponentModel.ISupportInitialize)PosterPhim).BeginInit();
            SuspendLayout();
            // 
            // PosterPhim
            // 
            PosterPhim.Location = new Point(21, 3);
            PosterPhim.Name = "PosterPhim";
            PosterPhim.Size = new Size(258, 312);
            PosterPhim.SizeMode = PictureBoxSizeMode.Zoom;
            PosterPhim.TabIndex = 6;
            PosterPhim.TabStop = false;
            // 
            // TenPhim
            // 
            TenPhim.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenPhim.Location = new Point(29, 318);
            TenPhim.Name = "TenPhim";
            TenPhim.Size = new Size(250, 50);
            TenPhim.TabIndex = 7;
            TenPhim.Text = "NGÀY XƯA CÓ MỘT CHUYỆN TÌNH";
            TenPhim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChiTiet
            // 
            ChiTiet.BackColor = Color.Pink;
            ChiTiet.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChiTiet.ForeColor = Color.Maroon;
            ChiTiet.Location = new Point(21, 371);
            ChiTiet.Name = "ChiTiet";
            ChiTiet.Size = new Size(105, 34);
            ChiTiet.TabIndex = 8;
            ChiTiet.Text = "CHI TIẾT";
            ChiTiet.UseVisualStyleBackColor = false;
            ChiTiet.Click += ChiTiet_Click;
            // 
            // DatVe
            // 
            DatVe.BackColor = Color.FromArgb(230, 57, 70);
            DatVe.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DatVe.ForeColor = Color.White;
            DatVe.Location = new Point(174, 371);
            DatVe.Name = "DatVe";
            DatVe.Size = new Size(105, 34);
            DatVe.TabIndex = 9;
            DatVe.Text = "ĐẶT VÉ";
            DatVe.UseVisualStyleBackColor = false;
            DatVe.Click += DatVePhim_Click;
            // 
            // PhimItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 3, 27);
            Controls.Add(DatVe);
            Controls.Add(ChiTiet);
            Controls.Add(TenPhim);
            Controls.Add(PosterPhim);
            ForeColor = SystemColors.ControlLight;
            Name = "PhimItemControl";
            Size = new Size(295, 434);
            ((System.ComponentModel.ISupportInitialize)PosterPhim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PosterPhim;
        private Label TenPhim;
        private Button ChiTiet;
        private Button DatVe;
    }
}
