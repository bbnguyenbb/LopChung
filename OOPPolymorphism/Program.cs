
using OOPPolymorphism;

Student stu1 = new();

Student stu2 = new()
{
    StuId = 1
};


stu1.ShowStu();
stu1.ShowStu("nguyen");
stu1.ShowStu("nguyen", 1);
//named argument
stu1.ShowStu(age: 1);
