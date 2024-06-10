using System;

namespace Klasy;

public class WordDocumentFile : File
{
        public void Print ()
    {
        System.Console.WriteLine($"{FileName} is printing...");
    }
}
