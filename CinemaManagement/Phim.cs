using CinemaManagement;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CinemaManagement
{
    [Table("phim")]
    public class Phim : BaseModel
    {
        public string IdPhim { get; set; }
        public string TenPhim { get; set; }
        public string NhaXuatBan { get; set; }


        public string DaoDien { get; set; }

        public string DanDienVien { get; set; }

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
        public Phim(string id, string ten, string Director, string Actor, string theLoai, string doTuoi, decimal? giaVe, int? thoiLuong, string moTa, string url, string Poster, string Nation, string Language)
        {
            IdPhim = id;
            TenPhim = ten;
            DaoDien = Director;
            DanDienVien = Actor;
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
}

public class PhimDuocChonEventArgs : EventArgs
{
    public Phim PhimDuocChon { get; private set; }

    public PhimDuocChonEventArgs(Phim phim)
    {
        PhimDuocChon = phim;
    }
}

