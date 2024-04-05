using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
[Table("dependent")]
public partial class Dependent
{
    [Key]
    [Column("dependent_id")]
    public int DependentId { get; set; }

    [Column("first_name", TypeName = "nvarchar(50)")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Column("last_name", TypeName = "nvarchar(50)")]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Column("relationship", TypeName = "nvarchar(50)")]
    [StringLength(50)]
    public string Relationship { get; set; } = null!;

    //trong sql (cầm khóa chính bảng 1 employee để sang bảng nhiều dependent)
    [Column("employee_id")]
    public int EmployeeId { get; set; }


    //của class (nên dùng)
    public virtual Employee Employee { get; set; } = null!;

}
