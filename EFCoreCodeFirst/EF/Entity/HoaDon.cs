using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
[Table("HoaDon")]
public partial class HoaDon //bang 1
{
    [Key]
    public int IDHD { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime NgayTao { get; set; }

    [InverseProperty("HoaDon")]
    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; } = [];

}
