using System;

namespace Klasy;

public class Person2
{
    public string FirstName;
    public string LastName;
    private DateTime dateOfBirth;

    public Person2(string firstName, string lastName)
    {
        System.Console.WriteLine("First constructor");
        FirstName = firstName;
        LastName = lastName;
    }

    public Person2(DateTime dateTime, string firstName, string lastName) : this(firstName, lastName)
    {
        System.Console.WriteLine("Secound constructor");
        SetDateOfBirth(dateOfBirth);
    }
    public void SetDateOfBirth(DateTime date)
    {
        if (date > DateTime.Now)
        {
            System.Console.WriteLine("Invalid date of birth");
        }
        else
        {
            System.Console.WriteLine(date);
            dateOfBirth = date;
        }
    }
    public DateTime GetDateOfBirth() => dateOfBirth;

    public void SeyHi()
    {
        System.Console.WriteLine($"Hi, I'm {this.FirstName}, {GetDateOfBirth()}");
    }
}
