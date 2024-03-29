using OOPEncapsulation;

namespace OOPEncapsulationCons;

internal class Cat : Animal
{
    public void ShowCat()
    {
        Cat cat = new();
        //cat.PrivateProtected();
        cat.Protected();
        //cat.Internal();
        cat.ProtectedInternal();
        cat.Public();
    }
}
