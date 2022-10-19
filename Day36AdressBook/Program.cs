using System.Collections.Generic;

namespace Day36AdressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            List<Contacts> list = new List<Contacts>();
           // CreateContacts.CreateContactsInAddressBook(list);

            Console.WriteLine("Choose a option");
            Console.WriteLine("1. Create a Contacts in address book");
            Console.WriteLine("2. Add a contacts in address book");
            Console.WriteLine("3. Delete the contact in address book");
            Console.WriteLine("4. Add multiple person in address book");
            Console.WriteLine("5. Search person in address book");
            Console.WriteLine("Enter a number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateContacts.CreateContactsInAddressBook(list);
                    break;
                case 2:
                    AddNewContacts.AddNewcontactsInAddressBook();
                    break;
                case 3:

                    DeleteContact.DeleteContactInAddreddBook(list);

                    break;
                case 4:
                    AddMultiplePerson.AddMultiplePersonInAddressBook(list);
                    break;
                case 5:
                    SearchPerson.SearchPersonInAddressBook(list);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
                
            }
        }
    }
}