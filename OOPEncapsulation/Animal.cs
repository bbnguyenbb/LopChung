namespace OOPEncapsulation;
public class Animal
{
    private void Private() => Console.WriteLine("private");

    protected void Protected() => Console.WriteLine("protected");

    private protected void PrivateProtected() => Console.WriteLine("private protected");

    internal void Internal() => Console.WriteLine("internal");

    protected internal void ProtectedInternal() => Console.WriteLine("protected internal");

    public void Public() => Console.WriteLine("public");

    //public static void Main()
    //{
    //    Animal animal = new();

    //    animal.Private();
    //    animal.Protected();
    //    animal.PrivateProtected();
    //    animal.Internal();
    //    animal.ProtectedInternal();
    //    animal.Public();
    //}

}
