using DAL;
using Models;

namespace CaviForm
{
    public partial class frmUsuario : Form
    {
        private List<Rol> roles = new List<Rol>();
        public frmUsuario ( )
        {
            InitializeComponent();
        }

        private void frmUsuario_Load (object sender, EventArgs e)
        {


            roles = DALRol.TodosLosRegistros("ListarTodosRol");


            cboRol.DataSource = null;
            cboRol.DataSource = roles;
            cboRol.ValueMember = "RolId";
            cboRol.DisplayMember = "Descripcion";

        }

        private void btnCerrar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Enter (object sender, EventArgs e)
        {

        }

        private void btnEditar_Enter (object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Enter (object sender, EventArgs e)
        {

        }

        private void btnDeshacer_Enter (object sender, EventArgs e)
        {

        }

        private void btnCerrar_Enter (object sender, EventArgs e)
        {

        }

        private void btnNuevo_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnNuevo, "Nuevo usuario");
        }

        private void btnCerrar_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnCerrar, "Cerrar");
        }

        private void btnDeshacer_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnDeshacer, "Deshacer usuario");
        }

        private void btnGuardar_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnGuardar, "Guardar usuario");
        }

        private void btnEditar_MouseEnter (object sender, EventArgs e)
        {
            toolTipUsuario.SetToolTip(btnEditar, "Editar usuario");
        }
    }
}
