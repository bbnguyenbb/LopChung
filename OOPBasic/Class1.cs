namespace OOPBasic;
internal partial class Student
{
    //các method
    public void Show()
    {
        Console.WriteLine($"{nameof(Id)}={Id}");
        Console.WriteLine($"{nameof(Name)}={Name}");
    }

    public void Hello() => Console.WriteLine("this is c#");

    public override string ToString() => $"{{{nameof(Id)}={Id.ToString()}, {nameof(Name)}={Name}}}";
}
