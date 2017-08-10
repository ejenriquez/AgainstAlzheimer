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
    public partial class frmReminders3 : Form
    {
        public frmReminders3()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmReminders2 ObjReminders2 = new frmReminders2();
            ObjReminders2.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmUserSesion ObjUserSesion = new frmUserSesion();
            ObjUserSesion.Show();
            Close();
        }

        private void frmReminders3_Load(object sender, EventArgs e)
        {
            if (File.Exists("Reminders_Pg3.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Reminders));
                FileStream read = new FileStream("Reminders_Pg3.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Reminders info = (Reminders)xs.Deserialize(read);
                lblVideo.Text = info.Video;
                read.Close();
            }
        }
    }
}
