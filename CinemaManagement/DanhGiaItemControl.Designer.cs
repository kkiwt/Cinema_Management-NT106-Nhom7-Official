namespace CinemaManagement
{
    partial class DanhGiaItemControl
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
            TenNguoiDung = new Label();
            Sao = new Label();
            Xoa = new Button();
            NoiDungDanhGia = new TextBox();
            SuspendLayout();
            // 
            // TenNguoiDung
            // 
            TenNguoiDung.AutoSize = true;
            TenNguoiDung.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenNguoiDung.ForeColor = SystemColors.ControlLightLight;
            TenNguoiDung.Location = new Point(26, 4);
            TenNguoiDung.Name = "TenNguoiDung";
            TenNguoiDung.Size = new Size(161, 22);
            TenNguoiDung.TabIndex = 25;
            TenNguoiDung.Text = "Tên người dùng";
            // 
            // Sao
            // 
            Sao.AutoSize = true;
            Sao.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Sao.ForeColor = Color.Gold;
            Sao.Location = new Point(26, 26);
            Sao.Name = "Sao";
            Sao.Size = new Size(263, 35);
            Sao.TabIndex = 27;
            Sao.Text = "                               ";
            // 
            // Xoa
            // 
            Xoa.BackColor = Color.Pink;
            Xoa.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Xoa.ForeColor = Color.Maroon;
            Xoa.Location = new Point(414, 26);
            Xoa.Margin = new Padding(3, 2, 3, 2);
            Xoa.Name = "Xoa";
            Xoa.Size = new Size(66, 36);
            Xoa.TabIndex = 36;
            Xoa.Text = "XÓA";
            Xoa.UseVisualStyleBackColor = false;
            Xoa.Click += Xoa_Click;
            // 
            // NoiDungDanhGia
            // 
            NoiDungDanhGia.BackColor = Color.FromArgb(4, 21, 49);
            NoiDungDanhGia.BorderStyle = BorderStyle.None;
            NoiDungDanhGia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoiDungDanhGia.ForeColor = Color.White;
            NoiDungDanhGia.Location = new Point(26, 70);
            NoiDungDanhGia.Multiline = true;
            NoiDungDanhGia.Name = "NoiDungDanhGia";
            NoiDungDanhGia.ReadOnly = true;
            NoiDungDanhGia.ScrollBars = ScrollBars.Both;
            NoiDungDanhGia.Size = new Size(454, 49);
            NoiDungDanhGia.TabIndex = 72;
            NoiDungDanhGia.Text = "Konnichiwa";
            // 
            // DanhGiaItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 21, 49);
            Controls.Add(NoiDungDanhGia);
            Controls.Add(Xoa);
            Controls.Add(TenNguoiDung);
            Controls.Add(Sao);
            ForeColor = SystemColors.ControlLightLight;
            Name = "DanhGiaItemControl";
            Size = new Size(499, 132);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TenNguoiDung;
        private Button Xoa;
        private Label Sao;
        private TextBox NoiDungDanhGia;
    }
}
