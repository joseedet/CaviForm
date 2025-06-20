using DAL;
using EjemploLogin;
using MaterialSkin.Controls;
using Microsoft.Data.SqlClient;

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
            try
            {
                if (DALUsuario.ValidarUsuario(txtUsuario.Text, txtContrasenya.Text, "ValidaUsuario") == 1)
                {

                    MessageBox.Show("Se ha registrado correctamente en el sistema", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var _grupoUsuario = DALObtenerGrupo.ObtenerGrupo(txtUsuario.Text, "ObtenerGrupo");

                    frmPrincipal frm = new();
                    frm.Panel(true, _grupoUsuario);
                    Close();
                    Resultado = true;

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenya.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtContrasenya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita el sonido del beep al presionar Enter
                btnAceptar.PerformClick(); // Simula el clic en el botón Aceptar
            }
        }
    }
}

