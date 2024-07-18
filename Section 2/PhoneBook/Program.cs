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
        public KeyValuePair<int,string>? FindConact(string searchingValue)
        {
            int contactNumber;
            bool isNumber = Int32.TryParse(searchingValue, out contactNumber);
            if (isNumber) 
                {
                    if (phoneBookNumber.ContainsKey(contactNumber))
                    {
                        return new KeyValuePair<int, string>(contactNumber, phoneBookNumber[contactNumber]);
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
                        return new KeyValuePair<int, string>(contact.Key, contact.Value);
                    } 
                }
            }
            return null;
        }

        public void ShowAllRecord()
        {
            foreach (var iteam in phoneBookNumber)
            {
                System.Console.WriteLine($"Contact: {iteam.Value} Number:{iteam.Key}");
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
                    System.Console.WriteLine("What do you want?");
                    System.Console.WriteLine("1. Add contact.\n2.Search contact.\n3.Show all. ");
                    string choice = System.Console.ReadLine();
                    int intChoice;
                    Int32.TryParse(choice, out intChoice);
                    switch (intChoice)
                    {
                        case 1:
                            System.Console.WriteLine("case 1");
                        case 2:
                            System.Console.WriteLine("case 2");

                    }
                }
            }
        }

    }