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
            System.Console.WriteLine("1. Add contact.\n2. Search contact.\n3. Show all. \n4. Exit ");

            
            var Inputchoice = System.Console.ReadLine();
            
            switch (Inputchoice)
            {
                case "1":
                    System.Console.WriteLine("Insert your new contact name.");
                    string NewContactName = System.Console.ReadLine();

                    System.Console.WriteLine("and contact number.");
                    string NewContactNumber = System.Console.ReadLine();

                    var newContact = new Contact(NewContactName, NewContactNumber);
                    
                    PhoneBook.AddContact(newContact);
                    break;
                case "2":
                    System.Console.WriteLine("Enter your contact.");
                    string searchingContact = System.Console.ReadLine();
                    phoneBook.FindConact(searchingContact);
                    break;
                case "3":
                    phoneBook.ShowAllRecord();
                    break;
                case "4":
                    exitOption = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid operation");
                    break;
            }
        
        }
    }