namespace AdressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AdressBook addressBook = new AdressBook();
            addressBook.addContacts("Kavya", "Bs", "Mysore", "Karnataka", "India", 571114, 7090324227, "abcd@gmail.com");
            addressBook.print();
            Console.ReadLine();
            
        }
    }
}