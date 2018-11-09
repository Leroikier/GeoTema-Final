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
    }
}
