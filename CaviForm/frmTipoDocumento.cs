using DAL;
using Microsoft.Data.SqlClient;
using MaterialSkin.Controls;
using EjemploLogin;
using Models;
using static Validaciones.IValidacion<Models.TipoDocumento>;

namespace CaviForm
{
    public partial class frmTipoDocumento : MaterialForm
    {
        private TipoDocumento tipo;
        private ErrorProvider errorProvider;
        private static string miTipo;

        public frmTipoDocumento()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);

            TipoDocumento tipo = new TipoDocumento();
            errorProvider = new ErrorProvider();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                tipo.Descripcion = txtDescripcion.Text.ToUpper();
                miTipo = tipo.Descripcion.ToUpper();
                var func = Validator.Validate(tipo, Validaciones.ValidaTipoDocumento.validations) ?
                (Action)Success :
                (Action)Error;

                func();

                ColocarLimpiar();               

                       }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK);


            }


        }
        private static void Success()
        {
            try
            {
                DALTipoDocumento.Agregar(miTipo, "InsertTipoDocumento");
                MessageBox.Show("El registro ha sido guardado con éxito", Application.ProductName, MessageBoxButtons.OK,MessageBoxIcon.Information);
                
               

            }
            catch(SqlException ex)
            {

                MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }    

      
        public static void Error() => MessageBox.Show("El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters", Application.ProductName);
     

        private void frmTipoDocumento_Load(object sender, EventArgs e)
        {

            txtDescripcion.Focus();
        }

        private void txtDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDescripcion.TextLength <= 2 || txtDescripcion.Text == "" || txtDescripcion.Text == null)
            {
               
                //MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres, un máximo de 50");
                e.Cancel = true;
                errorProvider.SetError(txtDescripcion, "El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters");
            }
            else
            {
                miTipo = txtDescripcion.Text.ToUpper();


            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDescripcion, "");
        }

        private void ColocarLimpiar()
        {

            txtDescripcion.Focus();
            txtDescripcion.Clear();

        }
    }
}
