using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploLogin;
using MaterialSkin.Controls;

namespace CaviForm
{
    public partial class frmListaClientes : MaterialForm
    {
        public frmListaClientes()
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            radioDNI.Checked = false;
            radioRazonSocial.Checked = false;
            radioCIF.Checked = false;
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            toolTipListaClientes.SetToolTip(btnBuscar, "Ejecutar búsqueda según el criterio seleccionado");
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            toolTipListaClientes.SetToolTip(btnCancelar, "Cerrar el formulario sin realizar ninguna acción");
        }
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void btnNuevoCliente_MouseEnter(object sender, EventArgs e)
        {
            toolTipListaClientes.SetToolTip(btnNuevoCliente, "Agregar un nuevo cliente");
        }
    }
}
 