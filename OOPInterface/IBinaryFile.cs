namespace OOPInterface;
internal interface IBinaryFile
{
    //bao gồm các phương thức không có body và kiểu trả về
    void WriteBinaryFile();
    void ReadFile();

    //default interface method
    void ShowInfo()
    {
        Console.WriteLine("complete file");
    }
}
