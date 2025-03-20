
using EjemploLogin;
using MaterialSkin;
//using MaterialSkin.Controls;
using MaterialSkin.Controls;


namespace CaviForm
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal ( )
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        private void toolStripMenuItemSalir_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemTipoDocumento_Click (object sender, EventArgs e)
        {
            frmTipoDocumento frm;

            frm = new frmTipoDocumento();

            frm.MdiParent = this;

            frm.StartPosition = FormStartPosition.Manual;

            //Calculamos el centro del formulario padre

            frm.Location = new Point(
                (this.ClientSize.Width - frm.Width) / 2,
                (this.ClientSize.Height - frm.Height) / 2);


            frm.Show();

        }

        private void frmPrincipal_Load (object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.StartPosition = FormStartPosition.CenterScreen;
            CargaMenus(true);
            /*this.toolStripMenuItemBloquear.Visible = false;
            this.toolStripMenuItemCambiarUsuario.Visible = false;
            this.toolStripMenuItemClave.Visible = false;
            this.toolStripMenuItemDesBloquear.Visible = false;
            this.toolStripMenuItemDesconectar.Visible = false;
            this.MaestrosToolStripMenuItem.Visible = false;
            this.MovimientosToolStripMenuItem.Visible = false;
            this.ConsultasToolStripMenuItem.Visible = false;
            this.InformesToolStripMenuItem.Visible = false;
            this.AyudaToolStripMenuItem.Visible = false;*/


        }

        private void toolStripMenuItemAlmacen_Click (object sender, EventArgs e)
        {
            frmAlmacen frm;

            frm = new frmAlmacen();

            frm.MdiParent = this;

            frm.StartPosition = FormStartPosition.Manual;

            //Calculamos el centro del formulario padre

            frm.Location = new Point(
                (this.ClientSize.Width - frm.Width) / 2,
                (this.ClientSize.Height - frm.Height) / 2);


            frm.Show();
        }

        private void toolStripMenuItemConectar_Click (object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();

            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();
        }
        private void CargaMenus (bool visible)
        {

            this.toolStripMenuItemBloquear.Visible = visible;
            this.toolStripMenuItemCambiarUsuario.Visible = visible;
            this.toolStripMenuItemClave.Visible = visible;
            this.toolStripMenuItemDesBloquear.Visible = visible;
            this.toolStripMenuItemDesconectar.Visible = visible;
            this.MaestrosToolStripMenuItem.Visible = visible;
            this.MovimientosToolStripMenuItem.Visible = visible;
            this.ConsultasToolStripMenuItem.Visible = visible;
            this.InformesToolStripMenuItem.Visible = visible;
            this.AyudaToolStripMenuItem.Visible = visible;
        }

        private void toolStripMenuItemGestionUsuarios_Click (object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();

            frm.MdiParent = this;

            frm.StartPosition = FormStartPosition.Manual;

            //Calculamos el centro del formulario padre

            frm.Location = new Point(
                (this.ClientSize.Width - frm.Width) / 2,
                (this.ClientSize.Height - frm.Height) / 2);


            frm.Show();


        }

        private void toolStripMenuItemCliente_Click (object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();

            frm.MdiParent = this;

            frm.StartPosition = FormStartPosition.Manual;

            //Calculamos el centro del formulario padre

            frm.Location = new Point(
                (this.ClientSize.Width - frm.Width) / 2,
                (this.ClientSize.Height - frm.Height) / 2);


            frm.Show();
        }
    }
}
