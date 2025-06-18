using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// Clase DALConcepto, hereda de la interfaz IBaseRepositorio.
    /// </summary>
    public class DALConcepto : IBaseRepositorio<Concepto>
    {
        private static int ConceptoId;
        private static string Descripcion="";
        private static bool Activo;
        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Update y devuelve true si ha sido exitosa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Descripcion"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static bool Actualizar(int id, string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Insert.
        /// </summary>
        /// <param name="Descripcion"></param>
        /// <param name="NombreProcedimiento"></param>
        public static void Agregar (string Descripcion, string Activo, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();
                
                using(SqlCommand command=new SqlCommand(NombreProcedimiento,conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion",Descripcion);
                    command.Parameters.AddWithValue("@Activo", Activo);
                    command.ExecuteNonQuery();

                }


            }
        }

        public static void Agregar(string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Delete y devuelve true si ha sido exitosa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>bool</returns>
        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            using (SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();

                using(SqlCommand command=new SqlCommand(NonbreProcedimiento,conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", id);
                    return true;

                }
            }
        }
        /// <summary>
        /// Búsqueda de un concepto por su id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>Objeto de tipo concepto</returns>
        public static Concepto PorId (int id, string NonbreProcedimiento)
        {
            Models.Concepto tipo = new Models.Concepto();

            using (SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();

                using(SqlCommand command=new SqlCommand(NonbreProcedimiento,conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("ConceptoId", id);
                    command.ExecuteNonQuery();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {

                            ConceptoId = (int)reader[0];
                            Descripcion = reader[1].ToString();
                            Activo = (bool)reader[2];

                        }

                        return tipo;

                    }
                }

            }
        }

        public static Concepto PorId(int id, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Select y devuelve una lista de objetos de tipo concepto.
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>List</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static List<Concepto> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
