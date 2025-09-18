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

        int indice;

        private void frmMuestra_Load(object sender, EventArgs e)
        {
            indice = 0;
            lblContacto.Text = frmPrincipal.vecContactos[indice];
            lblNumero.Text = "Primer contacto";
        }

        private void lblContacto_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            indice--;
            lblContacto.Text = frmPrincipal.vecContactos[indice];

            if (frmPrincipal.vecContactos[indice] == null)
            {
                lblContacto.Text = "No hay contacto guardado";
            }
                
            switch (indice)
            {
                case 0:
                    lblNumero.Text = "Primer contacto";
                    break;

                case 1:
                    lblNumero.Text = "Segundo contacto";
                    break;

                case 2:
                    lblNumero.Text = "Tercer contacto";
                    break;

                case 3:
                    lblNumero.Text = "Cuarto contacto";
                    break;

                case 4:
                    lblNumero.Text = "Quinto contacto";
                    break;
            }

            if (indice != 0)
            {
                btnAtras.Enabled = true;
            }
            if (indice == 0)
            {
                btnAtras.Enabled = false;
            }

            if (indice+1 == frmPrincipal.vecContactos.Length)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        { 
            indice++;
            lblContacto.Text = frmPrincipal.vecContactos[indice];

            if (frmPrincipal.vecContactos[indice] == null)
            {
                lblContacto.Text = "No hay contacto guardado";
            }

            switch (indice)
            {
                case 0:
                    lblNumero.Text = "Primer contacto";
                    break;

                case 1:
                    lblNumero.Text = "Segundo contacto";
                    break;

                case 2:
                    lblNumero.Text = "Tercer contacto";
                    break;

                case 3:
                    lblNumero.Text = "Cuarto contacto";
                    break;

                case 4:
                    lblNumero.Text = "Quinto contacto";
                    break;
            }

            if (indice != 0)
            {
                btnAtras.Enabled = true;
            }
            if (indice == 0)
            {
                btnAtras.Enabled = false;
            }

            if (indice + 1 == frmPrincipal.vecContactos.Length)
            {
                btnSiguiente.Enabled = false;
            }
            else
            {
                btnSiguiente.Enabled = true;
            }
        }
    }
}
