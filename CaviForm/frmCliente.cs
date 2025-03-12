using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaviForm
{
    public partial class frmCliente : Form
    {
        public frmCliente ( )
        {
            InitializeComponent();
        }

        private void frmCliente_Load (object sender, EventArgs e)
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
    }
}
