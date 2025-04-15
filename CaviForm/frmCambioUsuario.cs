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
    public partial class frmCambioUsuario : MaterialForm
    {
        ToolTip toolTip1 = new();
        public frmCambioUsuario ( )
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
            toolTip1.IsBalloon = true;
        }

        private void lblContrasenya_Click (object sender, EventArgs e)
        {

        }

        private void btnGuardar_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnGuardar, "Guardar cambio de contraseña");
        }

        private void btnCerrar_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnCerrar, "Cerrar formulario");
        }

        private void txtContrasenya_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtContrasenya, "Introducir contraseña");
        }

        private void txtRepetirContrasenya_MouseEnter (object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtContrasenya, "Repetir contraseña");
        }

        private void frmCambioUsuario_Load (object sender, EventArgs e)
        {
           radioButtonCambioContraseña.Checked = true;
        }
    }
}
