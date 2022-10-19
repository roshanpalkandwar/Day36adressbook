using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class PersonContactUsingFileIO
    {
        public void Serialize(List<Contacts> list )
        {
            FileStream file = new FileStream(@"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\Contacts1.txt", FileMode.OpenOrCreate);

            BinaryFormatter formatter1 = new BinaryFormatter();
            formatter1.Serialize(file, list);
            file.Close();
        }

        public void Deserialize()
        {
            FileStream fileStream = new FileStream(@"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\Contacts.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Contacts deserialize = (Contacts)formatter.Deserialize(fileStream);

            deserialize.Show();

        }

    }
}
