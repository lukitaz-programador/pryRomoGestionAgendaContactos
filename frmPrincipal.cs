namespace pryRomoGestionAgendaContactos;
public partial class frmPrincipal : Form
{
    public frmPrincipal()
    {
        InitializeComponent();
    }

    string vTelefono;
    string vNombre;
    int vContador=0;

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        txtContacto.Text = "";
        mtbNumero.Text = "";
    }

    private void txtContacto_TextChanged(object sender, EventArgs e)
    {
        if (txtContacto.Text == "")
        {
            mtbNumero.Enabled = true;
        }
        else
        {
            mtbNumero.Enabled = false;
        }
    }

    private void mtbNumero_KeyDown(object sender, KeyEventArgs e)
    {
        if (mtbNumero.MaskFull)
        {
            btnRegistrar.Enabled = false;
        }
        else
        {
            btnRegistrar.Enabled = true;
        }
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        vNombre = txtContacto.Text;
        vTelefono = mtbNumero.Text;
        lsbRegistros.Items.Add("Contacto: " + vNombre + " Teléfono: " + vTelefono);
        vContador = vContador + 1;
        lblContador.Text =Convert.ToString(vContador);
        txtContacto.Text = "";
        mtbNumero.Text = "";
    }
}
