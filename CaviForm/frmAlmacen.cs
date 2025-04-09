using DAL;
using Microsoft.Data.SqlClient;
using Models;
using static Validaciones.IValidacion<Models.Almacen>;
using MaterialSkin.Controls;
using EjemploLogin;

namespace CaviForm
{
    public partial class frmAlmacen : MaterialForm
    {
        private ErrorProvider errorProvider;
        private Almacen almacen;
        private static string? miAlmacen;
        private ToolTip toolTip;
        private static bool miError;

        public frmAlmacen()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
            almacen = new Almacen();
            errorProvider = new ErrorProvider();
            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            miError = false;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                miAlmacen = almacen.Descripcion;
                var func = Validator.Validate(almacen, Validaciones.ValidarAlmacen.validations) ?
                (Action)Success :
                (Action)Error;

                func();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK);

            }

        }
        public static void Success()
        {
            Ejecutar();
        }

        public static void Error()
        {
            MessageBox.Show("La descripción no puede estar vacia y tiene que tener 3 carácteres como mínimo.",
                Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private static void Ejecutar() => DALAlmacen.Agregar(miAlmacen.ToUpper(), "InsertTipo_Documento");


        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAceptar, "Guardar");
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Salir");
        }

        private void txtDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDescripcion.TextLength < 3 || txtDescripcion.Text == "" || txtDescripcion.Text == null)
            {
                e.Cancel = true;
                errorProvider.SetError(txtDescripcion, "El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters");
                //MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres, un máximo de 50");
                //txtDescripcion.Focus();

            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDescripcion, "");
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            Foco();
        }

        private void frmAlmacen_Activated(object sender, EventArgs e)
        {
            Foco();
        }
        private void Foco()
        {
            txtDescripcion.Focus();

        }

        private void lblPoblacion_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnNuevo, "Nuevo registro");
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnModificar, "Modificar registro");

        }

        private void btnDeshacer_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnDeshacer, "Deshacer registro");
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEliminar, "Eliminar registro");
        }

        private void txtDireccion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDireccion.TextLength > 150 || txtDireccion == null || txtDireccion.Text == "")
            {
                e.Cancel = true;
                txtDireccion.Select();
                errorProvider.SetError(txtDireccion, "La direción no puede tener más de 150 carácteres y es obligatiora.");

            }
        }

        private void txtDireccion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDireccion, "");
        }

        private void txtCodPostal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCodPostal.TextLength > 5 || txtCodPostal == null || txtCodPostal.Text == "" || txtCodPostal.TextLength < 5)
            {
                e.Cancel = true;
                txtCodPostal.Select();
                errorProvider.SetError(txtCodPostal, "El código postal es obligatorio y debe tener 5 carácteres.");

            }
        }

        private void txtCodPostal_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCodPostal, "");
        }

        private void txtPoblacion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtPoblacion.TextLength > 75 || txtPoblacion == null || txtPoblacion.Text == "" || txtPoblacion.TextLength < 3)
            {
                e.Cancel = true;
                txtPoblacion.Select();
                errorProvider.SetError(txtPoblacion, "La población es obligatorio y debe tener más de 3 carácteres.");

            }
        }

        private void txtPoblacion_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPoblacion, "");
        }

        private void txtProvin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtProvin.TextLength > 50 || txtProvin == null || txtProvin.Text == "" || txtProvin.TextLength < 3)
            {
                e.Cancel = true;
                txtProvin.Select();
                errorProvider.SetError(txtProvin, "La provincia es obligatoria, y debe de tenr mas 3 ,y menos de 75 carácteres.");

            }
        }

        private void txtProvin_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtProvin, "");
        }

        private void txtTelefono_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTelefono.TextLength >= 10 || txtTelefono == null || txtTelefono.Text == "" || txtTelefono.TextLength < 9)
            {
                e.Cancel = true;
                txtTelefono.Select();
                errorProvider.SetError(txtTelefono, "La provincia es obligatoria, y debe de tenr mas 3 ,y menos de 75 carácteres.");

            }
        }

        private void txtTelefono_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTelefono, "");
        }
    }
}
