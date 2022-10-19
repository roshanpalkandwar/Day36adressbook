using Day36AdressBook;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRetriveEnteries()
        {
            RetrieveEntries entries = new RetrieveEntries();

            entries.GetEntries();

        }
        [TestMethod]
        public void GivenContactDetailsAbleToUpdate()
        {
            UpdateContact update = new UpdateContact();
            ContactModel contact = new ContactModel();

            contact.FirstName = "roshani";
            contact.Address = "Nashik";
            contact.City = "Nashik";
            contact.Zip = 456601;
            update.EditContact(contact);
        }
    }
}