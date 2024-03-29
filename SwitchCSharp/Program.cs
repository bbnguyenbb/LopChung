using System.Text;

namespace SwitchCSharp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        int num1, num2;
        Console.WriteLine("vui lòng nhập số thứ 1: ");
        num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("vui lòng nhập số thứ 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("nhập phép tính ( +, - , * , /): ");
        string pheptoan = Console.ReadLine();
        //câu lệnh switch case có thêm  when
        switch(pheptoan)
        {
            case "+" when num1 > 0 && num2 > 0:
                Console.WriteLine(num1 + num2);
                break;
            case "-" when num1 > num2:
                Console.WriteLine(num1 - num2);
                break;
            case "*":
                Console.WriteLine(num1 * num2);
                break;
            case "/" when num2 != 0:
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine("cannot....");
                break;
        }

        //biểu thức switch case
        //xét biến pheptoan trong trường hợp (switch) là
        Console.WriteLine(pheptoan switch
        {
            "+" when num1 > 0 && num2 > 0 => num1 + num2,
            "-" when num1 > num2 => num1 - num2,
            "*" => num1 * num2,
            "/" when num2 != 0 => num1 / num2,
            _ => 0
        });

    }

}
