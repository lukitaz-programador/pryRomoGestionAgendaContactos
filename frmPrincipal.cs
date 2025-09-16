namespace pryRomoGestionAgendaContactos;
public partial class frmPrincipal : Form
{
    public static string[] vecExportado=new string[5];

    public frmPrincipal()
    {
        InitializeComponent();
    }

    //Definción de variables globales
    string[] vecTelefono = new string[5];
    string[] vecContacto = new string[5];
    int vContador = 0;
    int indice;

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
        vContador++;
        lblContador.Text = Convert.ToString(vContador);
        txtContacto.Text = "";
        mtbNumero.Text = "";
        vecExportado[indice]=vecContacto[indice]+vecTelefono[indice];
        indice++;
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

    private void button1_Click(object sender, EventArgs e)
    {
        frmMuestra frmMuestra= new frmMuestra();
        Hide();
        frmMuestra.ShowDialog();
    }
}
