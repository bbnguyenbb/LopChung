namespace CollectionCSharp;
internal class Student
{
    public int StuId { get; set; }
    public string StuName { get; set; } = null!;
    public bool StuGender { get; set; }

    public override string ToString() => $"{{{nameof(StuId)}={StuId}, {nameof(StuName)}={StuName}, {nameof(StuGender)}={StuGender}}}";
}
