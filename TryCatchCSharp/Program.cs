

namespace TryCatchCSharp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("vui lòng nhập giá trị: ");
        string? amount = Console.ReadLine();

        //design pattern (guard clause)
        if(string.IsNullOrEmpty(amount)) return;

        try
        {
            int total = int.Parse(amount);

            if(total <= 0) throw new Exception("num > 0");

            Console.WriteLine($"{nameof(amount)} = {amount}");
        }
        catch(Exception) when(amount.Contains("$")) //like "%$%
        {
            Console.WriteLine("không được nhập ký tự $");
        }
        catch(Exception e)
        {
            Console.WriteLine($"{e.Message}");
        }

        Console.WriteLine("ahihi");
    }
}
