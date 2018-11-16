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


        string ConnectionString = "Data Source=192.168.4.113;Initial Catalog = fødselsrate_2017;User ID=" + LoginScreenStandard.username + ";Password = " + LoginScreenStandard.passw + ";integrated security = false";

        //For at oprette forbindelse og select data
        public string sqlconnection(string statement, string user, string pass)
        {
            SQL s = new SQL();

            string userAccounts = "";
            

            //Using sørger for at lukke forbindelsen efter brug
            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {
                try
                {
                    //Connection åbnes
                    con1.Open();

                    //Et nyt datatable bliver lavet
                    DataTable userTable = new DataTable();

                    //Laver en adapter som tar statement og con1 som parametre
                    SqlDataAdapter adapter = new SqlDataAdapter(statement, con1);

                    //Tilføjer dataten til en parameter så det ikke er rå SQL commmands serveren modtar
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@username", user));
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@passw", pass));

                    //Usertable fyldes via adapteren
                    adapter.Fill(userTable);

                    //Der fyldes useraccount ud via rows [0] som laver det om til en string
                    userAccounts = userTable.Rows[0]["useraccount"].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Wrong username or Password");
                }
            }
            return userAccounts;
        }


        //For at oprette forbindelse og insert data
        public string sqlconnectionInsert(string statement)
        {
            SQL s = new SQL();

            string userAccounts = "";

            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {                
                try
                {
                    con1.Open();
                    SqlCommand cmd = new SqlCommand(statement, con1);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return userAccounts;
        }


        //En check funktion 
        public bool sqlcheck(string statement)
        {
            bool Check = true;

            SQL s = new SQL();
            
            using (SqlConnection con1 = new SqlConnection(ConnectionString))
            {
                con1.Open();

                    DataTable userTable = new DataTable();

                    SqlDataAdapter adapter = new SqlDataAdapter(statement, con1);
                    adapter.Fill(userTable);

                    //Hvis der findes noget i usertablet sættes check til true
                    if (userTable.Rows.Count > 0)
                    {
                        Check = true;
                    }
                    else
                    {
                        Check = false;
                    }
            }
            return Check;
        }
    }
}
