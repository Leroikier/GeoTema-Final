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
    public partial class ChangeUserInformationWindow : Form
    {
        public ChangeUserInformationWindow()
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
    }
}
