using System;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person bill = new Person();
            bill.FirstName = "Bill";
            bill.SetDateOfBirth(new DateTime(1999, 1, 2));
            bill.SeyHi();
        }
    }
}