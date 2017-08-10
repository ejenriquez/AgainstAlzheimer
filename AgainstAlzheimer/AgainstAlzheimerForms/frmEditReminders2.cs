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
    public partial class frmEditReminders2 : Form
    {
        Reminders ObjEditReminders = new Reminders();
        public frmEditReminders2()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ObjEditReminders.Family1 = txtFamily1.Text;
            ObjEditReminders.Family2 = txtFamily2.Text;
            ObjEditReminders.Family3 = txtFamily3.Text;
            ObjEditReminders.Family4 = txtFamily4.Text;
            ObjEditReminders.Family5 = txtFamily5.Text;
            ObjEditReminders.Family6 = txtFamily6.Text;
            ObjEditReminders.Family7 = txtFamily7.Text;
            ObjEditReminders.Family8 = txtFamily8.Text;

            SaveXML.SaveData(ObjEditReminders, "Reminders_Pg2.xml");

            MessageBox.Show("Información guardada correctamente", "Mensaje de control", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmEditReminders1 ObjEditReminders = new frmEditReminders1();
            ObjEditReminders.Show();
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmEditReminders3 ObjEditReminders = new frmEditReminders3();
            ObjEditReminders.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmAdminSesion ObjAdminSesion = new frmAdminSesion();
            ObjAdminSesion.Show();
            Close();
        }

        private void frmEditReminders2_Load(object sender, EventArgs e)
        {
            if (File.Exists("Reminders_Pg2.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Reminders));
                FileStream read = new FileStream("Reminders_Pg2.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Reminders info = (Reminders)xs.Deserialize(read);

                txtFamily1.Text = info.Family1;
                txtFamily2.Text = info.Family2;
                txtFamily3.Text = info.Family3;
                txtFamily4.Text = info.Family4;
                txtFamily5.Text = info.Family5;
                txtFamily6.Text = info.Family6;
                txtFamily7.Text = info.Family7;
                txtFamily8.Text = info.Family8;

                read.Close();
            }
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family1.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family1.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family1.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily1.jpg");
                picFamily1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family2.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family2.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family2.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily2.jpg");
                picFamily2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family3.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family3.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family3.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily3.jpg");
                picFamily3.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family4.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family4.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family4.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily4.jpg");
                picFamily4.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family5.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family5.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family5.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily5.jpg");
                picFamily5.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family6.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family6.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family6.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily6.jpg");
                picFamily6.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family7.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family7.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family7.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily7.jpg");
                picFamily7.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnOpenFile8_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists("./Resources/Photos/Family8.jpg"))
                {
                    System.IO.File.Delete("./Resources/Photos/Family8.jpg");
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/Photos/Family8.jpg");
                }
                else
                    System.IO.File.Copy(openFileDialog1.FileName, "./Resources/PhotosFamily8.jpg");
                picFamily8.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
