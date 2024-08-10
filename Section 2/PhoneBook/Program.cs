using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace PhoneBook;
    public class PhoneBook
    {
        private Dictionary<int, string> phoneBookNumber = new Dictionary<int, string>();
        public PhoneBook (){}
        private void AddContact(string ContactName, int PhoneNumber)
        {
            phoneBookNumber[PhoneNumber] = ContactName;
        }
        public void FindConact(string searchingValue)
        {
            int contactNumber;
            bool isNumber = Int32.TryParse(searchingValue, out contactNumber);
            if (isNumber) 
                {
                    if (phoneBookNumber.ContainsKey(contactNumber))
                    {
                        System.Console.WriteLine(phoneBookNumber[contactNumber]);
                    }
                    else
                    {
                        System.Console.WriteLine("Do not conain");
                    }
                }              
            else
            {
                foreach (var contact in phoneBookNumber)
                {
                if (contact.Value.Equals(searchingValue, StringComparison.OrdinalIgnoreCase))
                    {
                        System.Console.WriteLine(contact.Key.ToString(), contact.Value);
                    } 
                }
            }
        }

        public void ShowAllRecord()
        {
            foreach (var iteam in phoneBookNumber)
            {
                System.Console.WriteLine($"{iteam.Value} {iteam.Key}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                PhoneBook phoneBook = new PhoneBook();
                phoneBook.AddContact("John Doe", 123456789);
                phoneBook.AddContact("Jane Smith", 987654321);

                while (true)
                {
                    bool exitOption = false;
                    System.Console.WriteLine("What do you want?");
                    System.Console.WriteLine("1. Add contact.\n2. Search contact.\n3. Show all. \n4. Exit ");
                    string choice = System.Console.ReadLine();
                    int intChoice;
                    Int32.TryParse(choice, out intChoice);
                    switch (intChoice)
                    {
                        case 1:
                            System.Console.WriteLine("Enter your new contact name.");
                            string NewContactName = System.Console.ReadLine();
                            System.Console.WriteLine("and contact number.");
                            int NewContactNumber = Int32.Parse(System.Console.ReadLine());
                            phoneBook.AddContact(NewContactName, NewContactNumber);
                            break;
                        case 2:
                            System.Console.WriteLine("Enter your contact.");
                            string searchingContact = System.Console.ReadLine();
                            phoneBook.FindConact(searchingContact);
                            break;
                        case 3:
                            phoneBook.ShowAllRecord();
                            break;
                        case 4:
                            exitOption = true;
                            break;
                    }
                
                if (exitOption== true) break;
                }
            }
        }

    }