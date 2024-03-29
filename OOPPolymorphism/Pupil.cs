namespace OOPPolymorphism;
internal class Pupil : Student
{
    //con sửa cha 
    public override void Show()
    {
        Console.WriteLine();
    }

    //public override void ShowStu(string name = null, int age = 10)
    //{
    //    Console.WriteLine($"{name}, {age}");
    //}
}
