using DAL;

namespace CaviForm
{
    public partial class frmLogin : Form
    {
        ErrorProvider errorProvider;
        public frmLogin ( )
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click (object sender, EventArgs e)
        {
            /*if (txtUsuario.Text == "" || txtContrasenya.Text == "")
            {
                MessageBox.Show("Usuario o contraseña incorrectas");

            }*/
            if (DALUsuario.ValidarUsuario(txtUsuario.Text,txtContrasenya.Text,"ValidarUsuariario")==1)
            {
                
             // ejecutar otro procedimiento almacenado paras saber el rol al que pertenece el usuario.


            }

        }

        private void txtUsuario_Validating (object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            if (ValidarUsuario(txtUsuario.Text))
            {
                e.Cancel = false;
            }
            else
            {
                errorProvider.SetError(txtUsuario, "Introduzca un usuario con más de 3 carácteres.");

            }

        }
        private bool ValidarUsuario (string usuario)
        {
            if (usuario == "" || usuario.Length < 3)
            {

                return false;
            }
            else
            {

                return true;
            }

        }

        private void txtUsuario_Validated (object sender, EventArgs e)
        {
            errorProvider.SetError(txtUsuario, "");
        }
    }
}

