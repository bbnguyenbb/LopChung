using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;

//bảng nhiều
[Table("emp")]
public partial class Emp
{
    [Key]
    public int EmpId { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string EmpName { get; set; } = null!;

    [ForeignKey("JobId")] // là thuộc tính không phải tên cột trong sql 
    public int JobId { get; set; }

    //bảng nhiều có đối tượng của 1
    [InverseProperty("Emps")]
    public virtual Job Job { get; set; } = null!;
}
