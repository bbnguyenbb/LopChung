using DelegateEvent;

//delegate phải tương ứng với phương thức cần làm
public delegate void ShowInfo();
public delegate void AddSub(int num1, int num2);
public delegate int MulDiv(int num1, int num2);

internal class Program
{
    private static void Main(string[] args)
    {
        //ShowInfo si1 = MathOne.InfoMathOne;
        //si1.Invoke();

        //si1 = MathTwo.InfoMathTwo;
        //si1();

        //////multicast delegate
        ////AddSub ads = MathOne.AddInt;
        ////ads += MathOne.SubInt;
        ////ads(10, 5);

        //////phương thức trả về ko multicast
        ////MulDiv md = MathTwo.MulInt;
        ////Console.WriteLine(md(10, 5));
        ////md += MathTwo.DivInt;
        ////Console.WriteLine(md(10, 5));

        ////event
        //MathOne.RegisterEvent();

        //chỉnh lại delegate
        //Action và Func
        //action là delegate kiểu là void
        //Func là delegate trả về kiểu bất kỳ khác void

        Action action = MathOne.InfoMathOne;
        action();

        Action<int, int> act1 = MathOne.AddInt;
        act1(10, 5);

        Func<int, int, int> fun = MathTwo.MulInt;
        Console.WriteLine(fun(10, 5));

        //lamda

        var ac = () => Console.WriteLine("ahihi action ne");
        ac();


        var ac1 = (string str) => Console.WriteLine(str);
        ac1("nguyen");


        var fun1 = (string str) => str + "ahihi";
        fun1("i hate you");

        var i = (int x) => x + 10;
        Console.WriteLine(i(10));
    }
}