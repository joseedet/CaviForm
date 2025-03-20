using DAL;
using Microsoft.Data.SqlClient;
using Models;
using static Validaciones.IValidacion<Models.Almacen>;


namespace CaviForm
{
    public partial class frmAlmacen : Form
    {
        private ErrorProvider errorProvider;
        private Almacen almacen;
        private static string? miAlmacen;

        public frmAlmacen()
        {
            InitializeComponent();
            almacen = new Almacen();
            errorProvider = new ErrorProvider();

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

                MessageBox.Show("El valor que intenta introducir ya figura en la base de datos", Application.ProductName, MessageBoxButtons.OK);

            }

        }
        public static void Success()
        {
            Ejecutar();
        }

        public static void Error() => MessageBox.Show("La descripción no puede estar vacia y tiene que tener 3 carácteres como mínimo.","Gavi Form [Almacén]",MessageBoxButtons.OK,MessageBoxIcon.Error);


        private void btnCancelar_Click(object sender, EventArgs e) => Close();

        private static void Ejecutar() => DALAlmacen.Agregar(miAlmacen.ToUpper(), "InsertTipo_Documento");

        private void txtDescripcion_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*miAlmacen = almacen.Descripcion;
            var func = Validator.Validate(almacen, Validaciones.ValidarAlmacen.validations) ?
            (Action)Success :
            (Action)Error; 

            func();**/
            if (txtDescripcion.TextLength < 3 || txtDescripcion.Text == "" || txtDescripcion.Text == null)
               {
                   errorProvider.SetError(btnAceptar, "El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters");
                   //MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres, un máximo de 50");
                   txtDescripcion.Focus();
                   errorProvider.Clear();

               }
               //else
               //{
               //    almacen.Descripcion = txtDescripcion.Text.ToUpper();


               //    DALAlmacen.Agregar(almacen.Descripcion.ToString().ToUpper(), "InsertTipo_Documento");


               //}

        }
    }
}
