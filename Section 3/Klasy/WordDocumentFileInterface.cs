using System;

namespace Klasy;

public class WordDocumentFileInterface : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }

    public DateTime CreatedOn { get; set; }
    public void CompressInterface()
    {
        System.Console.WriteLine("Compressing WordDocumentFile");
    }

    public void PrintInterface()
    {
        System.Console.WriteLine($"{FileName} is printing...");
    }
}
