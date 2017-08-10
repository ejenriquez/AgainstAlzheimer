using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using AgainstAlzheimerLibrary;

namespace AgainstAlzheimerForms
{
    public partial class frmReminders2 : Form
    {
        Reminders ObjEditReminders = new Reminders();
        public frmReminders2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmReminders1 ObjReminders = new frmReminders1();
            ObjReminders.Show();
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmReminders3 ObjReminders = new frmReminders3();
            ObjReminders.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserSesion ObjUserSesion = new frmUserSesion();
            ObjUserSesion.Show();
            Close();
        }

        private void frmReminders2_Load(object sender, EventArgs e)
        {
            if (File.Exists("Reminders_Pg2.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Reminders));
                FileStream read = new FileStream("Reminders_Pg2.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Reminders info = (Reminders)xs.Deserialize(read);

                lblFamily1.Text = info.Family1;
                lblFamily2.Text = info.Family2;
                lblFamily3.Text = info.Family3;
                lblFamily4.Text = info.Family4;
                lblFamily5.Text = info.Family5;
                lblFamily6.Text = info.Family6;
                lblFamily7.Text = info.Family7;
                lblFamily8.Text = info.Family8;

                read.Close();
            }
        }
    }
}
