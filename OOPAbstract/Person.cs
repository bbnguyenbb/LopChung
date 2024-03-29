namespace OOPAbstract;
internal abstract class Person
{

    //thuộc tính abstract
    public abstract int PerId { get; set; }

    public string PerName { get; set; } = null!;


    //phương thức abstract
    public abstract void ShowGender();

    public override string ToString() => $"{{{nameof(PerId)}={PerId}, {nameof(PerName)}={PerName}}}";
}
