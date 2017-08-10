using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using AgainstAlzheimerLibrary;

namespace AgainstAlzheimerForms
{
    public partial class frmReminders1 : Form
    {
        Reminders ObjEditReminders = new Reminders();

        public frmReminders1()
        {
            InitializeComponent();
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            frmReminders2 ObjReminders = new frmReminders2();
            ObjReminders.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserSesion ObjUserSesion = new frmUserSesion();
            ObjUserSesion.Show();
            Close();
        }

        private void frmReminders1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Reminders_Pg1.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Reminders));
                FileStream read = new FileStream("Reminders_Pg1.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Reminders info = (Reminders)xs.Deserialize(read);
                lblNames.Text = info.Names;
                lblLastNames.Text = info.LastNames;
                lblAge.Text = info.Age.ToString();
                lblBirthday.Text = info.Birthday.ToShortDateString();
                lblWhereBorn.Text = info.WhereBorn;
                lblCity.Text = info.City;
                lblAddress.Text = info.Address;

                read.Close();
            }
        }
    }
}
