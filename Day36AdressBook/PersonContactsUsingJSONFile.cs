using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Day36AdressBook
{
    public class PersonContactsUsingJSONFile
    {
        public static void Serialize(List<Contacts> list)
        {
            string csvFilePath = @"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\CsvData.txt";

            StreamWriter streamWriter = new StreamWriter(csvFilePath);
            CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords<Contacts>(list);
            streamWriter.Close();
            Console.WriteLine("Closed");
        }

        public static void Deserialize()
        {
            string csvFilePath = @"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\CsvData.txt";

            string jsonFilePath = @"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\jsonData.txt";

            StreamReader streamReader = new StreamReader(csvFilePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            List<Contacts> contacts = csvReader.GetRecords<Contacts>().ToList();
            foreach (Contacts contact in contacts)
            {
                contact.Show();
            }

            JsonSerializer jsonSerializer = new JsonSerializer();
            using (StreamWriter stream = new StreamWriter(jsonFilePath))
            using (JsonWriter jsonWriter = new JsonTextWriter(stream))
            {
                jsonSerializer.Serialize(jsonWriter, contacts);
            }
        }
    }
}
