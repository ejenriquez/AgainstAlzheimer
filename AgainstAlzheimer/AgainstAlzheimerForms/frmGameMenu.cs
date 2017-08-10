using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgainstAlzheimerForms
{
    public partial class frmGameMenu : Form
    {
        public frmGameMenu()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmUserSesion ObjUserSesion = new frmUserSesion();
            ObjUserSesion.Show();
            Close();
        }

        private void btnMemorama_Click(object sender, EventArgs e)
        {
            frmMemorama ObjMemorama = new frmMemorama();
            ObjMemorama.Show();
            Close();
        }

        
        private void btnJigsawPuzzle_Click(object sender, EventArgs e)
        {
            frmJigsawPuzzle ObjJigsawPuzzle = new frmJigsawPuzzle();
            ObjJigsawPuzzle.Show();
            Close();
        }

        private void btnLaberynth_Click(object sender, EventArgs e)
        {
            frmLaberynth ObjLaberynth = new frmLaberynth();
            ObjLaberynth.Show();
            Close();
        }
    }
}
