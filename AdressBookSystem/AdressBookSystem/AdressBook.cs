﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBookSystem
{
    class AdressBook
    {
        private List<Contact> contactList;
        public AdressBook()
        {
            contactList = new List<Contact>();
        }
        public void addContacts(string fistName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            Contact contact = new Contact();
            contact.fistName = fistName;
            contact.lastName = lastName;
            contact.address = address;
            contact.city = city;
            contact.state = state;
            contact.zip = zip;
            contact.phoneNumber = phoneNumber;
            contact.email = email;
            contactList.Add(contact);
        }
        public void print()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("FirstName: " + contact.fistName);
                Console.WriteLine("LastName: " + contact.lastName);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("Zip: " + contact.zip);
                Console.WriteLine("PhoneNumber: " + contact.phoneNumber);
                Console.WriteLine("Email id: " + contact.email);
            }
        }
    }
}
    

