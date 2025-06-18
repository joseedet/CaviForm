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
        public bool Edicion { get; set; }
        public int TipoDocumentoId { get; set; }

        private TipoDocumento tipo = new();
        private ErrorProvider errorProvider = new();
        private ToolTip toolTip = new();
        private static string miTipo;

        public frmTipoDocumento ( )
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
            if (Edicion)
            {
                tipo = DALTipoDocumento.PorId(TipoDocumentoId, "ListarTipoDocumentoPorId");
                txtDescripcion.Text = tipo.Descripcion;
                checkBoxActivo.Checked = tipo.Activo;
            }
            else
            {
                txtDescripcion.Clear();
                checkBoxActivo.Checked = true;
            }

        }
        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click (object sender, EventArgs e)
        {
            try
            {
                if (!Edicion)
                {

                    tipo.Descripcion = txtDescripcion.Text.ToUpper();
                    miTipo = tipo.Descripcion.ToUpper();
                    var func = Validator.Validate(tipo, Validaciones.ValidaTipoDocumento.validations) ?
                    (Action)Success :
                    (Action)Error;

                    func();
                    ColocarLimpiar();

                }
                else
                {
                    tipo.Descripcion = txtDescripcion.Text.ToUpper();
                    miTipo = tipo.Descripcion.ToUpper();
                    /*var func = Validator.Validate(tipo, Validaciones.ValidaTipoDocumento.validations) ?
                    (Action)Success :
                    (Action)Error;
                    func();*/
                    Guardar();
                 }
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK);


            }
        }
        private static void Success ( )
        {
            DALTipoDocumento.Agregar(miTipo, "AgregarTipoDocumento");
            MessageBox.Show("Se ha registrado correctamente el tipo de documento", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private static void Error ( ) => MessageBox.Show("El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters", Application.ProductName);


        private void frmTipoDocumento_Load (object sender, EventArgs e)
        {

            txtDescripcion.Focus();
        }

        private void txtDescripcion_Validating (object sender, System.ComponentModel.CancelEventArgs e)
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

        private void txtDescripcion_Validated (object sender, EventArgs e)
        {
            errorProvider.SetError(txtDescripcion, "");
        }

        private void ColocarLimpiar ( )
        {

            txtDescripcion.Focus();
            txtDescripcion.Clear();

        }
        private void Guardar ( )
        {
            try
            {
                DALTipoDocumento.Actualizar(TipoDocumentoId, miTipo, "ActualizarTipoDocumento");
                MessageBox.Show("El tipo de documento se ha actualizado correctamente ", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

