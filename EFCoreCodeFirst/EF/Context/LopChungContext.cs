using EFCoreCodeFirst.EF.Entity;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCoreCodeFirst.EF.Context;
//DbContext dùng để kết nối csdl, liên kết các table, thay đổi các đối tượng (bao gồm query, caching, transaction...)
internal class LopChungContext : DbContext
{
    //ef core sẽ phân biệt đâu là bảng ảo đâu là bảng bên dưới database
    public virtual DbSet<Log> Logs { set; get; }

    //dùng để kết nối đến sql server
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var strCon = builder.GetConnectionString("SqlServer");
        optionsBuilder.UseSqlServer(strCon);
    }
}
