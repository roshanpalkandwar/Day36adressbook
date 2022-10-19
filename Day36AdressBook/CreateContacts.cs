using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class CreateContacts
    {
        public static void CreateContactsInAddressBook(List<Contacts> list)
        {
            Contacts user1 = new Contacts("Rohit", "Lokhande", "pune", "Nashik", "Maharashtra", "456060", "7777798662", "Rohit@gmail.com");
            Contacts user2 = new Contacts("Vikas", "More", "nagpur", "Nashik", "Maharashtra", "456160", "7564254862", "Vikas@gmail.com");
            Contacts user3 = new Contacts("Vishal", "Sharma", "Nashik", "Nagpur", "Maharashtra", "456010", "6284589721", "Vishal@gmail.com");
            Contacts user4 = new Contacts("Ramesh", "Patil", "satara", "Pune", "Maharashtra", "456611", "9888256341", "Ramesh@gmail.com");
            Contacts user5 = new Contacts("Sunil", "Tiwari", "pune", "Pune", "maharashtra", "4566612", "7778263548", "Sunil@gmail.com");
            list.Add(user1);
            list.Add(user2);
            list.Add(user3);
            list.Add(user4);
            list.Add(user5);
            foreach (Contacts contact in list)
            {
                contact.Show();
            }






        }
    }
}
