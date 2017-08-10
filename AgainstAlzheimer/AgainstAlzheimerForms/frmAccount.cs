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
    public partial class frmAccount : Form
    {
        Admin ObjAdmin = new Admin();
        string TempPass;
        string TempPassR;
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            if (File.Exists("AdminInfo.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Admin));
                FileStream read = new FileStream("AdminInfo.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Admin info = (Admin)xs.Deserialize(read);
                read.Close();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            TempPass = txtPassword.Text;
            TempPassR = txtPasswordR.Text;

            if(TempPass==TempPassR)
            {
                MessageBox.Show("Contraseña cambiada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                ObjAdmin.Password = TempPass;
                SaveXML.SaveData(ObjAdmin, "AdminInfo.xml");

                txtPassword.Text = "";
                txtPasswordR.Text = "";
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, intente de nuevo", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtPasswordR.Text = "";
                txtPassword.Focus();
            }

            //bool confirm;
            //confirm = ObjAdmin.ReadDataToChange(txtPassword, txtPasswordR);
            //if (confirm == true)
            //{
            //    MessageBox.Show("Contraseña cambiada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtPassword.Text = "";
            //    ObjAdmin = new Admin(txtPassword.Text);
            //    txtPasswordR.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Las contraseñas no coinciden, intente de nuevo", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtPassword.Text = "";
            //    txtPasswordR.Text = "";
            //    txtPassword.Focus();
            //}
        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmAdminSesion ObjAdminSesion = new frmAdminSesion();
            ObjAdminSesion.Show();
            Close();
        }
    }
}
