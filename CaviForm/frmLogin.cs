using DAL;
using EjemploLogin;
using MaterialSkin;
using MaterialSkin.Controls;

namespace CaviForm
{
    public partial class frmLogin : MaterialForm
    {
        ErrorProvider errorProvider;
        ToolTip toolTip;
        public frmLogin()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
            errorProvider = new ErrorProvider();
            toolTip = new ToolTip();
            toolTip.IsBalloon = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*if (txtUsuario.Text == "" || txtContrasenya.Text == "")
            {
                MessageBox.Show("Usuario o contraseña incorrectas");

            }*/
            if (DALUsuario.ValidarUsuario(txtUsuario.Text, txtContrasenya.Text, "ValidarUsuariario") == 1)
            {

                // ejecutar otro procedimiento almacenado paras saber el rol al que pertenece el usuario.


            }

        }

        private void txtUsuario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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
        private bool ValidarUsuario(string usuario)
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

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtUsuario, "");
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAceptar, "Aceptar");
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCancelar, "Cerrar");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}

