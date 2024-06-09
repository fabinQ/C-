using System;
namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 bill = new Person2("Bill", "Wick");
            bill.SeyHi();

            Person2 john = new Person2(new DateTime(1990,1,3),"John", "Wick");
            john.SeyHi();
        }
    }
}