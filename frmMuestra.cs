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

        string[] vecContacto = new string[5];
        int indice;

        private void lblContacto_Click(object sender, EventArgs e)
        {
            vecContacto[0] = "Lucas";
            vecContacto[1] = "Mati";
            vecContacto[2] = "Pablo";
            vecContacto[3] = "Valen";
            vecContacto[4] = "Benja";

            lblContacto.Text = "";
            indice = -1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (indice == -1)
            {
                lblContacto.Text = "";
                btnAtras.Enabled = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(vecContacto.Length==indice-1)
            {
                indice++;
                if (vecContacto.Length == indice - 1)
                {
                    btnSiguiente.Enabled = false;
                }
            }
        }
    }
}
