using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Models;

namespace DAL
{
    public class DALCliente : IBaseRepositorio<Cliente>
    {
        
        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {

            throw new NotImplementedException();
        }
        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Update y devuelve true si ha sido exitosa.
        /// </summary>
        /// <param name="ClienteId"></param>
        /// <param name="NombreComercial"></param>
        /// <param name="NombreContacto"></param>
        /// <param name="ApellidoContacto"></param>
        /// <param name="Direccion"></param>
        /// <param name="CodPostal"></param>
        /// <param name="Poblacion"></param>
        /// <param name="Provincia"></param>
        /// <param name="Telefono"></param>
        /// <param name="Movil"></param>
        /// <param name="Correo"></param>
        /// <param name="Notas"></param>
        /// <param name="Aniversario"></param>
        /// <param name="Activo"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>bool</returns>
        public static bool Actualizar(int ClienteId,string NombreComercial,string NombreContacto,string ApellidoContacto,string Direccion,string CodPostal,
                                        string Poblacion,string Provincia,string Telefono,string Movil,string Correo,string Notas,DateTime Aniversario,
                                        Boolean Activo,string NombreProcedimiento)
        {
            
           
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString()))
            {
                conn.Open();

                using (var command = new SqlCommand(NombreProcedimiento, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClienteId", ClienteId);
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
                    command.Parameters.AddWithValue("@Notas", Notas);
                    command.Parameters.AddWithValue("@Aniversario", Aniversario);
                    command.Parameters.AddWithValue("@Activo", Activo);

                    command.ExecuteNonQuery();

                    return true;

                }       

            }

        }

        public static bool Actualizar(int id, string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Insert y devuelve true si ha sido exitosa.
        /// </summary>
        /// <param name="TipoDocumentoId"></param>
        /// <param name="NombreComercial"></param>
        /// <param name="NombreContacto"></param>
        /// <param name="ApellidoContacto"></param>
        /// <param name="Direccion"></param>
        /// <param name="CodPostal"></param>
        /// <param name="Poblacion"></param>
        /// <param name="Provincia"></param>
        /// <param name="Telefono"></param>
        /// <param name="Movil"></param>
        /// <param name="Correo"></param>
        /// <param name="Notas"></param>
        /// <param name="Aniversario"></param>
        /// <param name="Activo"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>bool</returns>
        public static bool Agregar(int TipoDocumentoId,string NombreComercial, string NombreContacto, string ApellidoContacto,
                                   string Direccion, string CodPostal,string Poblacion, string Provincia, string Telefono,
                                   string Movil, string Correo, string Notas, DateTime Aniversario,
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
                        command.Parameters.AddWithValue("@Notas", Notas);
                        command.Parameters.AddWithValue("@Aniversario", Aniversario);
                        command.Parameters.AddWithValue("@Activo", Activo);

                        command.ExecuteNonQuery();

                        return true;

                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, por ejemplo, registrar el error o lanzar una excepción personalizada
                    Console.WriteLine($"Error SQL: {ex.Message}");
                    // Aquí podrías registrar el error en un log o lanzar una excepción personalizada
                    LogEx.LogException.LogError(ex, "Error al agregar cliente.");
                       return false;

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }

        }

        public static void Agregar(string Descripcion, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ejecuta consulta de eliminacion de cliente.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>bool</returns>
        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            if (string.IsNullOrEmpty(NonbreProcedimiento))
            {
                throw new ArgumentException("El nombre del procedimiento no puede ser nulo o vacío.", nameof(NonbreProcedimiento));
            }
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();
                try
                {
                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ClienteId", id);

                        command.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones, por ejemplo, registrar el error o lanzar una excepción personalizada
                    Console.WriteLine($"Error SQL: {ex.Message}");
                    // Aquí podrías registrar el error en un log o lanzar una excepción personalizada
                    LogEx.LogException.LogError(ex, "Error al eliminar cliente.");
                    return false;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        /// <summary>
        /// Ejecuta consulta a base de datos del tipo select, búsqueda por id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>Cliente</returns>
        public static Cliente PorId(int id, string NombreProcedimiento)
        {
            if (id <= 0)
            { throw new ArgumentException("El id del cliente debe ser mayor que cero.", nameof(id)); }
            if (string.IsNullOrEmpty(NombreProcedimiento))
            {
                throw new ArgumentException("El nombre del procedimiento no puede ser nulo o vacío.", nameof(NombreProcedimiento));

            }
     
            using (SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
           {
                Cliente cliente = new Cliente();

                conn.Open();

                using(var command=new SqlCommand(NombreProcedimiento,conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClienteId", id);

                    using (SqlDataReader reader=command.ExecuteReader())
                    {

                        while(reader.Read())
                        {

                            cliente.ClienteId = (int)reader[0];
                            cliente.NombreComercial = reader[1].ToString();
                            cliente.NombreContacto = reader[2].ToString();
                            cliente.ApellidosContacto = reader[3].ToString();
                            cliente.Direcion = reader[4].ToString();
                            cliente.CodPostal = reader[5].ToString();
                            cliente.Poblacion = reader[6].ToString();
                            cliente.Provincia = reader[7].ToString();
                            cliente.Telefono = reader[8].ToString();
                            cliente.Movil = reader[9].ToString();
                            cliente.Correo = reader[10].ToString();
                            cliente.Notas = reader[11].ToString();
                            cliente.Aniversario = (DateTime)reader[12];
                            cliente.Activo = (bool)reader[13];


                        }

                    }

                }
                return cliente;


           }
        }

        public static Cliente PorId(int id, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ejecuta consulta a base de datos del tipo select y devuelve lista de clientes.
        /// </summary>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>Lista del tipo clientes.</returns>
        public static List<Cliente> TodosLosRegistros (string NombreProcedimiento)
        {
            List<Cliente> lst = new List<Cliente>();

            using (SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString()))
            {

                conn.Open();

                using(var command=new SqlCommand(NombreProcedimiento,conn))
                {

                    command.CommandType = CommandType.StoredProcedure;

                    using(SqlDataReader reader=command.ExecuteReader())
                    {

                        while(reader.Read())
                        {
                            Cliente cliente = new Cliente();

                            cliente.ClienteId = (int)reader[0];
                            cliente.NombreComercial = reader[1].ToString();
                            cliente.NombreContacto = reader[2].ToString();
                            cliente.ApellidosContacto = reader[3].ToString();
                            cliente.Direcion = reader[4].ToString();
                            cliente.CodPostal = reader[5].ToString();
                            cliente.Poblacion = reader[6].ToString();
                            cliente.Provincia = reader[7].ToString();
                            cliente.Telefono = reader[8].ToString();
                            cliente.Movil = reader[9].ToString();
                            cliente.Correo = reader[10].ToString();
                            cliente.Notas = reader[11].ToString();
                            cliente.Aniversario = (DateTime)reader[12];
                            cliente.Activo = (bool)reader[13];

                            lst.Add(cliente);
                        }
                        
                    }
                }
                
            }
            return lst;
        }
    }
}
