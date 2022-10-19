using System.Collections.Generic;
using System.Security.Cryptography;

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
            Console.WriteLine("6. Get number of contact person in address book");
            Console.WriteLine("7. Read or Write the Address Book with Persons Contact into a File using File IO");
            Console.WriteLine("8. Read/Write the Address Book with Persons Contact as CSV File");
            Console.WriteLine("9. Read or Write the Address Book with Persons Contact as JSON File");
            Console.WriteLine("10. Get all enteries to DB");
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
                    
                    break;
                case 6:
                    GetNumber.GetNumberInAddressBook(list);
                    break;
                case 7:
                    PersonContactUsingFileIO personContactUsingFileIO = new PersonContactUsingFileIO();
                    personContactUsingFileIO.Serialize(list);
                    // personContactUsingFileIO.Deserialize();
                    break;
                case 8:
                    PersonContactsUsingCSVFile.CsvSerialize(list);
                    PersonContactsUsingCSVFile.CsvDeserialize();
                    break;
                case 9:
                   // PersonContactsUsingJSONFile.Serialize(list);
                    PersonContactsUsingJSONFile.Deserialize();
                    break;
                case 10:
                    RetrieveEntries entries = new RetrieveEntries();
                    entries.GetEntries();
                    break;

                default:
                    Console.WriteLine("Choose a appropriate option");
                    break;
                

            }
        }
    }
}