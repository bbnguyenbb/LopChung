var number1 = 1; //biến kiểu int

var number2 = (1); //biến kiểu int


//===========================

ValueTuple<int, string> human = (1, "dat");
Console.WriteLine(human.Item1 + " " + human.Item2);

//===============
(int, string) person = (1, "nguyen");
Console.WriteLine(person.Item1 + " " + person.Item2);

//==khuyến thích nên dùng 2 cái bên dưới
//===============
var people = (1, "nguyen");
Console.WriteLine(people.Item1 + " " + people.Item2);

//===============
(int id, string name) student = (1, "nguyen");
Console.WriteLine(student.id + " " + student.name);




