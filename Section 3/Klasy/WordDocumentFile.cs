using System;

namespace Klasy;

public class WordDocumentFile : File
{
    public override void Compress()
    {
        System.Console.WriteLine("Compressing WordDocumentFile");
    }

    public void Print()
    {
        System.Console.WriteLine($"{FileName} is printing...");
    }
}
