using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneBook;

class PhoneBook
{
    public List<Contact> Contacts {get; set;} 

    public void AddContact(Contact contact)
    {
        Contacts.Add(contact);
    }

    private void DisplayContactDitails (Contact contact)
    {
        System.Console.WriteLine($"Contact :{contact.Name}, {contact.Number}");
    }
    private void DisplayContactsDitails (List<Contact> contacts)
    {
        foreach (var contact in contacts)
        {
            System.Console.WriteLine($"Contact :{contact.Name}, {contact.Number}");
        }
    }
    public void DisplayContact( string number)
     {
        var contact = Contacts.FirstOrDefault(c => c.Number == number);
        
        if (contact == null)
        {
            System.Console.WriteLine("Contact not found!");
        }
        else
        {
            DisplayContactDitails(contact);
        }
     }
     public void DisplayAllContact()
     {
        DisplayContactsDitails(Contacts);
     }
     public void DisplayMatchingContacts(string searchPhrase)
     {
        var matchingContacts = Contacts.Where(c =>c.Name.Contains(searchPhrase)).ToList();
        DisplayContactsDitails(matchingContacts);
     }
}
