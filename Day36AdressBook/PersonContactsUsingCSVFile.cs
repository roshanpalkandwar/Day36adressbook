using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class PersonContactsUsingCSVFile
    {
        public static void CsvSerialize(List<Contacts> list)
        {
            string csvFilePath = @"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\CsvData1.txt";
      
        StreamWriter streamWriter = new StreamWriter(csvFilePath);
            CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords<Contacts>(list);
            streamWriter.Close();
            Console.WriteLine("Closed");
        }

        public static void CsvDeserialize()
        {
            string csvFilePath = @"C:\Users\User\Desktop\MysqlAssignment\Day36adressBook\Day36adressbook\Day36AdressBook\CsvData1.txt";

            StreamReader streamReader = new StreamReader(csvFilePath);
            CsvReader csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture);
            List<Contacts> contacts = csvReader.GetRecords<Contacts>().ToList();
            foreach (Contacts contact in contacts)
            {
                contact.Show();
            }
        }
    }
}
