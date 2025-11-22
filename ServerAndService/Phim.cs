using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System.Text.Json.Serialization; // Cần thiết cho JsonPropertyName
using System;

namespace ServerAndService
{

    // Model Phim ánh xạ với bảng 'phim'
    [Table("phim")]
    public class Movie : BaseModel
    {
        // Khóa chính
        [PrimaryKey("IdPhim", false)]
        [JsonPropertyName("IdPhim")]
        public string IdPhim { get; set; } = string.Empty;

        // Các cột còn lại
        [Column("TenPhim"), JsonPropertyName("TenPhim")]
        public string TenPhim { get; set; } = string.Empty;

        [Column("TheLoai"), JsonPropertyName("TheLoai")]
        public string TheLoai { get; set; } = string.Empty;

        [Column("DoTuoi"), JsonPropertyName("DoTuoi")]
        public string DoTuoi { get; set; } = string.Empty;

        [Column("GiaVeChuan"), JsonPropertyName("GiaVeChuan")] // numeric -> decimal
        public decimal GiaVeChuan { get; set; }

        [Column("ThoiLuong"), JsonPropertyName("ThoiLuong")] // int4 -> int
        public int ThoiLuong { get; set; }

        [Column("MoTa"), JsonPropertyName("MoTa")]
        public string MoTa { get; set; } = string.Empty;

        [Column("UrlTrailer"), JsonPropertyName("UrlTrailer")]
        public string UrlTrailer { get; set; } = string.Empty;

        [Column("PosterPhim"), JsonPropertyName("PosterPhim")]
        public string PosterPhim { get; set; } = string.Empty;

        [Column("DaoDien"), JsonPropertyName("DaoDien")]
        public string DaoDien { get; set; } = string.Empty;

        [Column("DanDienVien"), JsonPropertyName("DanDienVien")]
        public string DanDienVien { get; set; } = string.Empty;

        [Column("NgonNgu"), JsonPropertyName("NgonNgu")]
        public string NgonNgu { get; set; } = string.Empty;

        [Column("QuocGia"), JsonPropertyName("QuocGia")]
        public string QuocGia { get; set; } = string.Empty;
    }


}