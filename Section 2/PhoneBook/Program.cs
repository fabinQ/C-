using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace PhoneBook;
    public class phoneBook
    {
        Dictionary<string, int> PhoneBookContact = new Dictionary<string, int>();
        Dictionary<int, string> PhoneBookNumber = new Dictionary<int, string>();
        public phoneBook (string contactName, int phoneNumber )
        {
            string ContactName = contactName;
            int PhoneNumber = phoneNumber;
            AddContact(ContactName, PhoneNumber);
        }
        private void AddContact(string ContactName, int PhoneNumber)
        {
            PhoneBookContact.Add(ContactName, PhoneNumber);
            PhoneBookNumber.Add(PhoneNumber,ContactName);
        }
        private phoneBook FindConact(var SeekFragment)
        {
            
        }


    }