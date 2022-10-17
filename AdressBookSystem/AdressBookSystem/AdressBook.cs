using System;
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
            bool duplicate = equals(fistName, lastName);

            if (!duplicate)
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
            else
                Console.WriteLine("Cannot add duplicate Contact");
        }
        private bool equals(string fName, string lName)
        {
            if (this.contactList.Any(e => e.fistName == fName && e.lastName == lName))
                return true;
            else
                return false;
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

        public void edit(string firstName, string lastName)
        {
            Contact contactToBeEdited = null;
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                    this.editThisContact(contact);

            }

        }
        public void editThisContact(Contact contactToBeEdited)
        {
            bool status = true;
            while (status == true)
            {
                Console.WriteLine("Enter 1 to edit FirstName");
                Console.WriteLine("Enter 2 to edit LastName");
                Console.WriteLine("Enter 3 to edit Address");
                Console.WriteLine("Enter 4 to edit City");
                Console.WriteLine("Enter 5 to edit State");
                Console.WriteLine("Enter 6 to edit Zip");
                Console.WriteLine("Enter 7 to edit PhoneNumber");
                Console.WriteLine("Enter 8 to edit Email Id");
                Console.WriteLine("Enter 9 if Editing is done");
                Console.WriteLine("Enter 10 if Delete is done");


                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        Console.WriteLine("Enter new FirstName");
                        string fName = Console.ReadLine();
                        contactToBeEdited.fistName = fName;
                        break;

                    case 2:
                        Console.WriteLine("Enter new LastName");
                        string lName = Console.ReadLine();
                        contactToBeEdited.lastName = lName;
                        break;

                    case 3:
                        Console.WriteLine("Enter new Address");
                        string address = Console.ReadLine();
                        contactToBeEdited.address = address;
                        break;

                    case 4:
                        Console.WriteLine("Enter new City");
                        string city = Console.ReadLine();
                        contactToBeEdited.city = city;
                        break;

                    case 5:
                        Console.WriteLine("Enter new State");
                        string state = Console.ReadLine();
                        contactToBeEdited.state = state;
                        break;

                    case 6:
                        Console.WriteLine("Enter new Zip");
                        int zip = Convert.ToInt32(Console.ReadLine());
                        contactToBeEdited.zip = zip;
                        break;

                    case 7:
                        Console.WriteLine("Enter new PhoneNumber");
                        long phoneNumber = long.Parse(Console.ReadLine());
                        contactToBeEdited.phoneNumber = phoneNumber;
                        break;

                    case 8:
                        Console.WriteLine("Enter new Email Id");
                        string email = Console.ReadLine();
                        contactToBeEdited.email = email;
                        break;

                    case 9:
                        Console.WriteLine("Editing done.New Contact :-");
                        this.printSpecificContact(contactToBeEdited);
                        break;

                    default:
                        status = false;
                        break;
                }
            }
        }
        public void printSpecificContact(Contact contact)
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
        public void delete(string firstName, string lastName)
        {
            Contact contactToBeDeleted = null;
            foreach (Contact contact in this.contactList)
            {
                if (contact.fistName == firstName && contact.lastName == lastName)
                {
                    contactToBeDeleted = contact;
                    this.contactList.Remove(contactToBeDeleted);
                    break;
                }
            }
            if (contactToBeDeleted == null)
                Console.WriteLine("No such contact exists");
            else
                Console.WriteLine("Deletion Done.");
        }
        public void Search()
        {
            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("1. City 2. State");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    Console.WriteLine("Enter your City Name:");
                    String NameToSearchInCity = Console.ReadLine();
                    foreach (Contact personal_Details in this.contactList.FindAll(e => e.city == NameToSearchInCity))
                    {
                        Console.WriteLine("City of " + personal_Details.fistName + "" + personal_Details.lastName + " is : " + personal_Details.city);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter your State Name:");
                    String nameToSearchInState = Console.ReadLine();
                    foreach (Contact personal_Details in this.contactList.FindAll(e => e.state == nameToSearchInState))
                    {
                        Console.WriteLine("City of " + personal_Details.fistName + "" + personal_Details.lastName + " is : " + personal_Details.state);
                    }
                    break;
                default:
                    Console.WriteLine("Contact not found");
                    break;

            }
        }
    }
}
