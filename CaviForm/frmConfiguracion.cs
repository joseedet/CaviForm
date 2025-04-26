using EjemploLogin;
using MaterialSkin.Controls;

namespace CaviForm
{
    public partial class frmConfiguracion : MaterialForm
    {
        ToolTip toolTip1 = new ToolTip();
        public frmConfiguracion ( )
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);

            toolTip1.IsBalloon = true;
        }

        private void btnAlmacen_Click (object sender, EventArgs e)
        {
            frmAlmacen frm = new();
            frm.ShowDialog(this);
        }

        private void btnCerrar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlmacen_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAlmacen, "Gestión de lo distintos almacenes");
        }

        private void btnConcepto_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnConcepto, "Gestión de concepto");
        }

        private void btnIva_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnIva, "Gestión de los distintos tipos de IVA");
        }

        private void btnCambiarUsuario_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnCambiarUsuario, "Cambio de usuario");
        }

        private void btnCambioContrasenya_MousEnter (object sender, EventArgs e)
        {

            toolTip1.SetToolTip(btnCambioContrasenya, "Cambio de contraeña");


        }

        private void frmConfiguracion_Load (object sender, EventArgs e)
        {

        }

        private void btnTipoDocumento_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnTipoDocumento, "Alta de los difentes tipos de documentos");
        }

        private void btnTipoDocumento_Click (object sender, EventArgs e)
        {
            frmListaTipoDocumento frm = new();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
