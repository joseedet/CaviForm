using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Microsoft.Data.SqlClient;
using Models;
using System.IO;



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
            var connectionString = DbConnection.GetConnectionString();

            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        //MessageBox.Show("Conexión exitosa a la base de datos.");
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
}
