using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaManagement
{
    public class TaiKhoan
    {
        public string IdTaiKhoan { get; set; }
        public string HoTen { get; set; }
        public string Username { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int? SoVeDaMua { get; set; }
        public bool? LaNhanVien { get; set; }
        public string SoDienThoai { get; set; }

        public TaiKhoan() { }
        public TaiKhoan(string id, string hoTen, string username, string gioiTinh, DateTime ngaySinh, string email, string matKhau, int? soVe, bool? laNV, string sdt)
        {
            IdTaiKhoan = id;
            HoTen = hoTen;
            Username = username;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            Email = email;
            MatKhau = matKhau;
            SoVeDaMua = soVe;
            LaNhanVien = laNV;
            SoDienThoai = sdt;
        }

        public static List<TaiKhoan> DanhSachTaiKhoan = new List<TaiKhoan>();
        public static Dictionary<string, TaiKhoan> MapTaiKhoan = new Dictionary<string, TaiKhoan>();

        public static void Add(TaiKhoan tk)
        {
            DanhSachTaiKhoan.Add(tk);
            MapTaiKhoan[tk.IdTaiKhoan] = tk;
        }

        public static TaiKhoan FindById(string id)
        {
            return MapTaiKhoan.ContainsKey(id) ? MapTaiKhoan[id] : null;
        }

        public static void Remove(string id)
        {
            var tk = FindById(id);
            if (tk != null)
            {
                DanhSachTaiKhoan.Remove(tk);
                MapTaiKhoan.Remove(id);
            }
        }
    }

    public class PhongChieu
    {
        public string IdPhongChieu { get; set; }
        public string TenPhongChieu { get; set; }
        public int SoLuongGhe { get; set; }

        public PhongChieu() { }
        public PhongChieu(string id, string ten, int soLuong)
        {
            IdPhongChieu = id;
            TenPhongChieu = ten;
            SoLuongGhe = soLuong;
        }

        public static List<PhongChieu> DanhSachPhongChieu = new List<PhongChieu>();
        public static Dictionary<string, PhongChieu> MapPhongChieu = new Dictionary<string, PhongChieu>();

        public static void Add(PhongChieu pc)
        {
            DanhSachPhongChieu.Add(pc);
            MapPhongChieu[pc.IdPhongChieu] = pc;
        }

        public static PhongChieu FindById(string id)
        {
            return MapPhongChieu.ContainsKey(id) ? MapPhongChieu[id] : null;
        }

        public static void Remove(string id)
        {
            var pc = FindById(id);
            if (pc != null)
            {
                DanhSachPhongChieu.Remove(pc);
                MapPhongChieu.Remove(id);
            }
        }
    }

    public class Ve
    {
        public string IdVe { get; set; }
        public string IdPhim { get; set; }
        public string IdTaiKhoan { get; set; }
        public string IdPhongChieu { get; set; }
        public string IdGhe { get; set; }
        public string IdSuatChieu { get; set; }

        public Ve() { }
        public Ve(string idVe, string idPhim, string idTK, string idPC, string idGhe, string idSC)
        {
            IdVe = idVe;
            IdPhim = idPhim;
            IdTaiKhoan = idTK;
            IdPhongChieu = idPC;
            IdGhe = idGhe;
            IdSuatChieu = idSC;
        }

        public static List<Ve> DanhSachVe = new List<Ve>();
        public static Dictionary<string, Ve> MapVe = new Dictionary<string, Ve>();

        public static void Add(Ve ve)
        {
            DanhSachVe.Add(ve);
            MapVe[ve.IdVe] = ve;
        }

        public static Ve FindById(string id)
        {
            return MapVe.ContainsKey(id) ? MapVe[id] : null;
        }

        public static void Remove(string id)
        {
            var ve = FindById(id);
            if (ve != null)
            {
                DanhSachVe.Remove(ve);
                MapVe.Remove(id);
            }
        }
    }

    public class BapNuoc
    {
        public string IdBapNuoc { get; set; }
        public string TenBapNuoc { get; set; }
        public decimal? GiaTien { get; set; }
        public int? SoLuong { get; set; }

        public BapNuoc() { }
        public BapNuoc(string id, string ten, decimal? gia, int? soLuong)
        {
            IdBapNuoc = id;
            TenBapNuoc = ten;
            GiaTien = gia;
            SoLuong = soLuong;
        }

        public static List<BapNuoc> DanhSachBapNuoc = new List<BapNuoc>();
        public static Dictionary<string, BapNuoc> MapBapNuoc = new Dictionary<string, BapNuoc>();

        public static void Add(BapNuoc bn)
        {
            DanhSachBapNuoc.Add(bn);
            MapBapNuoc[bn.IdBapNuoc] = bn;
        }

        public static BapNuoc FindById(string id)
        {
            return MapBapNuoc.ContainsKey(id) ? MapBapNuoc[id] : null;
        }

        public static void Remove(string id)
        {
            var bn = FindById(id);
            if (bn != null)
            {
                DanhSachBapNuoc.Remove(bn);
                MapBapNuoc.Remove(id);
            }
        }
    }

    public class Ghe
    {
        public string IdGhe { get; set; }
        public string IdPhongChieu { get; set; }
        public string HangMuc { get; set; }
        public decimal? HeSoGhe { get; set; }

        public Ghe() { }
        public Ghe(string id, string idPC, string hangMuc, decimal? heSo)
        {
            IdGhe = id;
            IdPhongChieu = idPC;
            HangMuc = hangMuc;
            HeSoGhe = heSo;
        }

        public static List<Ghe> DanhSachGhe = new List<Ghe>();
        public static Dictionary<string, Ghe> MapGhe = new Dictionary<string, Ghe>();

        public static void Add(Ghe ghe)
        {
            DanhSachGhe.Add(ghe);
            MapGhe[ghe.IdGhe] = ghe;
        }

        public static Ghe FindById(string id)
        {
            return MapGhe.ContainsKey(id) ? MapGhe[id] : null;
        }

        public static void Remove(string id)
        {
            var ghe = FindById(id);
            if (ghe != null)
            {
                DanhSachGhe.Remove(ghe);
                MapGhe.Remove(id);
            }
        }
    }

    public class Review
    {
        public string IdReview { get; set; }
        public string IdTaiKhoan { get; set; }
        public string IdPhim { get; set; }
        public string NoiDung { get; set; }
        public int? SoSao { get; set; }

        public Review() { }
        public Review(string id, string idTK, string idPhim, string noiDung, int? soSao)
        {
            IdReview = id;
            IdTaiKhoan = idTK;
            IdPhim = idPhim;
            NoiDung = noiDung;
            SoSao = soSao;
        }

        public static List<Review> DanhSachReview = new List<Review>();
        public static Dictionary<string, Review> MapReview = new Dictionary<string, Review>();

        public static void Add(Review rv)
        {
            DanhSachReview.Add(rv);
            MapReview[rv.IdReview] = rv;
        }

        public static Review FindById(string id)
        {
            return MapReview.ContainsKey(id) ? MapReview[id] : null;
        }

        public static void Remove(string id)
        {
            var rv = FindById(id);
            if (rv != null)
            {
                DanhSachReview.Remove(rv);
                MapReview.Remove(id);
            }
        }
    }
    public class ReviewDisplay
    {
        [JsonPropertyName("idreview")]
        public string IdReview { get; set; }

        [JsonPropertyName("idtaikhoan")]
        public string IdTaiKhoan { get; set; }

        [JsonPropertyName("hoten")]
        public string HoTen { get; set; } 

        [JsonPropertyName("noidung")]
        public string NoiDung { get; set; }

        [JsonPropertyName("sosao")]
        public int SoSao { get; set; }
  
    }

    public class ReviewSummary
    {
        [JsonPropertyName("avg_rating")]
        public float AvgRating { get; set; }

        [JsonPropertyName("total_reviews")]
        public int TotalReviews { get; set; }

        [JsonPropertyName("latest_reviews")]
        public List<ReviewDisplay> LatestReviews { get; set; }
    }
    

    public class GiamGia
    {
        public string IdGiamGia { get; set; }
        public string LoaiGiamGia { get; set; }
        public DateTime? TuNgay { get; set; }
        public DateTime? DenNgay { get; set; }
        public decimal? TiLeGiam { get; set; }
        public string IdPhim { get; set; }

        public GiamGia() { }
        public GiamGia(string id, string loai, DateTime? tuNgay, DateTime? denNgay, decimal? tiLe, string idPhim)
        {
            IdGiamGia = id;
            LoaiGiamGia = loai;
            TuNgay = tuNgay;
            DenNgay = denNgay;
            TiLeGiam = tiLe;
            IdPhim = idPhim;
        }

        public static List<GiamGia> DanhSachGiamGia = new List<GiamGia>();
        public static Dictionary<string, GiamGia> MapGiamGia = new Dictionary<string, GiamGia>();

        public static void Add(GiamGia gg)
        {
            DanhSachGiamGia.Add(gg);
            MapGiamGia[gg.IdGiamGia] = gg;
        }

        public static GiamGia FindById(string id)
        {
            return MapGiamGia.ContainsKey(id) ? MapGiamGia[id] : null;
        }

        public static void Remove(string id)
        {
            var gg = FindById(id);
            if (gg != null)
            {
                DanhSachGiamGia.Remove(gg);
                MapGiamGia.Remove(id);
            }
        }
    }

    public class ThanhToan
    {
        public string IdThanhToan { get; set; }
        public string IdTaiKhoan { get; set; }
        public string IdPhim { get; set; }
        public string IdVe { get; set; }
        public string IdBapNuoc { get; set; }
        public decimal? TienVe { get; set; }
        public decimal? TienBapNuoc { get; set; }
        public decimal? TongTien { get; set; }
        public string IdGiamGia { get; set; }

        public ThanhToan() { }
        public ThanhToan(string idTT, string idTK, string idPhim, string idVe, string idBN, decimal? tienVe, decimal? tienBN, decimal? tongTien, string idGG)
        {
            IdThanhToan = idTT;
            IdTaiKhoan = idTK;
            IdPhim = idPhim;
            IdVe = idVe;
            IdBapNuoc = idBN;
            TienVe = tienVe;
            TienBapNuoc = tienBN;
            TongTien = tongTien;
            IdGiamGia = idGG;
        }

        public static List<ThanhToan> DanhSachThanhToan = new List<ThanhToan>();
        public static Dictionary<string, ThanhToan> MapThanhToan = new Dictionary<string, ThanhToan>();

        public static void Add(ThanhToan tt)
        {
            DanhSachThanhToan.Add(tt);
            MapThanhToan[tt.IdThanhToan] = tt;
        }

        public static ThanhToan FindById(string id)
        {
            return MapThanhToan.ContainsKey(id) ? MapThanhToan[id] : null;
        }

        public static void Remove(string id)
        {
            var tt = FindById(id);
            if (tt != null)
            {
                DanhSachThanhToan.Remove(tt);
                MapThanhToan.Remove(id);
            }
        }
    }

    public class Phim
    {
        public string IdPhim { get; set; }
        public string TenPhim { get; set; }
        public string DaoDien { get; set; }
        public string DienVien { get; set; }
        public string TheLoai { get; set; }
        public string DoTuoi { get; set; }
        public decimal? GiaVeChuan { get; set; }
        public int? ThoiLuong { get; set; }
        public string MoTa { get; set; }
        public string UrlTrailer { get; set; }
        public string PosterPhim { get; set; }
        public string QuocGia { get; set; }
        public string NgonNgu { get; set; }
        public Phim() { }
        public Phim(string id, string ten,string Director ,string Actor,string theLoai, string doTuoi, decimal? giaVe, int? thoiLuong, string moTa, string url, string Poster,string Nation, string Language)
        {
            IdPhim = id;
            TenPhim = ten;
            DaoDien = Director;
            DienVien = Actor;
            TheLoai = theLoai;
            DoTuoi = doTuoi;
            GiaVeChuan = giaVe;
            ThoiLuong = thoiLuong;
            MoTa = moTa;
            UrlTrailer = url;
            PosterPhim = Poster;
            QuocGia = Nation;
            NgonNgu = Language;
        }

        public static List<Phim> DanhSachPhim = new List<Phim>();
        public static Dictionary<string, Phim> MapPhim = new Dictionary<string, Phim>();

        public static void Add(Phim phim)
        {
            DanhSachPhim.Add(phim);
            MapPhim[phim.IdPhim] = phim;
        }

        public static Phim FindById(string id)
        {
            return MapPhim.ContainsKey(id) ? MapPhim[id] : null;
        }

        public static void Remove(string id)
        {
            var phim = FindById(id);
            if (phim != null)
            {
                DanhSachPhim.Remove(phim);
                MapPhim.Remove(id);
            }
        }
    }

    public class SuatChieu
    {
        public string IdSuatChieu { get; set; }
        public string TenSuatChieu { get; set; }
        public TimeSpan? ThoiGianBatDau { get; set; }
        public TimeSpan? ThoiGianKetThuc { get; set; }

        public SuatChieu() { }
        public SuatChieu(string id, string ten, TimeSpan? batDau, TimeSpan? ketThuc)
        {
            IdSuatChieu = id;
            TenSuatChieu = ten;
            ThoiGianBatDau = batDau;
            ThoiGianKetThuc = ketThuc;
        }

        public static List<SuatChieu> DanhSachSuatChieu = new List<SuatChieu>();
        public static Dictionary<string, SuatChieu> MapSuatChieu = new Dictionary<string, SuatChieu>();

        public static void Add(SuatChieu sc)
        {
            DanhSachSuatChieu.Add(sc);
            MapSuatChieu[sc.IdSuatChieu] = sc;
        }

        public static SuatChieu FindById(string id)
        {
            return MapSuatChieu.ContainsKey(id) ? MapSuatChieu[id] : null;
        }

        public static void Remove(string id)
        {
            var sc = FindById(id);
            if (sc != null)
            {
                DanhSachSuatChieu.Remove(sc);
                MapSuatChieu.Remove(id);
            }
        }
    }
    public class VeDat
    {
         public string IdVe { get; set; }
         public DateTime? NgayChieu { get; set; }
         public TimeSpan? GioChieu { get; set; }
         public string Ghe { get; set; }
         public decimal? GiaVe { get; set; }
         public string TenPhim { get; set; }
         public string PosterPhim { get; set; }
    }
}


