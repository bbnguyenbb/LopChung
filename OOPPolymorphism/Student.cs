namespace OOPPolymorphism;
internal class Student
{
    //auto property
    public int StuId { get; set; }

    //constructor không tham số
    //public Student()
    //{

    //}

    //public Student(int stuId)
    //{
    //    StuId = stuId;
    //}

    //public Student(string stuId)
    //{
    //    StuId = Convert.ToInt32(stuId);
    //}

    //public Student(int stuId) => StuId = stuId;

    //public void ShowStu()
    //{
    //    Console.WriteLine("student");
    //}

    //public void ShowStu(string name)
    //{
    //    Console.WriteLine("student"  + name);
    //}

    //optional param
    public void ShowStu(string name = null, int age = 10)
    {
        Console.WriteLine($"{name}, {age}");
    }

    public virtual void Show()
    {
        Console.WriteLine();
    }

    //public void ShowStu(int age)
    //{
    //    Console.WriteLine($"{age}");
    //}


}
