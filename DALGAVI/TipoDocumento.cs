using Dal;
using Microsoft.Data.SqlClient;
using System.Data;



namespace DAL
{
    public class TipoDocumento
    {
        private Models.TipoDocumento tipo;

        public TipoDocumento ( )
        {
            tipo = new Models.TipoDocumento();

        }
        public bool InsertTipoDocumento (string Documento)
        {
            //var connectionString = DbConnection.GetConnectionString();


            using (SqlConnection conn = new SqlConnection(DbConnection.GetConnectionString().ToString()))
            { 
                try
                {
                    conn.Open();
                           

                    using (var command = new SqlCommand("InsertTipoDocumento", conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@tipoDocumento", tipo.Descripcion);
                        //command.Parameters.AddWithValue("@Contenido", post.Titulo);
                        //command.Parameters.AddWithValue("@CategoriaId", post.CategoriaId);                      

                    }
                    return true;


                }
                catch (Exception ex)
                {
                    // MessageBox.Show($"Error al conectar a la base de datos: {ex.Message}");

                    return false;
                }
                finally
                {
                    conn.Close();

                }

            }

        }

    }
}
        


        



            

            