using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
[Table("KhachHang")]
//[PrimaryKey("MaKH")]
public partial class KhachHang
{
    [Key]
    public int MaKH { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string TenKH { get; set; } = null!;


    [InverseProperty("KhachHang")]
    public virtual TaiKhoan TaiKhoan { get; set; } = null!;
}
