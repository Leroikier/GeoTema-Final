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
    public partial class ResetPasswordWindow : Form
    {
        public ResetPasswordWindow()
        {
            InitializeComponent();
        }

        public static string userName = "";
        public static string oldPassw = "";
        public static string newPassw = "";
        public static string confPassw = "";

        private void ProcedButton_Click(object sender, EventArgs e)
        {
            //Variabler til og læse fra textboxe
            userName = textBox4.Text;
            oldPassw = textBox2.Text;
            newPassw = textBox1.Text;
            confPassw = textBox3.Text;

            SQL sqldatatable = new SQL();

            //Select statement
            string statement2 = "use fødselsrate_2017 select passw from GeotemaUsers where passw = '" + oldPassw + "'";

            sqldatatable.sqlcheck(statement2);

            if (sqldatatable.sqlcheck(statement2))
            {
                //Hvis det nye og confirm password ikke passer sammen og er under 6 length
                if (newPassw == confPassw && newPassw.Length > 6)
                {
                    //Statement til og ændre password i databasen
                    string statement = "use fødselsrate_2017 update GeotemaUsers set passw ='" + newPassw + "' WHERE username = '" + userName + "'";

                    //Statement til og ændre password i "SQL user delen"
                    string statement1 = "use master alter login " + userName + " with password = '" + newPassw + "'";

                    sqldatatable.sqlconnectionInsert(statement);
                    sqldatatable.sqlconnectionInsert(statement1);

                    MessageBox.Show("Password Updated!");

                    this.Hide();
                    ResetPasswordWindow ResetPassword = new ResetPasswordWindow();
                    ResetPassword.Show();
                }
                else
                {
                    MessageBox.Show("New password does not match confirm password \nOr the new password is under 6 characters");
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect!");
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string type = LoginScreenStandard.type;

        private void button1_Click(object sender, EventArgs e)
        {
            //Hvis brugeren er en adminuser åbnes admin vinduet og vis han er superuser åbnes superuser
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
    }
}
