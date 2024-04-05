using EFCoreCodeFirst.EF.Entity;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreCodeFirst.EF.Context;
//DbContext dùng để kết nối csdl, liên kết các table, thay đổi các đối tượng (bao gồm query, caching, transaction...)
public partial class LopChungContext : DbContext
{
    //ef core sẽ phân biệt đâu là bảng ảo đâu là bảng bên dưới databas

    public virtual DbSet<Log> Logs { set; get; }
    public virtual DbSet<Employee> Employees { set; get; }
    public virtual DbSet<Dependent> Dependents { set; get; }


    public virtual DbSet<Emp> Emps { set; get; }
    public virtual DbSet<Job> Jobs { set; get; }

    public virtual DbSet<HoaDon> HoaDons { set; get; }
    public virtual DbSet<SanPham> SanPhams { set; get; }
    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { set; get; }

    public virtual DbSet<KhachHang> KhachHangs { set; get; }
    public virtual DbSet<TaiKhoan> TaiKhoans { set; get; }


    public virtual DbSet<NhanVien> NhanViens { set; get; }

    //dùng để kết nối đến sql server
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var strCon = builder.GetConnectionString("SqlServer");
        optionsBuilder.UseSqlServer(strCon);
    }

    //nếu không dùng data annotation trong entity là [Table("ten_so_it")] cho class
    //hay fluent api thì phải ghi đè 1 trong 2 cách
    //c1) thường dùng cách 1 vì nó sẽ chạy trước cách 2 nếu có cả 2 cách
    //protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    //{
    //    configurationBuilder.Conventions.Remove(typeof(TableNameFromDbSetConvention));
    //}

    //c2)
    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    foreach(var entity in modelBuilder.Model.GetEntityTypes())
    //    {
    //        entity.SetTableName(entity.DisplayName());

    //    }
    //}
}
