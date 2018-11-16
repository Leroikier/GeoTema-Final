using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoTema_final
{
    public partial class LoginScreenStandard : Form
    {
        public LoginScreenStandard()
        {
            InitializeComponent();
        }

        public static string username = "";
        public static string passw = "";
        public static string type;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            username = Usernamebox.Text;
            passw = Passwordbox.Text;

            SQL sqldatatable = new SQL();

            //Login stringen som styrer hvor den kigger på om brugere eksitere //Samtidig er det sikret i mod simpel SQL injection
            string constring = "use fødselsrate_2017 select useraccount From GeotemaUsers where username = @username And passw = @passw";

            string userAccounts = sqldatatable.sqlconnection(constring, username, passw);

            type = userAccounts;

            //Alt efter hvilken user der logger ind åbnes det ønskede vindue
            switch (userAccounts)
            {
                case "AdminUser":
                {
                        //Åbner AdminLogin vinduet
                        this.Hide();
                        AdminLogin AdminLoginWindow = new AdminLogin();
                        AdminLoginWindow.Show();
                        break;
                }
                case "SuperUser":
                {
                        //Åbner Superuser vinduet
                        this.Hide();
                        SuperUserLogin SuperuserLogin = new SuperUserLogin();
                        SuperuserLogin.Show();
                        break;
                }
                case "StandardUser":
                {
                        //Åbner Stanadrduser vinduet
                        this.Hide();
                        StandardUserLogin StandardUserLogin = new StandardUserLogin();
                        StandardUserLogin.Show();
                        break;
                }
      
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usernamebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
