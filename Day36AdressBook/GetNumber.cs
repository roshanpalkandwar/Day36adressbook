using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class GetNumber
    {
        public static void GetNumberInAddressBook(List<Contacts> list)
        {
            foreach (var contact in list.FindAll(e => (e.City == "nagpur" && e.State == "Maharashtra")).ToList())
            {
                contact.Show();

                Console.WriteLine("Name : " + contact.FirstName + "\t" + "Number : " + contact.PhoneNumber);
            }
        }
    }
}
