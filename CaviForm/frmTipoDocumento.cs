namespace CaviForm
{
    public partial class frmTipoDocumento : Form
    {
        private Models.TipoDocumento tipo;

        public frmTipoDocumento ( )
        {
            InitializeComponent();

            tipo = new Models.TipoDocumento();
        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click (object sender, EventArgs e)
        {
            if (txtDescripcion.TextLength < 3 || txtDescripcion.Text == "")
            {
                MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres y un máximo de 50");
                txtDescripcion.Focus();
                //tipo.Descripcion = txtDescripcion.Text;

            }
            else
            {
                tipo.Descripcion = txtDescripcion.Text;
                
                DAL.TipoDocumento.Agregar(tipo.Descripcion.ToString(), "InsertTipo_Documento");

            }
        }

        private void frmTipoDocumento_Load (object sender, EventArgs e)
        {
           

        }
    }
}
