using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore;

namespace EFCoreCodeFirst.EF.Entity;
[Table("NhanVien")]
public partial class NhanVien
{
    [Key]
    public int MaNV { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string TenNV { get; set; } = null!;

    [ForeignKey("MaNQL")]
    public int MaNQL { get; set; }

    //bảng người quản lý => bảng 1 cần danh sách của nhiều
    [InverseProperty("NguoiQuanLy")]
    public virtual ICollection<NhanVien> NhanViens { get; set; } = null!;

    //bảng nhân viên => bảng nhiều cần đối tượng 1
    [InverseProperty("NhanViens")]
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual NhanVien NguoiQuanLy { get; set; } = null!;
}
