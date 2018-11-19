using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoTema_final
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string type = LoginScreenStandard.type;

        private void ProcedButton_Click(object sender, EventArgs e)
        {
            if (type == "AdminUser")
            {
                //Åbner AdminLogin vinduet
                this.Hide();
                AdminLogin AdminLoginWindow = new AdminLogin();
                AdminLoginWindow.Show();
            }
            else if (type == "SuperUser")
            {
                //Åbner Superuser vinduet
                this.Hide();
                SuperUserLogin SuperuserLogin = new SuperUserLogin();
                SuperuserLogin.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static string username = "";
        public static string passw = "";
        public static string useraccount = "";

        private void AddButton_Click(object sender, EventArgs e)
        {
            //For at hente værdier
            username = UsernameBox.Text;
            passw = PasswordBox.Text;
            useraccount = comboBox1.Text;

            //Forbindelse til databasen
            SQL sqldatatablecon = new SQL();

            string statement = "";

            switch (useraccount)
            {
                case "AdminUser":
                    {
                        //For at create et login via username og password, ændre i server rollen, så Adminbruger kan tilføje medlemmer og derefter tilføjer brugeren til tablet samtidig, og til sidst tilføjer til AdminUser (SQL)brugerdelen
                        statement = "use master Create login " + username + " with password = '" + passw + "' alter server role AdminBruger add member " + username + " use fødselsrate_2017 create user " + username + " From login " + username + " alter role AdminUser add member " + username;
                        break;
                    }
                case "SuperUser":
                    {
                        statement = "use master Create login " + username + " with password = '" + passw + "' use fødselsrate_2017 create user " + username + " From login " + username + " alter role SuperUser add member " + username;
                        break;
                    }
                case "StandardUser":
                    {
                        statement = "use master Create login " + username + " with password = '" + passw + "' use fødselsrate_2017 create user " + username + " From login " + username + " alter role StandardUser add member " + username;
                        break;
                    }                
            }
            //insert statementen
            string statement1 = "Use fødselsrate_2017 insert into GeotemaUsers values ('" + username + "','" + passw + "','" + useraccount + "')";
            sqldatatablecon.sqlconnectionInsert(statement);
            sqldatatablecon.sqlconnectionInsert(statement1);

            MessageBox.Show("Succes User Created");

            //Åbner CreateUser vinduet
            this.Hide();
            CreateUser CreateUser = new CreateUser();
            CreateUser.Show();
        }
    }
}
