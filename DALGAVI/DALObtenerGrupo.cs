using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL
{
    public  class DALObtenerGrupo : IObtenerGrupo
    {
        /// <summary>
        /// Ejecuata un procedimiento almacenado de usuario.
        /// </summary>
        /// <remarks>Establece la conexión a la base de datos, ejecuta un procedimiento almacenado
        /// <c>@UsuarioId</c>retorna un valor escalar simple.</remarks>
        /// <param name="usuarioId">or empty.</The unique identifier of the user whose group is to be retrieved. This value cannot be null param>
        /// <param name="nombreProcedimiento">Nombre del procedimiento almacenado a ejecutar.</param>
        /// <returns>Devuelve el nombre del grupo si existe de lo contrario devuelva una cadena vacia.</returns>
        /// <exception cref="Exception">Retorna una excepción cuando ocurra un error al ejecutar la operación.</exception>
        public static string ObtenerGrupo(string usuarioId, string nombreProcedimiento)
        {
            string resultado = string.Empty;
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                try
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand(nombreProcedimiento, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UsuarioId", usuarioId);
                        // command.Parameters.AddWithValue("@Contrasenya", Contrasenya);

                        resultado = (string)command.ExecuteScalar();
                        return resultado;
                    }
                }


                catch (Exception ex)
                {
                    throw new Exception("Error al validar usuario: " + ex.Message);
                }
            }
        }
    }
}
