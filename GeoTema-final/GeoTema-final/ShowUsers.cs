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
    public partial class ShowUsersWindow : Form
    {
        string ConnectionString = "Data Source=192.168.4.113;Initial Catalog = fødselsrate_2017;User ID= sa;Password = Password123;integrated security = false";

        public ShowUsersWindow()
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Columns[0].Visible = false;

            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select Land.id, Land.land, Land.verdensdel, Rang.rang, Rang.fødselsrate from Land, Rang Where Land.id=Rang.id", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                BindingSource bindingSource = new BindingSource(dtbl, null);
                bindingSource.DataSource = dtbl;
                dataGridView1.DataSource = bindingSource;
            }
        }
    }
}
