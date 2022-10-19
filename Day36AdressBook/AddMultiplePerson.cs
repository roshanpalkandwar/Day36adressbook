using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class AddMultiplePerson
    {
        public static void AddMultiplePersonInAddressBook(List<Contacts> list)
        {
            Console.WriteLine("how many person you want to add");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Add a new contacts in adderss book");
                Console.WriteLine("Enter a First Name");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter a Last Name");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter a Address");
                string address = Console.ReadLine();
                Console.WriteLine("Enter a state");
                string state = Console.ReadLine();
                Console.WriteLine("Enter a city");
                string city = Console.ReadLine();
                Console.WriteLine("Enter a zip code");
                string zip = Console.ReadLine();
                Console.WriteLine("Enter a phone number");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter a email");
                string email = Console.ReadLine();
                Contacts user = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
                list.Add(user);
            }
            foreach (Contacts contact in list)
            {
                contact.Show();
            }
        }
    }
}
