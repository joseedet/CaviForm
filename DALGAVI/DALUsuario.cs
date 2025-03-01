using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;
namespace DAL
{
    public class DALUsuario : IBaseRepositorio<Usuario>
    {
        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Usuario PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Task<List<Usuario>> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static void Agregar(string UsuarioId,string Nombre,string Apellidos, string Contrasenya,DateOnly FechaModificacionContra, int RolId,string Correo,string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();
                    using(SqlCommand command=new SqlCommand(NombreProcedimiento,conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Apellidos", Apellidos);
                        command.Parameters.AddWithValue("@Contrasenya", Contrasenya);
                        command.Parameters.AddWithValue("@FechaModificacionContra", FechaModificacionContra);
                        command.Parameters.AddWithValue("RolId", RolId);
                        command.Parameters.AddWithValue("Correo", Correo);

                        command.ExecuteNonQuery();

                    }
            }

        }
        public static int ValidarUsuario(string UsuarioId,string Contrasenya,string NombreProcedimiento)
        {
            int resultado;
            using(SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();
                    using(SqlCommand command=new SqlCommand(NombreProcedimiento,conn))
                    {
                        command.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                        command.Parameters.AddWithValue("@Contrasenya", Contrasenya);

                        resultado = (int)command.ExecuteScalar();
                        return resultado;
                    }
            }


        }
    }
}
