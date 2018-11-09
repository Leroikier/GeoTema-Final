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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void LoginScreenLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            //Åbner LoginScreenStandard vinduet
            this.Hide();
            LoginScreenStandard LoginScreenStandard = new LoginScreenStandard();
            LoginScreenStandard.Show();
        }

        private void GeoTemaLogoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ModifyUserButton_Click(object sender, EventArgs e)
        {
            //Åbner Insertdata vinduet
            this.Hide();
            InsertData InsertData = new InsertData();
            InsertData.Show();
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            //Åbner ResetPassword vinduet
            this.Hide();
            ResetPasswordWindow ResetPassword = new ResetPasswordWindow();
            ResetPassword.Show();
        }

        private void ShowUsersButton_Click(object sender, EventArgs e)
        {
            //Åbner Showuser vinduet
            this.Hide();
            ShowUsersWindow ShowUsers = new ShowUsersWindow();
            ShowUsers.Show();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            //Åbner CreateUser vinduet
            this.Hide();
            CreateUser CreateUser = new CreateUser();
            CreateUser.Show();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
