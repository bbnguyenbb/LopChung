namespace DelegateEvent;
internal class MathOne
{
    public static void InfoMathOne() => Console.WriteLine("math one");
    public static void AddInt(int num1, int num2) => Console.WriteLine(num1 + num2);
    public static void SubInt(int num1, int num2) => Console.WriteLine(num1 - num2);

    //tạo cho class 1 event
    public static event ShowInfo eventOne;

    //tạo phương thức để dùng event
    public static void RegisterEvent()
    {
        eventOne += new ShowInfo(InfoMathOne);
        eventOne();
    }
}


