using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using PhoneBook;

namespace PhoneBook;
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("What do you want?");
            System.Console.WriteLine("1. Add contact.\n2. Display contact by number.\n3. Display all contacts. \n4. Search contacts");
            var phoneBook = new PhoneBook();
            
            var Inputchoice = System.Console.ReadLine();
            
            switch (Inputchoice)
            {
                case "1":
                    System.Console.WriteLine("Insert your new contact name.");
                    string NewContactName = System.Console.ReadLine();

                    System.Console.WriteLine("and contact number.");
                    string NewContactNumber = System.Console.ReadLine();

                    var newContact = new Contact(NewContactName, NewContactNumber);
                    
                    
                    phoneBook.AddContact(newContact);
                    break;
                case "2":
                    System.Console.WriteLine("Insert your contact.");
                    string searchingContact = System.Console.ReadLine();
                    phoneBook.DisplayContact(searchingContact);
                    break;
                case "3":
                    phoneBook.DisplayAllContact();
                    break;
                case "4":
                    System.Console.WriteLine("Insert searching fragment.");
                    string searchingFragment = System.Console.ReadLine();
                    phoneBook.DisplayMatchingContacts(searchingFragment);
                    break;
                default:
                    System.Console.WriteLine("Invalid operation");
                    break;
            }
        
        }
    }