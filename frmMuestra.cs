using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRomoGestionAgendaContactos
{
    public partial class frmMuestra : Form
    {
        public frmMuestra()
        {
            InitializeComponent();
        }

        string[] vecContacto = new string[3];
        int indice;

        private void frmMuestra_Load(object sender, EventArgs e)
        {
            vecContacto[0] = "Lucas";
            vecContacto[1] = "Mati";
            vecContacto[2] = "Pablo";
            indice = 0;
            lblContacto.Text=vecContacto[indice];
        }

        private void lblContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            lblContacto.Text = vecContacto[indice];

            if (indice != 0)
            {
                btnAtras.Enabled = true;
            }
            else if (indice == 0)
            {
                btnAtras.Enabled = false;
            }
            else if (indice+1 == vecContacto.Length)
            {
                btnSiguiente.Enabled = false;
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        { 
            indice++;
            lblContacto.Text = vecContacto[indice];
            if (indice != 0)
            {
                btnAtras.Enabled = true;
            }
            else if (indice == 0)
            {
                btnAtras.Enabled = false;
            }
            else if (indice+1== vecContacto.Length)
            {
                btnSiguiente.Enabled = false;
            }
        }
    }
}
