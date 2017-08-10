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
    public partial class frmEditReminders3 : Form
    {
        Reminders ObjEditReminders = new Reminders();
        public frmEditReminders3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ObjEditReminders.Video = txtVideo.Text;

            SaveXML.SaveData(ObjEditReminders, "Reminders_Pg3.xml");

            MessageBox.Show("Información guardada correctamente", "Mensaje de control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEditReminders2 ObjEditReminders2 = new frmEditReminders2();
            ObjEditReminders2.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmAdminSesion ObjAdminSesion = new frmAdminSesion();
            ObjAdminSesion.Show();
            Close();
        }

        private void frmEditReminders3_Load(object sender, EventArgs e)
        {
            if (File.Exists("Reminders_Pg3.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Reminders));
                FileStream read = new FileStream("Reminders_Pg3.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Reminders info = (Reminders)xs.Deserialize(read);
                txtVideo.Text = info.Video;
                read.Close();
            }
        }
    }
}
