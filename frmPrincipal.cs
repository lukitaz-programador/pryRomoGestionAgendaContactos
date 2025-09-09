namespace pryRomoGestionAgendaContactos;
public partial class frmPrincipal : Form
{
    public frmPrincipal()
    {
        InitializeComponent();
    }

    //Declaración de las variables globales
    string[] vecTelefono = new string[5];
    string[] vecContacto = new string[5];
    int indice;
    int vContador = 0;

    //Campos
    private void txtContacto_TextChanged(object sender, EventArgs e)
    {
        if (txtContacto.Text == "")
        {
            mtbNumero.Enabled = false;
        }
        else
        {
            mtbNumero.Enabled = true;
        }
    }

    private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
    {

    }
    private void mtbNumero_TextChanged(object sender, EventArgs e)
    {
        if (mtbNumero.MaskFull == true)
        {
            btnRegistrar.Enabled = true;
        }
        else
        {
            btnRegistrar.Enabled = false;
        }
    }

    //Botones
    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        vecContacto[indice] = txtContacto.Text;
        vecTelefono[indice] = mtbNumero.Text;
        lsbRegistros.Items.Add("Contacto: " + vecContacto[indice] + " Teléfono: " + vecTelefono[indice]);
        vContador = vContador + 1;
        lblContador.Text = Convert.ToString(vContador);
        txtContacto.Text = "";
        mtbNumero.Text = "";
        indice = indice + 1;
        txtContacto.Focus();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        txtContacto.Text = "";
        mtbNumero.Text = "";
    }

    private void lsbRegistros_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
