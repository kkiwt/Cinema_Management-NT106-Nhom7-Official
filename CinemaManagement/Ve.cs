
using System;

namespace CinemaManagement
{
    /// <summary>
    /// Model ánh xạ JSON trả về từ RPC get_ve_dadat:
    /// { "IdVe": 1024, "NgayChieu": "2025-12-05", "GioChieu": "19:30:00", "Ghe": "E12", "GiaVe": 85000 }
    /// </summary>

    public class VeDat
    {
        public string IdVe { get; set; }
        public DateTime? NgayChieu { get; set; }   // v."NgayDat"
        public TimeSpan? GioChieu { get; set; }   // kg."TGBatDau"
        public DateTime? ThoiDiemChieu { get; set; }   // Ngày + giờ
        public string Ghe { get; set; }
        public decimal? GiaVe { get; set; }
        public string TenPhim { get; set; }
        public string PosterUrl { get; set; }
        public string IdPhim { get; set; }
        public string IdKhungGio { get; set; }
        public string IdPhongChieu { get; set; }
        public string TenPhongChieu { get; set; }   // GHÉP: C01P04
        public string TenBapNuoc { get; set; }
        public decimal? GiaBapNuoc { get; set; }
        public decimal? TongTien { get; set; }
    }

}
