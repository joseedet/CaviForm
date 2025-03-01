using DAL;
using Microsoft.Data.SqlClient;

namespace CaviForm
{
    public partial class frmTipoDocumento : Form
    {
        private Models.TipoDocumento tipo;
        private ErrorProvider errorProvider;

        public frmTipoDocumento ( )
        {
            InitializeComponent();

            tipo = new Models.TipoDocumento();
            errorProvider = new ErrorProvider();
        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click (object sender, EventArgs e)
        {
            try
            {

                if (txtDescripcion.TextLength < 3 || txtDescripcion.Text == "" || txtDescripcion.Text == null)
                {
                    errorProvider.SetError(btnAceptar, "El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters");
                    //MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres, un máximo de 50");
                    txtDescripcion.Focus();
                    errorProvider.Clear();

                }
                else
                {
                    tipo.Descripcion = txtDescripcion.Text.ToUpper();


                    DALTipoDocumento.Agregar(tipo.Descripcion.ToString().ToUpper(), "InsertTipo_Documento");

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("El valor que intenta introducir ya figura en la base de datos", Application.ProductName, MessageBoxButtons.OK);


            }


        }

        private void frmTipoDocumento_Load (object sender, EventArgs e)
        {


        }
    }
}
