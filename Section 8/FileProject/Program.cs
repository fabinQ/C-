using System;
using System.IO;
using System.Linq;

namespace FileProject;

public class Program
{
    static void ReadFiles()
    {
        var document1 = File.ReadAllText(@".\..\..\..\..\..\Section 8\Documents\document1.txt");
        var document2 = File.ReadAllLines(@".\..\..\..\..\..\Section 8\Documents\document2.txt");

        // System.Console.WriteLine("document1");
        // System.Console.WriteLine(document1);
        System.Console.WriteLine("document2");
        System.Console.WriteLine(document2);

        // foreach(string line in document2){
        // System.Console.WriteLine(line);
        // }
        string document3 = String.Join(Environment.NewLine, document2);
        System.Console.WriteLine(document3);
    }
    static void GenerateDocuments()
    {
        System.Console.WriteLine("Insert  name");
        var name = Console.ReadLine();

        System.Console.WriteLine("Insert  order number");
        var orderNumber = Console.ReadLine();

        var template = File.ReadAllText(@".\..\..\..\..\..\Section 8\Documents\template.txt");
        var document = template.Replace("{name}", name)
            .Replace("{orderNumber}", orderNumber)
            .Replace("{dateTime}", DateTime.Now.ToString());

        File.WriteAllText($@".\..\..\..\..\..\Section 8\Documents\document-{name}.txt", document);
    }

    static void ScanAndAppend()
    {
        var files = Directory.GetFiles(@".\..\..\..\..\..\Section 8\Documents\Append\", "*.txt", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            File.AppendAllText(file, String.Join(Environment.NewLine,"All right reserved"));
        }

    }
    static void Main(string[] args)
    {
        // ReadFiles();
        // GenerateDocuments();
        ScanAndAppend();
    }
}
