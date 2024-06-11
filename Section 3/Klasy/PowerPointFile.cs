using System;

namespace Klasy;

public class PowerPointFile : File
{
    public override void Compress()
    {
        System.Console.WriteLine("Compressing PowerPointFile");
    }
    public void Present()
    {
        System.Console.WriteLine($"{FileName} presenting...");
    }
}
