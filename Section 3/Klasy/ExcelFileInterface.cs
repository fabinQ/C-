using System;

namespace Klasy;

public class ExcelFileInterface : IFile
{
    public string FileName { get; set; }
    public int Size { get; set; }

    public DateTime CreatedOn { get; set; }

    public void CompressInterface()
    {
        System.Console.WriteLine("Compressing ExcelFile");
    }
    public void GenerateRaportInterface()
    {
        System.Console.WriteLine($"{FileName} raport...");
    }
}
