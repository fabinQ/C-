using System;
namespace Klasy;

public class Person
{
    public string FirstName;
    public string LastName;
    private DateTime dateOfBirth;

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
