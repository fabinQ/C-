using System;
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
            john.SetDateOfBirth =new DateTime(1990,6,1);
            john.SeyHi();
            
            System.Console.WriteLine($"Objects of Person type count: {Person2.Count}");
        }
    }
}