using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CaviForm
{
    public partial class frmAlmacen : Form
    {
        private ErrorProvider errorProvider;
        private Models.Almacen almacen;

        public frmAlmacen ( )
        {
            InitializeComponent();
            almacen = new Models.Almacen();
            errorProvider = new ErrorProvider();

        }

        private void btnAceptar_Click (object sender, EventArgs e)
        {
            try
            {

                if (txtDescripcion.TextLength < 3 || txtDescripcion.Text == "" || txtDescripcion.Text == null)
                {
                    errorProvider.SetError(btnAceptar, "El tipo documento tiene que tener un minímo de 3 y un máximo de 50 carácters");
                    //MessageBox.Show("El tipo documento tiene que tener un minímo de 3 carácteres, un máximo de 50");
                    txtDescripcion.Focus();
                    errorProvider.Clear();

                }
                else
                {
                    almacen.Descripcion = txtDescripcion.Text.ToUpper();


                    DAL.Almacen.Agregar(almacen.Descripcion.ToString().ToUpper(), "InsertTipo_Documento");

                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("El valor que intenta introducir ya figura en la base de datos", Application.ProductName, MessageBoxButtons.OK);

            }

        }

        private void btnCancelar_Click (object sender, EventArgs e)
        {
            Close();
        }
    }
}
