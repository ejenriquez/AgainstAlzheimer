using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AgainstAlzheimerLibrary
{
    public class Admin
    {
        private String mPassword;
        private String mPassword1;
        private bool confirm;

        public string Password
        {
            get
            { return mPassword; }
            set
            { mPassword = value; }
        }

        /*public Admin()
        {
            Password = "1234";
        }

        public Admin(String Password)
        {
            mPassword = Password;
        }*/

        public bool ReadData(TextBox txtPassword)
        {
            try
            {
                mPassword1 = txtPassword.Text;
            }
            catch
            {
                MessageBox.Show("Ingrese un valor válido...", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            confirm = Login(txtPassword);
            return confirm;
        }

        public bool Login(TextBox txtPassword)
        {
            if (txtPassword.Text == mPassword)
                return true;
            else
                return false;
        }

        public bool ReadDataToChange(TextBox txtPassword, TextBox txtPasswordR)
        {
            string mPasswordR;
            try
            {
                mPassword1 = txtPassword.Text;
                mPasswordR = txtPasswordR.Text;
            }
            catch
            {
                MessageBox.Show("Ingrese un valor válido...", "Mensaje De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            confirm = ChangePassword(txtPassword, txtPasswordR);
            return confirm;
        }

        public bool ChangePassword(TextBox txtPassword, TextBox txtPasswordR)
        {
            if (txtPassword.Text == txtPasswordR.Text)
            {
                mPassword = txtPasswordR.Text;
                return true;
            }
            else
                return false;
        }
    }
}
