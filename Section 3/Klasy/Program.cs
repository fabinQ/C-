using System;
using ClassLibrary;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 bill = new Person2("Bill", "Wick");
            bill.SeyHi();
            bill.ContactNumber = "999888777";
            System.Console.WriteLine(bill.ContactNumber);

            Person2 john = new Person2("John", "Wick");
            john.SetDateOfBirth = new DateTime(1990, 6, 1);
            john.SeyHi();

            System.Console.WriteLine($"Objects of Person type count: {Person2.Count}\n\n");

            // InheritanceClass();

            Class1 class1 = new Class1();
            class1.PublicString = "test";

            // Jeśli klasa jest abstakcyjna to służy tylko do dziedziczenia 
            // i nie możemy utworzyć instancji klasy
            // File file = new File();

            InterfaceClass();

        }

        static void InheritanceClass()
        {
            ExcelFile excelFile = new ExcelFile();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";
            excelFile.GenerateRaport();

            WordDocumentFile wordFile = new WordDocumentFile();
            wordFile.CreatedOn = DateTime.Now;
            wordFile.FileName = "print-file";
            wordFile.Print();

        }
        static void InterfaceClass()
        {
            ExcelFileInterface excelFile = new ExcelFileInterface();
            excelFile.CreatedOn = DateTime.Now;
            excelFile.FileName = "excel-file";
            excelFile.GenerateRaportInterface();

            WordDocumentFileInterface wordFile = new WordDocumentFileInterface();
            wordFile.CreatedOn = DateTime.Now;
            wordFile.FileName = "print-file";
            wordFile.PrintInterface();

        }

    }
}