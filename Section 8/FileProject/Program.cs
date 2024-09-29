using System;
using System.IO;

namespace FileProject;

public class Program
{
    static void ReadFiles()
    {
        var document1 = File.ReadAllText(@".\..\..\..\..\..\Section 8\Documents\document1.txt");
        var document2 = File.ReadAllLines(@".\..\..\..\..\..\Section 8\Documents\document2.txt");

        System.Console.WriteLine("document1");
        System.Console.WriteLine(document1);
        System.Console.WriteLine("document2");
        System.Console.WriteLine(document2);
    }
    static void Main(string[] args)
    {
        ReadFiles();
    }
}
