using System;

namespace Klasy;

public class PowerPointFileInterface : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }

    public DateTime CreatedOn { get; set; }

    public void CompressInterface()
    {
        System.Console.WriteLine("Compressing PowerPointFile");
    }
    public void PresentInterface()
    {
        System.Console.WriteLine($"{FileName} presenting...");
    }
}
