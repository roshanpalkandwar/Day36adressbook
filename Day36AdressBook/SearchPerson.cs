using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class SearchPerson
    {
        public static void SearchPersonInAddressBook(List<Contacts> list)
        {

            foreach (var contact in list.FindAll(e => (e.City == "nagpur" && e.Address == "Nashik")).ToList())
            {
                contact.Show();

                Console.WriteLine(contact.FirstName);
            }
        }
    }
}
