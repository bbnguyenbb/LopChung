using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
//bảng 1
[Table("job")]
public partial class Job
{
    [Key]
    [Column("job_id")]
    public int JobId { get; set; }

    [Column(TypeName = "nvarchar(50)")]
    public string JobName { get; set; } = null!;

    //bảng 1 có list đối tượng của nhiều
    [InverseProperty("Job")]
    public virtual ICollection<Emp> Emps { get; set; } = [];
}
