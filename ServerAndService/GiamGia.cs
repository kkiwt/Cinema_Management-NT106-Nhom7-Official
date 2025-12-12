
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

[Table("giamgia")]
public class GiamGia : BaseModel
{
    [PrimaryKey("IdGiamGia")]
    public string IdGiamGia { get; set; }

    [Column("TuNgay")]
    public DateTime? TuNgay { get; set; }

    [Column("DenNgay")]
    public DateTime? DenNgay { get; set; }

    [Column("TiLeGiam")]
    public decimal? TiLeGiam { get; set; }
    
}
