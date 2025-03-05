using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;

namespace DAL
{
    public class DALMedida:IBaseRepositorio<Medida>
    {
        private static int MedidaId;
        private static string Descripcion="";

        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("MedidaId", id);
                    command.ExecuteNonQuery();
                    return true;

                }


            }
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();

                using(SqlCommand command=new SqlCommand(NombreProcedimiento,conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.ExecuteNonQuery();

                }


            }
        }

        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
           using(SqlConnection conn=new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
           {
                using (SqlCommand command = new SqlCommand(NonbreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("MedidaId", id);
                    command.ExecuteNonQuery();
                    return true;


                }


           }
        }

        public static Models.Medida PorId (int id, string NonbreProcedimiento)
        {
            Models.Medida tipo = new Models.Medida();

            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                using (SqlCommand command = new SqlCommand(NonbreProcedimiento, conn))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("MedidaId", id);
                    //command.ExecuteNonQuery();
                    //return true;

                    using (SqlDataReader reader=command.ExecuteReader())
                    {

                        while(reader.Read())
                        {
                            MedidaId = (int)reader[0];
                            Descripcion = reader[1].ToString();
                        }

                        conn.Close();

                        tipo.MedidaId = MedidaId;
                        tipo.Descripcion = Descripcion.ToString();
                    }
                    return tipo;
                }


            }

        }

        public static List<Medida> TodosLosRegistros (string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
