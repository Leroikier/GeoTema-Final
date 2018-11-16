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
    public partial class StandardUserLogin : Form
    {
        public StandardUserLogin()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Åbner LoginScreenStandard vinduet
            this.Hide();
            LoginScreenStandard LoginScreenStandard = new LoginScreenStandard();
            LoginScreenStandard.Show();
        }

        private void ShowUsersButton_Click(object sender, EventArgs e)
        {
            //Åbner Showuser vinduet
            this.Hide();
            ShowUsersWindow ShowUsers = new ShowUsersWindow();
            ShowUsers.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
