using System;

namespace Klasy;

public class PowerPointFile : File
{

    public void Present ()
    {
        System.Console.WriteLine($"{FileName} presenting...");
    }
}
