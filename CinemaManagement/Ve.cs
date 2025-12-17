
using System;

namespace CinemaManagement
{

    public class VeDat
    {
        public string IdVe { get; set; }
        public DateTime? NgayChieu { get; set; }   
        public TimeSpan? GioChieu { get; set; }   
        public DateTime? ThoiDiemChieu { get; set; }   
        public string Ghe { get; set; }
        public decimal? GiaVe { get; set; }
        public string TenPhim { get; set; }
        public string PosterUrl { get; set; }
        public string IdPhim { get; set; }
        public string IdKhungGio { get; set; }
        public string IdPhongChieu { get; set; }
        public string TenPhongChieu { get; set; }   
        public string TenBapNuoc { get; set; }
        public decimal? GiaBapNuoc { get; set; }
        public decimal? TongTien { get; set; }
    }

}
