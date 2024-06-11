using System;

namespace Klasy;

public class ExcelFile : File
{
    public override void Compress()
    {
        System.Console.WriteLine("Compressing ExcelFile");
    }
    public void GenerateRaport()
    {
        string prop = ProtectedProp;
        System.Console.WriteLine($"{FileName} raport...");
    }
}
