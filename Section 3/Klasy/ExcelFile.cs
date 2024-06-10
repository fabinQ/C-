using System;

namespace Klasy;

public class ExcelFile : File
{
    public void GenerateRaport ()
    {
        string prop = ProtectedProp;
        System.Console.WriteLine($"{FileName} raport...");
    }
}
