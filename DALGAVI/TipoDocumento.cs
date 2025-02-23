using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
    public class TipoDocumento : IBaseRepositorio<Models.TipoDocumento>
    {
        private static int TipoDocumentoId;
        private static string Descripcion = "";
        //private TipoDocumento tipoDocumento;

        public TipoDocumento ( )
        {
            //tipoDocumento = new TipoDocumento();

        }

        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
            {
                try
                {
                    conn.Open();
                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@TipoDocumentoId", id);

                        command.ExecuteNonQuery();
                        return true;

                    }
                }
                catch
                {
                    conn.Close();
                    return false;

                }
                finally
                {
                    conn.Close();
                }

            }
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
            {
                try
                {
                    conn.Open();


                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);

                        command.ExecuteNonQuery();

                    }


                }
                catch( SqlException ex)
                {
                    ex.Errors.ToString();
                }
                finally
                {
                    conn.Close();

                }

            }
        }

        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
            {
                try
                {
                    conn.Open();


                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TipoDocumentoId", id);

                        command.ExecuteNonQuery();

                    }
                    return true;

                }
                catch
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

        public static Models.TipoDocumento PorId (int id, string NonbreProcedimiento)
        {
            Models.TipoDocumento tipo = new Models.TipoDocumento();

            {
                using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
                {


                    conn.Open();


                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TipoDocumentoId", id);

                        //command.ExecuteReader();



                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TipoDocumento.TipoDocumentoId = (int)reader[0];
                                Descripcion = reader[1].ToString();

                            }

                            conn.Close();

                            tipo.TipoDocumentoId = TipoDocumentoId;
                            tipo.Descripcion = Descripcion.ToString();
                        }
                        return tipo;
                    }

                }
            }
        }

        public static Task<List<Models.TipoDocumento>> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

    }        
}



        


        



            

            