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
    public partial class frmEditReminders1 : Form
    {
        Reminders ObjEditReminders = new Reminders();
        public frmEditReminders1()
        {
            InitializeComponent();
        }

        private void frmEditReminders1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Reminders_Pg1.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Reminders));
                FileStream read = new FileStream("Reminders_Pg1.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Reminders info = (Reminders)xs.Deserialize(read);
                txtNames.Text = info.Names;
                txtLastNames.Text = info.LastNames;
                txtAge.Text = info.Age.ToString();
                dtpBirthday.Value = info.Birthday;
                txtWhereBorn.Text = info.WhereBorn;
                txtCity.Text = info.City;
                txtAddress.Text = info.Address;

                read.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEditReminders.Names = txtNames.Text;
                ObjEditReminders.LastNames = txtLastNames.Text;
                ObjEditReminders.Age = int.Parse(txtAge.Text);
                ObjEditReminders.Birthday = dtpBirthday.Value;
                ObjEditReminders.WhereBorn = txtWhereBorn.Text;
                ObjEditReminders.City = txtCity.Text;
                ObjEditReminders.Address = txtAddress.Text;

                SaveXML.SaveData(ObjEditReminders, "Reminders_Pg1.xml");
            }
            catch
            {
                MessageBox.Show("Por favor llene todos los campos...", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Información guardada correctamente", "Mensaje de control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNext_Click(object sender, EventArgs e)
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

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha = dtpBirthday.Value;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/CompleteFamily.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/CompleteFamily.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/CompleteFamily.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/CompleteFamily.jpg");
                picCompleteFamily.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
