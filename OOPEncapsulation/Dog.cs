namespace OOPEncapsulation;
internal class Dog : Animal
{
    public void Show()
    {
        Dog dog = new();
        dog.Protected();
        dog.PrivateProtected();
        dog.Internal();
        dog.ProtectedInternal();
        dog.Public();
    }
}
