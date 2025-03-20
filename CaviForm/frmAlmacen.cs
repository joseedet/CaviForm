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
                errorProvider.SetError(btnAceptar, "El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters");
                //MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres, un máximo de 50");
                txtDescripcion.Focus();

            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
        }

        private void frmAlmacen_Activated(object sender, EventArgs e)
        {
            txtDescripcion.Focus();
        }
    }
}
