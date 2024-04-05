using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
[Table("SanPham")]
public partial class SanPham
{
    [Key]
    public int IDSP { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string TenSP { get; set; } = null!;

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = [];
}
