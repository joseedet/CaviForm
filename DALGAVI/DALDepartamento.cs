using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;

namespace DAL
{
    public class DALDepartamento : IBaseRepositorio<Departamento>
    {
        //private FileStream fileStream;

        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
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

                using (SqlCommand command = new SqlCommand(NonbreProcedimiento, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("AlmacenId", id);
                    command.ExecuteNonQuery();
                    return true;
                }

            }
        }

        public static Models.Departamento PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Task<List<Departamento>> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
