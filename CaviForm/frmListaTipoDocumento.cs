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
            dataGridViewTipoDocumentos.DataSource=DALTipoDocumento.TodosLosRegistros("ListarTodosTiposDocumento");
            dataGridViewTipoDocumentos.Columns[0].Visible = false;  

        }
    }
}
