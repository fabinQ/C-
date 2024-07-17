using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace PhoneBook;
    public class PhoneBook
    {
        public Dictionary<int, string> phoneBookNumber = new Dictionary<int, string>();
        public PhoneBook (string contactName, int phoneNumber )
        {
            string ContactName = contactName;
            int PhoneNumber = phoneNumber;
            AddContact(ContactName, PhoneNumber);
        }
        private void AddContact(string ContactName, int PhoneNumber)
        {
            phoneBookNumber.Add(PhoneNumber,ContactName);
        }
        private Dictionary<int,string> FindConact(string searchingNumber)
        {
            try 
            {
                int contactNumber = Int32.Parse(searchingNumber);
                if (phoneBookNumber.ContainsKey(contactNumber))
                {
                    return new Dictionary<int, string>(contactNumber, phoneBookNumber[contactNumber]);
                }
                else
                {
                    System.Console.WriteLine("Do not conain");
                }
            }  
            return Dictionary(phoneBookNumber.Values(contactNumber), contactNumber);      
            }

        public void ShowAllRecord()
        {
            foreach (var iteam in phoneBookNumber.Keys)
            {
                System.Console.WriteLine(phoneBookNumber(iteam));
            }
        }

    }