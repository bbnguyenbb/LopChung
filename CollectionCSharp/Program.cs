using System.Collections;
using System.Text;

using CollectionCSharp;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string[] arr = ["thông", "kiệt", "hải", "đạt", "huy"];


////ban đầu
var i = 0;
while(i < arr.Length)
{
    Console.WriteLine(arr[i]);
    i++;
}

//thay while bằng for
for(int j = 0; j < arr.Length; j++)
{
    Console.WriteLine(arr[j]);
}

//foreach sử dụng duyệt qua các class mà thực thi ienumerator
foreach(var item in arr)
{
    Console.WriteLine(item);
}

//collection (bộ tập hợp, bộ duyệt qua...)

//dùng ienumerator duyệt qua
IEnumerator ie = arr.GetEnumerator();
while(ie.MoveNext())
{
    Console.WriteLine(ie.Current);
}


List<Student> list2 =
[
    new Student() { StuId = 1, StuName = "nguyên", StuGender = true },
    new Student() { StuId = 2, StuName = "đ", StuGender = true }
];

var t = list2.GetEnumerator();
while(t.MoveNext())
{
    Console.WriteLine(t.Current);
}

foreach(var item in list2)
{
    Console.WriteLine(item);
}

list2.ForEach(Console.WriteLine);
list2.ForEach(stu => Console.WriteLine(stu.StuName));