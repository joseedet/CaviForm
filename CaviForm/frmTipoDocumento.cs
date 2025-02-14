using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace CaviForm
{
    public partial class frmTipoDocumento : Form
    {
        private TipoDocumento tipo;

        public frmTipoDocumento ( )
        {
            InitializeComponent();

            tipo = new TipoDocumento();
        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click (object sender, EventArgs e)
        {
            if (txtDescripcion.TextLength < 3 || txtDescripcion.Text == "")
            {
                MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres y un máximo de 50");

            }
            else
            {
                tipo.Descripcion = txtDescripcion.Text;

            }
        }

        private void frmTipoDocumento_Load (object sender, EventArgs e)
        {
           

        }
    }
}
