using DAL;
using EjemploLogin;
using MaterialSkin.Controls;

namespace CaviForm
{
   
    public partial class frmLogin : MaterialForm
    {
        private bool Resultado = false;
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
            //this.Close();
            Application.Exit();
            Resultado = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            if (DALUsuario.ValidarUsuario(txtUsuario.Text, txtContrasenya.Text, "ValidaUsuario") == 1)
            {

                MessageBox.Show("Se ha registrado correctamente en el sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmPrincipal frm = new();
                frm.Panel(true);
                Close();
                Resultado = true;


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
            toolTip.SetToolTip(btnCancelar, "Salir de la aplicación");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void txtUsuario_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txtUsuario, "Introducir nombre de usuario");
        }

        private void txtContrasenya_MouseEnter(object sender, EventArgs e)
        {
            toolTip.SetToolTip(txtContrasenya, "Introducir contraseña");
        }
        public bool Result()
        {

            return Resultado;

        }
    }
}

