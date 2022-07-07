using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsIDs
{
    internal class Data
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsIDs;Data Source=LAPTOP\\SQLEXPRESS");

        public void InsertContact(Contact contact) 
        {
            try
            {
                conn.Open();
                string query = @"
                            INSERT INTO Contact (FirstName, LastName, Cedula, LugarNac, Sexo, Sangre, EstCiv, Ocup) 
                            VALUES (@FirstName, @LastName, @Cedula, @LugarNac, @Sexo, @Sangre, @EstCiv, @Ocup)";

                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String;

                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter Cedula = new SqlParameter("@Cedula", contact.Cedula);
                SqlParameter LugarNac = new SqlParameter("@LugarNac", contact.LugarNac);
                SqlParameter Sexo = new SqlParameter("@Sexo", contact.Sexo);
                SqlParameter Sangre = new SqlParameter("@Sangre", contact.Sangre);
                SqlParameter EstCiv = new SqlParameter("@EstCiv", contact.EstCiv);
                SqlParameter Ocup = new SqlParameter("@Ocup", contact.Ocup);






                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(Cedula);
                command.Parameters.Add(LugarNac);
                command.Parameters.Add(Sexo);
                command.Parameters.Add(Sangre);
                command.Parameters.Add(EstCiv);
                command.Parameters.Add(Ocup);






                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            try
            {
                conn.Open();
                string query = @"SELECT Id, FirstName, Cedula, LugarNac, Sexo, Sangre, EstCiv, Ocup 
                                FROM Contact ";

                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contacts.Add(new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Cedula = reader["Cedula"].ToString(),
                        LugarNac = reader["LugarNac"].ToString(),
                        Sexo = reader["Sexo"].ToString(),
                        Sangre = reader["Sangre"].ToString(),
                        EstCiv = reader["EstCiv"].ToString(),
                        Ocup = reader["Ocup"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }

            return contacts;
        }
    }
}
