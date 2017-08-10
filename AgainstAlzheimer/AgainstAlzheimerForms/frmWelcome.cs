using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using AgainstAlzheimerLibrary;

namespace AgainstAlzheimerForms
{
    public partial class frmWelcome : Form
    {
        private Animation ObjectAnimation = new Animation();
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            //Cargar flash de bienvenida
            ObjectAnimation.LoadFlashAnimation(SWFContent, @"\Resources\Animations\Bienvenida.swf");
            ObjectAnimation.PlayFlashAnimation(SWFContent);
            timer1.Start();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStart ObjectStart = new frmStart();
            ObjectStart.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            frmStart ObjectStart = new frmStart();
            ObjectStart.Show();
        }
    }
}
