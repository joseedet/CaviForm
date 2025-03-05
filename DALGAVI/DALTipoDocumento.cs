using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;
using Models;

namespace DAL
{
    public class DALTipoDocumento : IBaseRepositorio<TipoDocumento>
    {
        private static int TipoDocumentoId;
        private static string Descripcion = "";
        //private TipoDocumento tipoDocumento;

        public DALTipoDocumento ( )
        {
            //tipoDocumento = new TipoDocumento();

        }

        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
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
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {


                conn.Open();


                using (var command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);

                    command.ExecuteNonQuery();

                }

            }
        }

        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {


                conn.Open();


                using (var command = new SqlCommand(NonbreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TipoDocumentoId", id);

                    command.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }



            }
        }

        public static Models.TipoDocumento PorId (int id, string NonbreProcedimiento)
        {
            Models.TipoDocumento tipo = new Models.TipoDocumento();

            {
                using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
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
                                TipoDocumentoId = (int)reader[0];
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

        public static List<TipoDocumento> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

    }
}












