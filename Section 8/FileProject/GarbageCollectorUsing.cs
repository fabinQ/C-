using System;
using System.IO;

namespace FileProject;

public class GarbageCollectorUsing
{
    string path = Path.GetFullPath(Path.Combine(Path.GetDirectoryName("."), @"..\..\..\..\Documents", "document1.txt"));
    private IDisposable writeFileStream;
    public class SomeClass() : IDisposable
    {
        public void Dispose()
        {
            System.Console.WriteLine("Disposing SomeClass");
        }

        public void Say(string input)
        {
            System.Console.WriteLine(input);
        }
    }

    public void GBUsing()
    {
        // Żeby użyć using kasa musi miec zaimplementowany interfejs IDisposable
        using (var readFileStream = new FileStream(path, FileMode.Open))
        {
            // readFileStream.Read();
            // jakaś logika
        }

        // to jest to samo co 
        // try
        // {
        //     var writeFileStream = new FileStream(path, FileMode.Open);
        //     writeFileStream.Write();
        // }
        // finally
        // {
        //     ((IDisposable)writeFileStream).Dispose();
        // }

        using(var someClass = new SomeClass())
        {
            someClass.Say("Hi");
        }
    }
}