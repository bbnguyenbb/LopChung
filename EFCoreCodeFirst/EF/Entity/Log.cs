using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreCodeFirst.EF.Entity;
//class Log sẽ tạo table chủ yếu lưu lại người ra vào hệ thống

//data annotation
//tạo 1 table bên dưới tên là log
[Table("log")]
public partial class Log
{
    //kiểu mà có ? = null. ngược lại không có là not null
    //cột mà kiểu int là khóa chính thì mặc định là tự động tăng
    //đã là khóa chính thì mặc định bên dưới csdl là not null
    [Key]
    [Column("id")]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }

    //mặc định là null
    [Column("employee_id")]
    public int? EmployeeId { get; set; } = null;

    [Column("login_time", TypeName = "datetime")]
    public DateTime LoginTime { get; set; }

    [Column("logout_time", TypeName = "datetime")]
    public DateTime LogOutTime { get; set; }

    public override string ToString() => $"{{{nameof(Id)}={Id.ToString()}, {nameof(EmployeeId)}={EmployeeId.ToString()}, {nameof(LoginTime)}={LoginTime.ToString()}, {nameof(LogOutTime)}={LogOutTime.ToString()}}}";
}
