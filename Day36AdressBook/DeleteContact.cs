using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class DeleteContact
    {

        public static void DeleteContactInAddreddBook(List<Contacts> list)
        {
            Console.WriteLine("Enter a name you want to delete the contact ");
            string name = Console.ReadLine();
            if (list.Count > 0)
            {

                foreach (var contact in list)
                {
                    if (contact.FirstName == name)
                    {
                        list.Remove(contact);
                        Console.WriteLine("The contact delete successfully");
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("List is empty");
            }
            Console.WriteLine("After Delete the contact");
            foreach (Contacts contact in list)
            {
                contact.Show();
            }

        }
    }
}
