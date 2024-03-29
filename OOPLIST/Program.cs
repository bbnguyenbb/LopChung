using System.Collections;
using System.Diagnostics;
using System.Text;

using CollectionCSharp;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> list =
[
    new Student() { StuId = 1, StuName = "nguyên", StuGender = true },
    new Student() { StuId = 2, StuName = "đại", StuGender = true },
    new Student() { StuId = 3, StuName = "hải", StuGender = true },
    new Student() { StuId = 4, StuName = "huy", StuGender = true },
    new Student() { StuId = 5, StuName = "bảo", StuGender = true },
    new Student() { StuId = 6, StuName = "kiệt", StuGender = true },
    new Student() { StuId = 7, StuName = "phương anh", StuGender = false },

];

Stopwatch sw = new();
sw.Restart();
foreach(var t in list)
{
    Console.WriteLine(t);
}
sw.Stop();
Console.WriteLine($"foreach run : {sw.ElapsedMilliseconds}");

sw.Restart();
IEnumerator ie = list.GetEnumerator();
while(ie.MoveNext())
{
    Console.WriteLine(ie.Current);
}
sw.Stop();
Console.WriteLine($"IEnumerator run : {sw.ElapsedMilliseconds}");

// không đo thời gian
//delegate
list.ForEach(Console.WriteLine);

//hiển thị toàn bộ thông tin sinh viên trong list có mã sinh viên bằng 2
foreach(var t in list)
{
    if(t.StuId == 2)
    {
        Console.WriteLine(t);
    }
}

list.ForEach(
    s =>
    {
        if(s.StuId == 2)
        {
            Console.WriteLine(s);
        }
    }
);

//linq - linq to sql , linq to xml/json , linq to object
//style - query syntax
var result = from t in list
             where t.StuId == 2
             orderby t.StuName, t.StuGender descending
             select t;


foreach(var i in result)
{
    Console.WriteLine(i);
}

//rút gọn
foreach(var i in from t in list
                 where t.StuGender
                 select t)
{
    Console.WriteLine(i);
}

//đếm xem cái list có bao nhiêu sinh viên giới tính là true
var l1 = from t in list
         where t.StuGender
         select t;

Console.WriteLine(l1.Count());

Console.WriteLine((from t in list
                   where t.StuGender
                   select t).Count());

//style - method syntax Vẫn cho phép chỉnh sửa

//var result = from t in list
//             where t.StuId == 2
//             OrderBy t.StuName
//             select t;


var u = list.Where(s => s.StuId == 2).OrderBy(s => s.StuName);
list.Sort();

