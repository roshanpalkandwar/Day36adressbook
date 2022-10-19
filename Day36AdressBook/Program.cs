namespace Day36AdressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Choose a option");
            Console.WriteLine("1. Create a Contacts in address book");
            Console.WriteLine("2. Add a contacts in address book");
            Console.WriteLine("Enter a number");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateContacts.CreateContactsInAddressBook();
                    break;
                
            }
        }
    }
}