using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;

namespace DAL
{
    public class DALConcepto : IBaseRepositorio<Models.Concepto>
    {
        private static int ConceptoId;
        private static string Descripcion="";
        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();
                
                using(SqlCommand command=new SqlCommand(NombreProcedimiento,conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion",Descripcion);
                    command.ExecuteNonQuery();

                }


            }
        }

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

        public static Models.Concepto PorId (int id, string NonbreProcedimiento)
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

                        }

                        return tipo;

                    }
                }

            }
        }

        public static Task<List<Models.Concepto>> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
