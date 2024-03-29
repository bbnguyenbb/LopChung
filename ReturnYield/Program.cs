List<int> list = [1, 2, 3, 2];


//tại sao dùng yield
//lấy ví dụ đơn giản, đôi khi cần duyệt qua 1 danh sách và trả về từng phần tử
//một cách trực tiếp trong vòng lặp for thông qua 1 phương thức hay 1 local function
//thì điều này là không thể


//local function: xét hàm cục bộ
//1)

//int GetNum()
//{
//    for (var i = 0; i < list.Count; i++)
//    {
//        /*lỗi trả kết quả trực tiếp ra bên ngoài*/
//        return list[i];
//    }
//    /*
//      phải là return bên dưới này
//    */
//}

//2)
//IEnumerator<int> GetNumber()
IEnumerable<int> GetNumber()
{
    for(var i = 0; i < list.Count; i++)
    {
        /*
        nhưng vẫn muốn return ở đây thì giả sử return được đi nữa
        thì do tính chất return nó sẽ thoát khỏi tất cả 
        và không thể quay trở lại nhưng có 1 cách là dùng ienumerator
        vì nó có thể giữ trạng thái hiện tại để đi tiếp thông qua thuộc tính current
        lưu trữ trạng thái hiện tại của collection
        ở đây dùng IEnumerable vì muốn dùng foreach
         */
        yield return list[i];
    }
}


//do GetNumber() trả về là IEnumerable nên có thể dùng foreach
foreach(var number in GetNumber())
{
    Console.WriteLine(number);
}

//nếu GetNumber() trả vè là IEnumerator thì phải dùng vòng lặp while 
//var t = GetNumber();
//while(t.MoveNext())
//{
//    Console.WriteLine(t);
//}