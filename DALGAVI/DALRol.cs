using System.Collections.Generic;
using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;

namespace DAL
{
    public class DALRol : IBaseRepositorio<Rol>
    {

        
        
        
        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@RolId", id);
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

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.ExecuteNonQuery();


                }

            }
        }

        public static bool Eliminar (int id, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {

                    command.Parameters.AddWithValue("@RolId", id);
                    command.ExecuteNonQuery();

                    return true;
                }
            }

        }

        public static Rol PorId (int id, string NonbreProcedimiento)
        {
            throw new NotImplementedException();
        }


        public static List<Rol> TodosLosRegistros (string NombreProcedimiento)
        {


            List<Rol> lst = new List<Rol>();
           

            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))
            {

                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        
                        while (reader.Read())
                        {

                            
                            Rol rol = new Rol();
                            rol.RolId = (int)reader[0];
                            rol.Descripcion = reader[1].ToString();


                            lst.Add(rol);
                            
                            
                           

                        }
                        
                        return lst;




                    }



                }

            }
        }
        public static SqlDataReader Registros (string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DalDbConexion.GetConnectionString().ToString()))

            {
                conn.Open();

                using (SqlCommand command = new SqlCommand(NombreProcedimiento, conn))
                {


                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        //int cuenta = 0;
                        //while (reader.Read())
                        //{

                        //    //lst = new List<Rol>();
                        //    //rol = new Rol();
                        //    //rol.RolId = (int)reader[0];
                        //    rol.Descripcion = reader[1].ToString();


                        //    lst.Insert(cuenta, rol);
                        //    cuenta++;
                        //    // rol.Roles.Add(r);
                        //    Console.WriteLine(rol.Descripcion);
                        //    //return lst;
                        //}
                        //// lst = rol.Roles;

                        return reader;



                    }


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

        public static Rol PorId(int id, bool Activo, string NombreProcedimiento)
        {
            throw new NotImplementedException();
        }
    }
}
