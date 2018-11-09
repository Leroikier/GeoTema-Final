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
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void ProcedButton_Click(object sender, EventArgs e)
        {
            //Åbner AdminLogin vinduet
            this.Hide();
            AdminLogin AdminLoginWindow = new AdminLogin();
            AdminLoginWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public static string land = "";
        public static string verdensdel = "";
        public static string rang = "";
        public static string fødselsrate = "";

        private void button2_Click(object sender, EventArgs e)
        {
            //For at hente værdier
            land = textBox3.Text;
            verdensdel = comboBox2.Text;
            rang = textBox1.Text;
            fødselsrate = textBox2.Text;

            SQL sqldatatable = new SQL();

            string statement = "Use fødselsrate_2017 insert into Land values ('" + land + "','" + verdensdel + "') insert into Rang values ('" + rang + "','" + fødselsrate + "')";

            sqldatatable.sqlconnectionInsert(statement);

            MessageBox.Show("Data Inserted!");
        }
    }
}
