using System.Windows.Forms;
using EjemploLogin;
using MaterialSkin;
using MaterialSkin.Controls;
using Validaciones;
using Models;

namespace CaviForm
{

    public partial class frmCliente : MaterialForm
    {
        private ToolTip toolTip1;
        private ErrorProvider errorProvider1=new();
        private Cliente cliente;
        public frmCliente ( )
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
            toolTip1 = new ToolTip();
            toolTip1.IsBalloon = true;


        }

        private void frmCliente_Load (object sender, EventArgs e)
        {
            HablitacionBotonesCarga();
        }
        /// <summary>
        /// Habilitamos los botones guardar y cerrar
        /// </summary>
        private void HablitacionBotonesCarga ( )
        {
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnDeshacer.Enabled = false;
            btnCerrar.Enabled = true;
            btnNuevo.Enabled = false;


        }

        private void btnNuevo_MouseMove (object sender, MouseEventArgs e)
        {
            
        }

        private void btnNuevo_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnNuevo, "Nuevo");
        }

        private void btnEditar_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEditar, "Editar");
        }

        private void btnGuardar_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGuardar, "Guardar");
        }

        private void btnDeshacer_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnDeshacer, "Deshacer");
        }

        private void btnEliminar_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEliminar, "Eliminar");
        }

        private void btnCerrar_MouseEnter (object sender, EventArgs e) => toolTip1.SetToolTip(btnCerrar, "Cerrar");


        private void btnCerrar_Click (object sender, EventArgs e) =>
            Close();

        private void lblDocumento_Click (object sender, EventArgs e)
        {

        }

        private void txtDocumento_Validating (object sender, System.ComponentModel.CancelEventArgs e)
        {
            int tipo = Convert.ToInt32(cboTipoDocumento.SelectedValue);

            if (!ValidaDNINIE.CheckDniNifCif(tipo, txtDocumento.Text))
            {
                e.Cancel = true; txtDocumento.Select();
                errorProvider1.SetError(txtDocumento, "Los datos introducidos son incorrectos, por reviselos.");
            }
            else{
                
            }

        }

        private void frmCliente_Validating (object sender, System.ComponentModel.CancelEventArgs e)
        {
            errorProvider1.SetError(txtDocumento, "");
        }
    }
}
