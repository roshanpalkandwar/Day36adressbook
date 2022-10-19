using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contacts(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public void Show()
        {
            Console.WriteLine(FirstName + "\t\t" + LastName + "\t\t" + Address + "\t\t" + City + "\t\t" + State + "\t\t" + Zip + "\t\t" + PhoneNumber + "\t\t" + Email);
        }
    }
}
