using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;
//using DbConexion = Dal.DbConexion;

namespace DAL
{
    public class DALAlmacen : IBaseRepositorio<Almacen>
    {

       /* private int AlmacenId;
        private string Descripcion="";*/

        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
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
                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AlmacenId", id);
                        command.ExecuteNonQuery();
                        return true;
                     }
            }
           

        }

        public static Almacen PorId (int id, string NonbreProcedimiento)
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

                            }

                            conn.Close();                            
                        }
                        return tipo;
                    }
                }
            }
        }

        public static Task<List<Models.Almacen>> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
