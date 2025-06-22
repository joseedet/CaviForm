using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;
using System.Data;

namespace DAL
{
    public class DALProveedor : IBaseRepositorio<Proveedor>
    {
        public static bool Actualizar(int id, string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static void Agregar(string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static bool Eliminar(int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static Proveedor PorId(int id, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static List<Proveedor> TodosLosRegistros(string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
        public static bool Agregar(int TipoDocumentoId, string RazonSocial, string NombreComercial, string NombreContacto, string ApellidoContacto,
                                   string Direccion, string CodPostal, string Poblacion, string Provincia, string Telefono,
                                   string Movil, string Correo,
                                   Boolean Activo, string NombreProcedimiento)
        {

            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString()))
            {
                if (string.IsNullOrEmpty(NombreProcedimiento))
                {
                    throw new ArgumentException("El nombre del procedimiento no puede ser nulo o vacío.", nameof(NombreProcedimiento));
                }
                try
                {
                    conn.Open();

                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@TipoDocumentoId", TipoDocumentoId);
                        command.Parameters.AddWithValue("@NombreComercial", NombreComercial);
                        command.Parameters.AddWithValue("@NombreContacto", NombreContacto);
                        command.Parameters.AddWithValue("@ApellidosContacto", ApellidoContacto);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.Parameters.AddWithValue("@CodPostal", CodPostal);
                        command.Parameters.AddWithValue("@Poblacion", Poblacion);
                        command.Parameters.AddWithValue("@Provincia", Provincia);
                        command.Parameters.AddWithValue("@Telefono", Telefono);
                        command.Parameters.AddWithValue("@Movil", Movil);
                        command.Parameters.AddWithValue("@Correo", Correo);
                        command.Parameters.AddWithValue("@Activo", Activo);

                        command.ExecuteNonQuery();

                        return true;

                    }
                }
                catch (SqlException ex)
                {
                    // Manejo de excepciones SQL
                    Console.WriteLine($"Error SQL: {ex.Message}");
                    LogEx.LogException.LogError(ex, "Error al agregar proveedor.");
                    return false;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }
    }
}
