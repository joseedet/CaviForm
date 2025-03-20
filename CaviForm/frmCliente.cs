namespace CaviForm
{

    public partial class frmCliente : Form
    {
        private ToolTip toolTip1;
        public frmCliente()
        {
            InitializeComponent();
            toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            HablitacionBotonesCarga();
        }
        /// <summary>
        /// Habilitamos los botones guardar y cerrar
        /// </summary>
        private void HablitacionBotonesCarga()
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnDeshacer.Enabled = false;
            btnCerrar.Enabled = true;
            btnNuevo.Enabled = false;


        }

        private void btnNuevo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnNuevo_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnNuevo, "Nuevo");
        }

        private void btnEditar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEditar, "Editar");
        }

        private void btnGuardar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnDeshacer_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDeshacer, "Deshacer");
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEliminar, "Eliminar");
        }

        private void btnCerrar_MouseEnter(object sender, EventArgs e) => toolTip1.SetToolTip(btnCerrar, "Cerrar");


        private void btnCerrar_Click(object sender, EventArgs e) =>
            Close();

        private void lblDocumento_Click(object sender, EventArgs e)
        {

        }
    }
}
