namespace OOPInterface;
internal class SomeFile : ITextFile, IBinaryFile
{
    //thông qua interface thì không có bổ từ
    void ITextFile.ReadFile()
    {
        Console.WriteLine("read text file");
    }

    void IBinaryFile.ReadFile()
    {
        Console.WriteLine("read binary file");
    }

    public void WriteBinaryFile()
    {
        Console.WriteLine("write binary file");
    }

    public void WriteTextFile()
    {
        Console.WriteLine("write text file");
    }

    public void SearchFile()
    {
        Console.WriteLine("Search file");
    }
}
