using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36AdressBook
{
    public class InsertContactUsingThread
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBookService;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        public void AddContact(ContactModel contactModel)
        {
            try
            {
                Task thread = new Task(() =>
                {
                    using (connection)
                    {
                        SqlCommand command = new SqlCommand("SpAddContactDetails", connection);
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FirstName", contactModel.FirstName);
                        command.Parameters.AddWithValue("@LastName", contactModel.LastName);
                        command.Parameters.AddWithValue("@Address", contactModel.Address);
                        command.Parameters.AddWithValue("@City", contactModel.City);
                        command.Parameters.AddWithValue("@State", contactModel.State);
                        command.Parameters.AddWithValue("@Zip", contactModel.Zip);
                        command.Parameters.AddWithValue("@PhoneNumber", contactModel.PhoneNumber);
                        command.Parameters.AddWithValue("@Email", contactModel.Email);

                        connection.Open();
                        var result = command.ExecuteNonQuery();
                        if (result != 0)
                        {
                            Console.WriteLine("Data Added");
                        }
                        else
                        {
                            throw new Exception();
                        }

                        connection.Close();
                    }
                });

                thread.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
