namespace OOPInterface;

//Adapter Pattern => design pattern
internal class ManyFile : ITextFile, IBinaryFile
{
    public void ReadFile()
    {
        Console.WriteLine("read file");
    }

    public void WriteBinaryFile()
    {
        Console.WriteLine("write binary file");
    }

    public void WriteTextFile()
    {
        Console.WriteLine("write text file");
    }
}
