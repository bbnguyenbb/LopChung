namespace OOPAbstract;
internal class Student : Person
{
    public string Phone { get; set; }
    public string Email { get; set; }
    public bool Gender { get; set; }
    public override int PerId { get; set; }

    public override void ShowGender()
    {
        Console.WriteLine(Gender);
    }
}