
using OOPBasic;

Student stu = new();
stu.Name = "nguyen";
Console.WriteLine(stu.Name);
stu.Show();

//object initialization
Student Stu2 = new Student()
{
    Id = 1,
    Name = "hai"
};

Student stu3 = new()
{
    Name = "HUY"
};

