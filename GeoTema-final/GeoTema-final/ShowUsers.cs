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
            else if (type == "StandardUser")
            {
                //Åbner Stanadrduser vinduet
                this.Hide();
                StandardUserLogin StandardUserLogin = new StandardUserLogin();
                StandardUserLogin.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Standard view af tables
        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                //den her metode viser/fylder data gridviewet
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select Land.id, Land.land, Land.verdensdel, Rang.rang, Rang.fødselsrate from Land, Rang Where Land.id=Rang.id", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                BindingSource bindingSource = new BindingSource(dtbl, null);
                bindingSource.DataSource = dtbl;
                dataGridView1.DataSource = bindingSource;
            }
        }

        //Søjle diagrammet
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                //Den her metode viser/fylder søjle diagrammet
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select Land.land, Land.verdensdel, Rang.rang, Rang.fødselsrate from Land, Rang Where Land.id=Rang.id", sqlCon);
                DataSet dts = new DataSet();
                sqlDa.Fill(dts);
                chart1.DataSource = dts;
                chart1.Series[0].XValueMember = "land";
                chart1.Series[0].YValueMembers = "fødselsrate";
                chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
                chart1.DataBind();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
