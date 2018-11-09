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

            userName = textBox4.Text;
            oldPassw = textBox2.Text;
            newPassw = textBox1.Text;
            confPassw = textBox3.Text;

            SQL sqldatatable = new SQL();

            string statement = "update GeotemaUsers set passw ='" + newPassw + "' WHERE username = '" + userName + "'";
            //"UPDATE complain SET Name = @NAME,Email = @EMAIL,Message= @MESSAGE WHERE 


            sqldatatable.sqlconnectionInsert(statement);

            MessageBox.Show("Password Updated!");

            //Åbner AdminLogin vinduet
            this.Hide();
            AdminLogin AdminLoginWindow = new AdminLogin();
            AdminLoginWindow.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
