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
        /// Update datos del usuario
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
        /// <summary>
        /// Busca un usuario por el id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>Usuario</returns>
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
                            user.Activo= (bool)reader[6];
                        }

                        return user;
                    }

                }

            }
        }
        /// <summary>
        /// Busca usuario por id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>Usuario</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Usuario PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }
       
        /// <summary>
        /// Obtiene un todos los registros base de datos
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>List</returns>
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
        /// <summary>
        /// Inserta procedimento almacenado en base de datos.
        /// </summary>
        /// <param name="UsuarioId"></param>
        /// <param name="Nombre"></param>
        /// <param name="Apellidos"></param>
        /// <param name="Contrasenya"></param>
        /// <param name="FechaModificacionContra"></param>
        /// <param name="RolId"></param>
        /// <param name="Correo"></param>
        /// <param name="NombreProcedimiento"></param>

        public static void Agregar(string UsuarioId,string Nombre,string Apellidos, string Contrasenya,DateTime FechaModificacionContra, int RolId,string Correo,string NombreProcedimiento)
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
        /// <summary>
        /// Valida que el usuario sea el correocto.
        /// </summary>
        /// <param name="UsuarioId"></param>
        /// <param name="Contrasenya"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>int</returns>
        public static int ValidarUsuario(string UsuarioId,string Contrasenya,string NombreProcedimiento)
        {
          


            int resultado;
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                try
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                        command.Parameters.AddWithValue("@Contrasenya", Contrasenya);

                        resultado = Convert.ToInt32(command.ExecuteScalar());
                        return resultado;
                    }
                }


                catch (Exception ex)
                {
                    throw new Exception("Error al validar usuario: " + ex.Message);
                }
            }         
           
        }

        public static void Agregar(string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static bool Actualizar(int id, string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Usuario PorId(int id, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
       

       
    }
}
