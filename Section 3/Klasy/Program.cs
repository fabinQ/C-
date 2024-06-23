using System;
using ClassLibrary;
using Coding.Exercise;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  BILL    */
            Person2 bill = new Person2("Bill", "Wick");
            bill.ContactNumber = "999888777";
            bill.SeyHi();
            System.Console.WriteLine(bill.ContactNumber + '\n');


            /*  JOHN    */
            // Person2 john = new Person2("John", "Wick");
            /* Kiedy mamy włąsne konstruktory to możemy wywołać konstruktor z 3 parametrami */
            Person2 john = new Person2(new DateTime(2000, 10, 2), "John", "Wick");
            System.Console.WriteLine("Test get " + john.SetDateOfBirth);
            john.SetDateOfBirth = new DateTime(1990, 6, 1);
            john.SeyHi();

            /* COUNT FUNCTION */
            System.Console.WriteLine($"Objects of Person type count: {Person2.Count}\n\n");


            InheritanceClass();

            Class1 class1 = new Class1();
            class1.PublicString = "test";

            // Jeśli klasa jest abstakcyjna to służy tylko do dziedziczenia 
            // i nie możemy utworzyć instancji klasy
            // File file = new File();

            InterfaceClass();

            Square value1 = new Square(4.51);
            System.Console.WriteLine(value1.CalculateArea());
            System.Console.WriteLine(value1.CalculatePerimeter());
            

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