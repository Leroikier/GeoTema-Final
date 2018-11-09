using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace GeoTema_final
{
    class SQL
    {
        string ConnectionString = "Data Source=192.168.4.113;Initial Catalog = fødselsrate_2017;User ID= sa;Password = Password123;integrated security = false";

        //SQL Connection /Her opretter vi en forbindelse til vores SQL database.
        public string sqlconnection(string statement)
        {
            SQL s = new SQL();

            string userAccounts = "";

            //Using sørger for at lukke forbindelsen efter brug
            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {
                con1.Open();

                try
                {
                    DataTable userTable = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(statement, con1);
                    adapter.Fill(userTable);

                    userAccounts = userTable.Rows[0]["useraccount"].ToString();
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Wrong Username or Password");
                    MessageBox.Show(e.Message);
                }
            }
            return userAccounts;

        }

        public string sqlconnectionInsert(string statement)
        {
            SQL s = new SQL();

            string userAccounts = "";

            //Using sørger for at lukke forbindelsen efter brug
            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {
                con1.Open();

                try
                {
                    SqlCommand cmd = new SqlCommand(statement, con1);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    //MessageBox.Show("Wrong Username or Password");
                    MessageBox.Show(e.Message);
                }
            }
            return userAccounts;
        }
    }
}
