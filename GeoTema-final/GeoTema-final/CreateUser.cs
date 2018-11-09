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

        private void ProcedButton_Click(object sender, EventArgs e)
        {
            //Åbner AdminLogin vinduet
            this.Hide();
            AdminLogin AdminLoginWindow = new AdminLogin();
            AdminLoginWindow.Show();
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

            SQL sqldatatable = new SQL();

            string statement = "Use fødselsrate_2017 insert into GeotemaUsers values ('" + username + "','" + passw + "','" + useraccount + "')";

            sqldatatable.sqlconnectionInsert(statement);

            MessageBox.Show("Succes User Created");
        }
    }
}
