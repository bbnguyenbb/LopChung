using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;

[Table("employee")]
public partial class Employee
{
    [Key]
    [Column("employee_id")]
    public int EmployeeId { get; set; }


    [Column("first_name", TypeName = "nvarchar(50)")]
    [StringLength(50)]
    //[MaxLength(50)] sql server
    //[Unicode(true)]
    public string FirstName { get; set; } = null!;

    [Column("last_name", TypeName = "nvarchar(50)")]
    [StringLength(50)]
    public string? LastName { get; set; }

    [Column("email", TypeName = "varchar(100)")]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "lỗi")]
    public string Email { get; set; }

    [Column("phone_number", TypeName = "varchar(10)")]
    public string PhoneNumber { get; set; } = null!;

    [Column("hire_date", TypeName = "datetime")]
    public DateTime HireDate { get; set; }

    [Column("salary", TypeName = "decimal(8,2)")]
    public decimal Salary { get; set; }

    [Column("manager_id")]
    public int ManagerID { get; set; }

    //của class
    public virtual ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();
}