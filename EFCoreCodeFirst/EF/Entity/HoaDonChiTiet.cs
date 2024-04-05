using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace EFCoreCodeFirst.EF.Entity;
[Table("HoaDonChiTiet")]
[PrimaryKey("IDHD", "IDSP")]
public partial class HoaDonChiTiet  // bảng nhiều
{
    [ForeignKey("IDHD")]
    public int IDHD { get; set; }

    [ForeignKey("IDSP")]
    public int IDSP { get; set; }

    public int DonGia { get; set; }
    public int SoLuong { get; set; }


    [InverseProperty("HoaDonChiTiets")]//tôi là bảng nhiều (thêm "s") liên kết đến bảng 1
    public virtual HoaDon HoaDon { get; set; } = null!;

    [InverseProperty("HoaDonChiTiets")]
    public virtual SanPham SanPham { get; set; } = null!;
}
