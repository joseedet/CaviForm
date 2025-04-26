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
        /// <summary>
        /// Se actualiza el tipo de documento.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Descripcion"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>boolean</returns>
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
        /// <summary>
        /// Añadimos un nuevo tipo de documente.
        /// </summary>
        /// <param name="Descripcion"></param>
        /// <param name="activo"></param>
        /// <param name="NombreProcedimiento"></param>
        public static void Agregar (string Descripcion,string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {


                conn.Open();


                using (var command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                   // command.Parameters.AddWithValue("@Activo", Activo);

                    command.ExecuteNonQuery();

                }

            }
        }
        /// <summary>
        /// Agregamos un nuevo tipo de documento
        /// </summary>
        /// <param name="Descripcion"></param>
        /// <param name="Activo"></param>
        /// <param name="NombreProcedimiento"></param>
        public static void Agregar (string Descripcion, bool Activo, string NombreProcedimiento)
        {


            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {


                conn.Open();


                using (var command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@Activo", Activo);

                    command.ExecuteNonQuery();

                }

            }

        }
        /// <summary>
        /// Se actualiza el estado activo a inactivo. Borrado lógico, pero no físco.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>boolean</returns>
        /// 

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
        /// <summary>
        /// Búsqueda de un tipo de documento por el identificador de este.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>TipoDocumento</returns>
        public static TipoDocumento PorId (int id, string NonbreProcedimiento)
        {
            TipoDocumento tipo = new TipoDocumento();

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

        /// <summary>
        /// Todos los tipos de documentos.
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>Lista de tipo de documentos</returns>
        public static List<TipoDocumento> TodosLosRegistros (string NombreProcedimiento)
        {
            List<TipoDocumento> lst = new List<TipoDocumento>();


            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {


                        while (reader.Read())
                        {


                            TipoDocumento tipoDocumento = new TipoDocumento();
                            tipoDocumento.TipoDocumentoId = (int)reader[0];
                            tipoDocumento.Descripcion = reader[1].ToString();


                            lst.Add(tipoDocumento);




                        }

                        return lst;
                    }

                }

            }
        }

    }
}












