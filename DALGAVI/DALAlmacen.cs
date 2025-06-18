using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;
using System;
using System.Data;


namespace DAL
{
    /// <summary>
    /// Clase DALAlmacen, hereda de la interfaz IBaseRepositorio.
    /// </summary>
    public class DALAlmacen : IBaseRepositorio<Almacen>
    {

        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Update y devuelve true si ha sido exitosa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="Descripcion"></param>
        /// <param name="NombreProcedimiento"></param>
        /// <returns>bool</returns>

        public static bool Actualizar (int id, string Descripcion,bool Activo, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                    conn.Open();
                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.ExecuteNonQuery();
                        return true;
                    }              
            }
        }
        /// <summary>
        /// Ejecuta consulta a base de datos del tipo Insert y devuelve true si ha sido exitosa
        /// </summary>
        /// <param name="Descripcion"></param>
        /// <param name="NombreProcedimiento"></param>
        public static void Agregar (string Descripcion,bool Activo, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                
                    conn.Open();
                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@Activo", Activo);
                        command.ExecuteNonQuery();
                    }                
            }   
        }
        /// <summary>        
        /// Ejecuta consulta a base de datos del tipo Delete y devuelve true si ha sido exitosa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns>bool</returns>
        /// 
        public static void Agregar(string Descripcion,string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();
                using (var command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                   // command.Parameters.AddWithValue("@Activo", Activo);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
              
                    conn.Open();
                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AlmacenId", id);
                        command.ExecuteNonQuery();
                        return true;
                    }
            }
           

        }
        /// <summary>
        /// Ejecuta consulta a base de datos del tipo select parametrizada y devuelve true si ha sido exitosa
        /// </summary>
        /// <param name="id"></param>
        /// <param name="NonbreProcedimiento"></param>
        /// <returns></returns>
        public static Almacen PorId (int id, bool Activo,string NonbreProcedimiento)
        {
                Almacen tipo = new Almacen();

            {
                using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
                {


                    conn.Open();


                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AlmacenId", id);

                        //command.ExecuteReader();                    

                      

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tipo.AlmacenId = (int)reader[0];
                                tipo.Descripcion = reader[1].ToString();
                                tipo.Activo = (bool)reader[2];

                            }

                            conn.Close();                            
                        }
                        return tipo;
                    }
                }
            }
        }

        

        public static List<Almacen>TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
