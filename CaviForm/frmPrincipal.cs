using System.Drawing.Text;

namespace CaviForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal ( )
        {
            InitializeComponent();
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
        }
    }
}
