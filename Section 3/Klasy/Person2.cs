using System;
using System.Data;

namespace Klasy;

public class Person2
{
    public string FirstName;
    public string LastName;
    private DateTime dateOfBirth;
    private string contactNumber;
    public static int Count = 0;

    public Person2(string firstName, string lastName)
    {
        System.Console.WriteLine("First constructor");
        FirstName = firstName;
        LastName = lastName;
        Count++;
    }

    public Person2(DateTime dateOfBirth, string firstName, string lastName) : this(firstName, lastName)
    {
        System.Console.WriteLine("Secound constructor\n");
        this.dateOfBirth = dateOfBirth;
    }


    public string ContactNumber {get; set;}
    /*Gdy nie mamy dodatkowej logiki możemy wykożystać auto-implemented-properties */
    // public string ContactNumber
    // {
    //     get { return contactNumber; }
    //     set
    //     {
    //         if (value.Length < 9)
    //             System.Console.WriteLine("Invalid contact number");
    //         else
    //         {
    //             contactNumber = value;
    //         }
    //     }
    // }

    public DateTime SetDateOfBirth
    {
        set
        {
            if (value > DateTime.Now)
            {
                System.Console.WriteLine("Invalid date of birth");
            }
            else
            {
                System.Console.WriteLine(value);
                dateOfBirth = value;
            }
        }
        get {return dateOfBirth;}
    }
    // public void SetDateOfBirth(DateTime date)
    // {
    //     if (date > DateTime.Now)
    //     {
    //         System.Console.WriteLine("Invalid date of birth");
    //     }
    //     else
    //     {
    //         dateOfBirth = date;
    //     }
    // }
    public DateTime GetDateOfBirth() => dateOfBirth;

    public void SeyHi()
    {
        System.Console.WriteLine($"Hi, I'm {this.FirstName}, {GetDateOfBirth()}");
    }
}
