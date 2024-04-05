using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
[Table("TaiKhoan")]
public partial class TaiKhoan
{
    [Key]
    public int MaKH { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string UserName { get; set; } = null!;

    [Column(TypeName = "nvarchar(50)")]
    public string Password { get; set; } = null!;

    [ForeignKey("MaKH")]
    [InverseProperty("TaiKhoan")]
    public virtual KhachHang KhachHang { get; set; } = null!;
}
