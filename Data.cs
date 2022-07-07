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
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsIDs;Data Source=DESKTOP\\QLEXPRESS");

        public void InsertContact(Contact contact) 
        {
            try
            {
                conn.Open();
                string query = @"
                        INSERT INTO 
 
                                ";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
