
using System;

namespace CinemaManagement
{
    /// <summary>
    /// Model ánh xạ JSON trả về từ RPC get_ve_dadat:
    /// { "IdVe": 1024, "NgayChieu": "2025-12-05", "GioChieu": "19:30:00", "Ghe": "E12", "GiaVe": 85000 }
    /// </summary>
    public class VeDat
    {
        public string IdVe { get; set; }            // Mã vé
        public DateTime? NgayChieu { get; set; }  // Ngày chiếu (date hoặc string ISO)
        public TimeSpan? GioChieu { get; set; }   // Giờ chiếu (time)
        public string Ghe { get; set; }           // Ghế (text)
        public decimal GiaVe { get; set; }        // Giá vé
        //
        // (Tuỳ chọn) mở rộng khi RPC bổ sung:
        public string TenPhim { get; set; }       // tên phim
        public string PosterUrl { get; set; }     // link poster công khai
    }
}
