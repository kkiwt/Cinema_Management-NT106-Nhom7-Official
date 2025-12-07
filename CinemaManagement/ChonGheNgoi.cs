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
using Supabase;

namespace CinemaManagement
{
    public partial class ChonGheNgoi : Form
    {
        private readonly Phim _phim;
        private readonly UserInfo _user;
        private readonly DateTime _date;
        private readonly LichChieuCoDinh _slot;

        private List<KhungGio> khungGioList = new List<KhungGio>();
        private List<PhongChieu> phongChieuList = new List<PhongChieu>();
        private List<LichChieuCoDinh> lichChieuList = new List<LichChieuCoDinh>();
        private readonly List<string> _selectedSeats = new List<string>();

        public ChonGheNgoi(Phim phim, UserInfo user, DateTime date, LichChieuCoDinh slot, List<KhungGio> kg, List<PhongChieu> pc, List<LichChieuCoDinh> lc)
        {
            InitializeComponent();
            _phim = phim;
            _user = user;
            _date = date.Date;
            _slot = slot;
            khungGioList = kg;
            phongChieuList = pc;
            lichChieuList = lc;
        }

        private async void ChonGheNgoi_Load(object sender, EventArgs e)
        {
            await LoadSeatStatus();
        }
        private async Task LoadSeatStatus()
        {
            try
            {
                var client = new ClientTCP();
                string jsonSeats = await client.SendMessageAsync(
                    $"GET_SEATSTATUS|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}");
                if (jsonSeats.StartsWith("ERROR")) return;

                var seatStatusList = JsonSerializer.Deserialize<List<SeatStatus>>(jsonSeats);

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn && btn.Text != null)
                    {
                        string seatText = btn.Text;
                        string seatId = MapSeatId(seatText);

                        var status = seatStatusList.Find(s => s.idghe == seatId)?.status;

                        if (status == "available") btn.BackColor = Color.LightGreen;
                        else if (status == "holding") btn.BackColor = Color.Yellow;
                        else if (status == "sold") btn.BackColor = Color.Red;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải trạng thái ghế: {ex.Message}");
            }
        }
        private async void AllButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            string seatText = btn.Text;             // "A1"
            string seatId = MapSeatId(seatText);    // "GA01"

            if (btn.BackColor == Color.Red) return;

            var client = new ClientTCP();
            string resHold = await client.SendMessageAsync(
                $"ADD_HOLDSEAT|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}");

            if (resHold.StartsWith("ERROR"))
            {
                MessageBox.Show($"Ghế {seatText} ({seatId}) đã bị giữ hoặc đã bán.");
            }
            else
            {
                _selectedSeats.Add(seatId);
                btn.BackColor = Color.Yellow;
            }
        }
        private async void btnThanhToan_Click(object sender, EventArgs e)
        {
            var client = new ClientTCP();

            foreach (var seatId in _selectedSeats)
            {
                string resVe = await client.SendMessageAsync(
                    $"SET_VE|{_phim.IdPhim}|{_slot.idkhunggio}|{_slot.idphongchieu}|{_date:yyyy-MM-dd}|{seatId}|{_user.IDUser}|100000");

                if (resVe.StartsWith("ERROR"))
                {
                    MessageBox.Show($"Ghế {seatId} mua thất bại: {resVe}");
                }
                else
                {
                    MarkSeatSold(seatId);
                }
            }
        }
        private void MarkSeatSold(string seatId)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Tag?.ToString() == seatId)
                {
                    btn.BackColor = Color.Red;
                }
            }
        }
        private string MapSeatId(string text)
        {
            char row = text[0];
            int col = int.Parse(text.Substring(1)); 
            return $"G{row}{col:D2}";
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
