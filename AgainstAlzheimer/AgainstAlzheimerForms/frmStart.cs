using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgainstAlzheimerForms
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUserSesion ObjUserSesion = new frmUserSesion();
            ObjUserSesion.Show();
            Close();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin ObjectAdminLogin = new frmAdminLogin();
            ObjectAdminLogin.Show();
            Close();
        }
    }
}
