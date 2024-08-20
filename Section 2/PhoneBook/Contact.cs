using System;
using System.Reflection.Metadata.Ecma335;

namespace PhoneBook;

public class Contact
{
    public Contact(string name, string number)
    {
        Name = name;
        Number = number;

        bool isNumeric = double.TryParse(Number, out double numericValue);

        if (Name == null || Number == null) throw new ArgumentNullException("Contact name/Number cannot be empty and must contain at least 3 letters!");
        else if (Name.Length<=3) throw new ArgumentException("Contact name must have more than 3 letters!");
        else if (Number.Length != 9) throw new ArgumentException ("The phone number must be 9 digits long.");
        else if (isNumeric == false) throw new ArgumentException ("Something is wrong with the phone number. There are not only digits.");
    }
    public string Name {get;set;}
    public string Number {get;set;}

}
