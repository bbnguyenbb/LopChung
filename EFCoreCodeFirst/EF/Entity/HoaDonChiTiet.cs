using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
[Table("HoaDonChiTiet")]
public partial class HoaDonChiTiet  // bảng nhiều
{

    public int IDHD { get; set; }
    public int IDSP { get; set; }
    public int DonGia { get; set; }
    public int SoLuong { get; set; }


    public virtual HoaDon HoaDon { get; set; } = null!;

    public virtual SanPham SanPham { get; set; } = null!;

}
