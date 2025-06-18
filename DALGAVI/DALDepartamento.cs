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

        public static bool Actualizar(int id, string Descripcion, bool Activo, string NombreProcedimiento)
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

        public static void Agregar(string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
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

        public static Departamento PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Departamento PorId(int id, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static List<Departamento> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
