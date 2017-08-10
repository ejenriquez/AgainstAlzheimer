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
    public partial class frmUserSesion : Form
    {
        public frmUserSesion()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmStart ObjectStart = new frmStart();
            ObjectStart.Show();
            Close();
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            frmReminders1 ObjectReminders = new frmReminders1();
            ObjectReminders.Show();
            Close();
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            frmGameMenu ObjectGameMenu = new frmGameMenu();
            ObjectGameMenu.Show();
            Close();
        }
    }
}
