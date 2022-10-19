using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class EditExistingContact
    {
        public static void EditExistingContactInAddressBook(List<Contacts> list)
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();

            bool flag = false;
            foreach (var contactList in list)
            {
                if (contactList.FirstName == name)
                {
                    flag = true;
                    Console.WriteLine("Enter your choice for the field you want to edit\n1.First Name\n2.Last Name\n3.Address\n4.city\n5.state\n6.Email\n7.PinCode\n8.Phone Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            ;
                            Console.WriteLine("Enter a First Name");
                            string firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter a Last Name");
                            string lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter a Address");
                            string address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter a state");
                            string state = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter a city");
                            string city = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter a zip code");
                            string zip = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter a phone number");
                            string phoneNumber = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter a email");
                            string email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Enter right choice");
                            break;

                    }
                }

            }
            if (flag == false)
            {
                Console.WriteLine("the given first Name Contact not exits");
            }
            foreach (Contacts contacts in list)
            {
                contacts.Show();
            }
        }
    }
}
