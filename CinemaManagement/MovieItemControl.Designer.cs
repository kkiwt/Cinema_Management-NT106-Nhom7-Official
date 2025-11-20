namespace CinemaManagement
{
    partial class MovieItemControl
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
            ChiTietPhim = new Button();
            DatVePhim = new Button();
            TenPhim = new Label();
            PosterPhim = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PosterPhim).BeginInit();
            SuspendLayout();
            // 
            // ChiTietPhim
            // 
            ChiTietPhim.BackColor = Color.Pink;
            ChiTietPhim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChiTietPhim.ForeColor = Color.Maroon;
            ChiTietPhim.Location = new Point(50, 427);
            ChiTietPhim.Name = "ChiTietPhim";
            ChiTietPhim.Size = new Size(108, 42);
            ChiTietPhim.TabIndex = 24;
            ChiTietPhim.Text = "CHI TIẾT";
            ChiTietPhim.UseVisualStyleBackColor = false;
            ChiTietPhim.Click += ChiTietPhim_Click;
            // 
            // DatVePhim
            // 
            DatVePhim.BackColor = Color.FromArgb(230, 57, 70);
            DatVePhim.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatVePhim.ForeColor = SystemColors.Control;
            DatVePhim.Location = new Point(198, 425);
            DatVePhim.Name = "DatVePhim";
            DatVePhim.Size = new Size(108, 44);
            DatVePhim.TabIndex = 25;
            DatVePhim.Text = "ĐẶT VÉ";
            DatVePhim.UseCompatibleTextRendering = true;
            DatVePhim.UseVisualStyleBackColor = false;
            DatVePhim.Click += DatVePhim_Click;
            // 
            // TenPhim
            // 
            TenPhim.AutoSize = true;
            TenPhim.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenPhim.ForeColor = SystemColors.Control;
            TenPhim.Location = new Point(32, 384);
            TenPhim.Name = "TenPhim";
            TenPhim.Size = new Size(51, 27);
            TenPhim.TabIndex = 26;
            TenPhim.Text = "555";
            TenPhim.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PosterPhim
            // 
            PosterPhim.Location = new Point(32, 23);
            PosterPhim.Name = "PosterPhim";
            PosterPhim.Size = new Size(274, 329);
            PosterPhim.SizeMode = PictureBoxSizeMode.Zoom;
            PosterPhim.TabIndex = 27;
            PosterPhim.TabStop = false;
            // 
            // MovieItemControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 3, 27);
            Controls.Add(PosterPhim);
            Controls.Add(TenPhim);
            Controls.Add(DatVePhim);
            Controls.Add(ChiTietPhim);
            Name = "MovieItemControl";
            Size = new Size(342, 494);
            ((System.ComponentModel.ISupportInitialize)PosterPhim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ChiTietPhim;
        private Button DatVePhim;
        private Label TenPhim;
        private PictureBox PosterPhim;
    }
}
