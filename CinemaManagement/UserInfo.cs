using System;

namespace CinemaManagement
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string KhuVuc { get; set; }
        public string GioiTinh { get; set; }

        public string IDUser = "00";  // tam thoi
        public bool LaNhanVien { get; set; } = false;
    }
}
