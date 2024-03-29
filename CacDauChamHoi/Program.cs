namespace CacDauChamHoi;

internal class Program
{
    static void Main(string[] args)
    {
        #region note
        //trong c# đa phần có 2 dạng type
        //value type: không có giá trị null(kiểu số, kiểu bool...)
        //muốn chứa null thì dùng  ? <=> nullable value type
        //trước sau kiểu cần khai báo
        //ví dụ int? a = null; bool flag = null;
        //reference type: cho phép null (class, object, string..)
        #endregion

        string str = "lop chung";
        int chieudai = str.Length;
        Console.WriteLine($"{nameof(chieudai)} = {chieudai}");

        str = null;

        //? null-conditional operator
        //?? null coalescing conditional operator
        //nếu str khác null thì s
        chieudai = str?.Length ?? 5;

        //chieudai = str is null ? null : str.Length;

        Console.WriteLine($"{nameof(chieudai)} = {chieudai}");

    }
}
