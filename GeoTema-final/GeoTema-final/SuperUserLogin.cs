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
    public partial class SuperUserLogin : Form
    {
        public SuperUserLogin()
        {
            InitializeComponent();
        }

        private void LoginScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void GeoTemaLogoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ShowUsersButton_Click(object sender, EventArgs e)
        {
            //Åbner Showuser vinduet
            this.Hide();
            ShowUsersWindow ShowUsers = new ShowUsersWindow();
            ShowUsers.Show();
        }

        private void ModifyUserButton_Click(object sender, EventArgs e)
        {
            //Åbner Insertdata vinduet
            this.Hide();
            InsertData InsertData = new InsertData();
            InsertData.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Åbner LoginScreenStandard vinduet
            this.Hide();
            LoginScreenStandard LoginScreenStandard = new LoginScreenStandard();
            LoginScreenStandard.Show();
        }
    }
}
