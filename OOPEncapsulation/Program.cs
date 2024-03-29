
using OOPEncapsulation;

Animal animal = new();

//animal.Private();
//animal.Protected();
//animal.PrivateProtected();
animal.Internal();
animal.ProtectedInternal();
animal.Public();

Dog dog = new();
//dog.Protected();
//dog.PrivateProtected();
dog.Internal();
dog.ProtectedInternal();
dog.Public();
