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
    public partial class frmAdminSesion : Form
    {
        public frmAdminSesion()
        {
            InitializeComponent();
        }

        private void frmAdminSesion_Load(object sender, EventArgs e)
        {

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frmAccount ObjAccount = new frmAccount();
            ObjAccount.Show();
            Close();
        }

        private void btnReportView_Click(object sender, EventArgs e)
        {

        }

        private void btnRemindersEdit_Click(object sender, EventArgs e)
        {
            frmEditReminders1 ObjEditReminders = new frmEditReminders1();
            ObjEditReminders.Show();
            Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmStart ObjStart = new frmStart();
            ObjStart.Show();
            Close();
        }
    }
}
