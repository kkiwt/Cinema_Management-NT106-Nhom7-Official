using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CinemaManagement
{
    public partial class ChonSuatChieu : Form
    {
        private Phim currentFilm;
        private UserInfo currentUser;

        private DateTime selectedDate;
        private LichChieuCoDinh selectedSlot;

        private List<KhungGio> khungGioList = new();
        private List<PhongChieu> phongChieuList = new();
        private List<LichChieuCoDinh> lichChieuList = new();

        public ChonSuatChieu(Phim phim, UserInfo user)
        {
            InitializeComponent();
            currentFilm = phim;
            currentUser = user;
            this.Text = $"Chọn suất chiếu cho: {phim.TenPhim}";
            lblTenPhim.Text = phim.TenPhim;
        }

        private async void ChonSuatChieu_Load(object sender, EventArgs e)
        {
            await LoadDuLieuTuServer();
            InitNgayButtons();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async Task LoadDuLieuTuServer()
        {
            try
            {
                var client = new ClientTCP();

                // Lấy khung giờ
                string jsonKG = await client.SendMessageAsync("GET_KHUNGGIO");
                khungGioList = JsonSerializer.Deserialize<List<KhungGio>>(jsonKG);

                // Lấy phòng chiếu
                string jsonPhong = await client.SendMessageAsync("GET_PHONGCHIEU");
                phongChieuList = JsonSerializer.Deserialize<List<PhongChieu>>(jsonPhong);

                // Lấy lịch chiếu cố định
                string jsonLich = await client.SendMessageAsync($"GET_LICHCHIEU_CODINH|{currentFilm.IdPhim}");
                lichChieuList = JsonSerializer.Deserialize<List<LichChieuCoDinh>>(jsonLich);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu từ server: {ex.Message}");
            }
        }

        private void InitNgayButtons()
        {
            panelNgay.Controls.Clear();
            int x = 8, y = 8;
            int colCount = 0;
            int maxCols = 5;

            DateTime tuNgay = currentFilm.tungay ?? DateTime.Today;
            DateTime denNgay = currentFilm.denngay ?? DateTime.Today;

            for (DateTime date = tuNgay; date <= denNgay; date = date.AddDays(1))
            {
                var btnDate = new Button
                {
                    Text = date.ToString("dd/MM/yyyy"),
                    Width = 100,
                    Height = 40,
                    Tag = date,
                    BackColor = Color.White,
                    Enabled = date >= DateTime.Today,
                    Location = new Point(x, y)
                };
                btnDate.Tag = date;

                btnDate.Click += (s, ev) =>
                {
                    var clicked = (Button)s;
                    selectedDate = (DateTime)clicked.Tag;
                    HighlightSelectedDateButton(clicked);
                    LoadKhungGioTheoNgay(selectedDate);
                };

                panelNgay.Controls.Add(btnDate);

                x += btnDate.Width + 8;
                colCount++;
                if (colCount >= maxCols)
                {
                    colCount = 0;
                    x = 8;
                    y += btnDate.Height + 8;
                }
            }
            panelNgay.AutoScroll = true;
        }

        private void LoadKhungGioTheoNgay(DateTime ngay)
        {
            panelKhungGio.Controls.Clear();

            int x = 8, y = 8;
            int colCount = 0;
            int maxCols = 5;

            foreach (var slot in lichChieuList)
            {

                var kg = khungGioList.Find(k => k.idKG == slot.idkhunggio);
                var phong = phongChieuList.Find(p => p.IdPhongChieu == slot.idphongchieu);
                if (kg == null || phong == null) continue;
                TimeSpan TGKetThuc = kg.TGBatDau.Add(TimeSpan.FromMinutes((long)(currentFilm.ThoiLuong ?? 0)));

                string text = $"{kg.TGBatDau:hh\\:mm}-{TGKetThuc:hh\\:mm}";

                var btnSlot = new Button
                {
                    Text = text,
                    Width = 100,
                    Height = 40,
                    Tag = slot,
                    BackColor = Color.White,
                    Location = new Point(x, y)
                };

                // Disable nếu suất chiếu đã qua trong ngày hôm nay
                if (ngay.Date == DateTime.Today && kg.TGBatDau < DateTime.Now.TimeOfDay)
                {
                    btnSlot.Enabled = false;
                    btnSlot.BackColor = Color.LightGray;
                }

                btnSlot.Click += (s, ev) =>
                {
                    selectedSlot = (LichChieuCoDinh)((Button)s).Tag;
                    HighlightSelectedSlotButton((Button)s);
                };

                panelKhungGio.Controls.Add(btnSlot);

                x += btnSlot.Width + 8;
                colCount++;
                if (colCount >= maxCols)
                {
                    colCount = 0;
                    x = 8;
                    y += btnSlot.Height + 8;
                }
            }

            panelKhungGio.AutoScroll = true;
        }

        private void HighlightSelectedDateButton(Button selected)
        {
            foreach (Control c in panelNgay.Controls)
                if (c is Button b) b.BackColor = Color.White;
            selected.BackColor = Color.LightGreen;
        }

        private void HighlightSelectedSlotButton(Button selected)
        {
            foreach (Control c in panelKhungGio.Controls)
                if (c is Button b) b.BackColor = Color.White;
            selected.BackColor = Color.LightGreen;
        }

 

        private void NutChonGhe_Click(object sender, EventArgs e)
        {
            if (selectedDate == default || selectedSlot == null)
            {
                MessageBox.Show("Vui lòng chọn ngày và khung giờ chiếu.");
                return;
            }

            var chonGhe = new ChonGheNgoi(currentFilm, currentUser, selectedDate, selectedSlot, khungGioList, phongChieuList, lichChieuList);
            chonGhe.Owner = this;              
            chonGhe.ShowDialog();

        }
    }
}

