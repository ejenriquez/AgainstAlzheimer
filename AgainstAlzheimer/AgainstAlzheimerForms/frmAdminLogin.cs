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
    public partial class frmAdminLogin : Form
    {
        Admin ObjAdmin = new Admin();
        string TempPass;

        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists("AdminInfo.xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Admin));
                FileStream read = new FileStream("AdminInfo.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Admin info = (Admin)xs.Deserialize(read);
                ObjAdmin.Password = info.Password;
                read.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmStart ObjectStart = new frmStart();
            ObjectStart.Show();
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmAdminSesion ObjAdminSesion = new frmAdminSesion();
            TempPass = txtPassword.Text;
            if(TempPass==ObjAdmin.Password)
            {
                MessageBox.Show("Acceso concedido", "Acceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ObjAdmin.Password = TempPass;

                SaveXML.SaveData(ObjAdmin, "AdminInfo.xml");
                
                ObjAdminSesion.Show();
                Close();
            }
            else
            {
                MessageBox.Show("La contraseña es incorrecta, intente de nuevo", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Text = "";
                txtPassword.Focus();
            }

            
            //bool confirm;
            //confirm = ObjAdmin.ReadData(txtPassword);
            //if (confirm == true)
            //{
            //    MessageBox.Show("Acceso concedido", "Acceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    ObjAdminSesion.Show();
            //    Close();
            //}
            //else
            //{
            //    MessageBox.Show("La contraseña es incorrecta, intente de nuevo", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtPassword.Text = "";
            //    txtPassword.Focus();
            //}
        }
    }
}
