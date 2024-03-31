//import của thư viện


using EFCoreCodeFirst.EF.Context;
using EFCoreCodeFirst.EF.Entity;

using Microsoft.EntityFrameworkCore;

//await using(LopChungContext context = new())
//{
//    if(await context.Database.EnsureDeletedAsync())
//    {
//        await Console.Out.WriteLineAsync("delete");
//    }

//    await context.Database.EnsureCreatedAsync();
//    Console.WriteLine("create");
//}

//thêm dữ liệu vào table Log
//await using(LopChungContext context = new())
//{
//    Log log1 = new()
//    {
//        Id = 1,
//        EmployeeId = 1,
//        LoginTime = DateTime.Now,
//        LogOutTime = DateTime.Now.AddDays(1)
//    };

//    context.Logs.Add(log1);

//    Log log2 = new()
//    {
//        Id = 2,
//        LoginTime = DateTime.Now,
//        LogOutTime = DateTime.Now.AddDays(2)
//    };

//    await context.Logs.AddAsync(log2);
//    //await context.AddAsync(log2);
//    //await context.AddAsync<Log>(log2);

//    //List<Log> lg = [log1, log2];
//    //await context.Logs.AddRangeAsync(lg);
//    await context.SaveChangesAsync();

//}

//sửa = update
//await using(LopChungContext context = new())
//{

//    var log = await context.Logs.FirstOrDefaultAsync(log => log.Id == 1);

//    //ko luu lai su thay doi du lieu
//    await context.Logs.Where(log => log.Id == 1)
//        .ExecuteUpdateAsync(s => s.SetProperty(p => p.EmployeeId, 100));

//    if(log is not null)
//    {
//        //foreach(var item in log)
//        //{
//        log.EmployeeId++;
//        log.LogOutTime = DateTime.Now.AddDays(3);
//        //}

//        // context.Logs.Update(log);
//    }

//    //var log = await context.Logs.FirstOrDefaultAsync(log => log.Id == 1);
//    //var log = context.Logs.Where(log => log.Id == 1).ToList();

//    //var log = context.Logs.Where(log => log.Id == 1);

//    //if(log is not null)
//    //{
//    //    //foreach(var item in log)
//    //    //{
//    //    log.EmployeeId = 100;
//    //    log.LogOutTime = DateTime.Now.AddDays(3);
//    //    //}

//    //    // context.Logs.Update(log);
//    //}

//    //context.Update(log);
//    //context.Update<Log>(log);
//    await context.SaveChangesAsync();


//}


//delete = update
await using(LopChungContext context = new())
{
    //await context.Logs.Where(log => log.Id == 1).ExecuteDeleteAsync();

    //var log = context.Logs.Where(log => log.Id == 1);

    //if(log is not null)
    //{
    //    foreach(var item in log)
    //    {
    //        context.Logs.Remove(item);
    //    }

    //    //context.Logs.RemoveRange(log);
    //}

    //==================================
    //var log1 = await context.Logs.FindAsync(1);

    //if(log1 is not null)
    //{
    //    //foreach (var item in log)
    //    //{
    //    //    context.Logs.Remove(item);
    //    //}

    //    context.Logs.RemoveRange(log1);
    //}


    //await context.SaveChangesAsync();
}

await using(LopChungContext context = new())
{
    //ienumerable nằm trong system.collection
    //làm trong bộ nhớ. có thể duyệt qua bằng .foreach
    //không thích hợp phân trang
    //thường dùng cho dữ liệu cần bộ nhớ hay dữ liệu nhỏ
    IEnumerable<Log> log1 = context.Logs;
    log1 = log1.Where(log => log.Id > 0);
    foreach(var item in log1)
    {
        Console.WriteLine(item);
    }

    //iqueryable nằm trong system.linq
    //làm trực tiếp trên sql
    //thích hợp phân trang
    //cần cho dữ liệu lớn 
    IQueryable<Log> log2 = context.Logs;
    log2 = log2.Where(log => log.Id > 0);
    foreach(var item in log2)
    {
        Console.WriteLine(item);
    }

    //còn như thế thì đều lọc sẵn từ sql
    var log3 = context.Logs.Where(log => log.Id > 0).AsEnumerable();
    var log4 = context.Logs.Where(log => log.Id > 0); //mặc định

    foreach(var item in log3)
    {
        Console.WriteLine(item);
    }


    //duyệt nhanh qua bằng ForEachAsync
    await context.Logs.ForEachAsync(Console.WriteLine);

    //duyệt nhanh qua bằng foreach trả về List<Log>
    context.Logs.ToList().ForEach(Console.WriteLine);
}
