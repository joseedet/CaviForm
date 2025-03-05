using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;


namespace DAL
{
    public class DALUsuario : IBaseRepositorio<Usuario>
    {
      /*private string UsuarioId = "";
        private string Nombre = "";
        private string Apellidos = "";
        private string Contrasenya = "";
        private DateOnly FechaModificacionContra;
        private int RolId;
        private string Correo="";*/

        /// <summary>
        /// Actualiza datos del usuario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Descripcion"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>boolean</returns>
        /// <exception cref="NotImplementedException"></exception>
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

        public static Usuario PorId (string id, string NombreProcedimiento)
        {
            Usuario user = new Usuario();

            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UsuarioId", id);

                    using(SqlDataReader reader= command.ExecuteReader())
                    {
                        while(reader.Read())
                        {

                            user.UsuarioId = reader[0].ToString();
                            user.Nombre = reader[1].ToString();
                            user.Apellidos = reader[2].ToString();
                            user.Contrasenya = reader[3].ToString();
                            user.RolId = (int)reader[4];
                            user.Correo = reader[5].ToString();

                        }

                        return user;
                    }

                }

            }
        }
        public static Usuario PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }
       

        public static List<Usuario> TodosLosRegistros (string NombreProcedimiento)
        {
            Usuario user = new Usuario();
            List<Usuario> lst = new List<Usuario>();
            using (SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            user.UsuarioId = reader[0].ToString();
                            user.Nombre = reader[1].ToString();
                            user.Apellidos = reader[2].ToString();
                            user.Contrasenya = reader[3].ToString();
                            user.RolId = (int)reader[4];
                            user.Correo = reader[5].ToString();

                            lst.Add(user);

                        }

                        return lst;
                    }

                }
            }
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
