using DAL;
using EjemploLogin;
using MaterialSkin.Controls;


namespace CaviForm
{
    public partial class frmListaTipoDocumento : MaterialForm
    {

        public frmListaTipoDocumento ( )
        {
            InitializeComponent();
            MaterialUI.loadMaterial(this);
        }

        private void ListaTipoDocumento_Load (object sender, EventArgs e)
        {
            dataGridViewTipoDocumentos.DataSource = DALTipoDocumento.TodosLosRegistros("ListarTodosTiposDocumento");
            dataGridViewTipoDocumentos.Columns[0].Visible = false;

        }

        private void dataGridViewTipoDocumentos_CellClick (object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTipoDocumentos_CellContentClick (object sender, DataGridViewCellEventArgs e)
        {
            // Se obtiene el id del tipo de documento seleccionado
            int id;
            if (dataGridViewTipoDocumentos.RowCount>0)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewTipoDocumentos.Rows[e.RowIndex];

                    //DALTipoDocumento.TipoDocumentoId =
                    id=Convert.ToInt32(row.Cells[0].Value);
                    MessageBox.Show("Id: " + id.ToString());
                    //DALTipoDocumento.Descripcion = row.Cells[1].Value.ToString();
                }
            }
        }
    }
}
