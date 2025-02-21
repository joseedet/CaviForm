﻿using System.Data;
using Dal;
using DAL.Interfaces;
using Microsoft.Data.SqlClient;
using Models;
//using DbConexion = Dal.DbConexion;

namespace DAL
{
    public class Almacen : IBaseRepositorio<Models.Almacen>
    {

        private int AlmacenId;
        private string Descripcion="";

        public static bool Actualizar (int id, string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
            {
                try
                {
                    conn.Open();
                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.ExecuteNonQuery();
                    }
                    return true;
                }
                catch
                {
                    return false;

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static void Agregar (string Descripcion, string NombreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
            {
                try
                {
                    conn.Open();
                    using (var command = new SqlCommand(NombreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.ExecuteNonQuery();
                    }
                }
                catch
                {


                }
                finally
                {
                    conn.Close();
                }
            }

        }

        public static bool Eliminar (int id, string NonbreProcedimiento)
        {
            using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
            {
                try
                {
                    conn.Open();
                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@AlmacenId", id);
                        command.ExecuteNonQuery();
                    }
                    return true;

                }
                catch
                {
                    return false;

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static Models.Almacen PorId (int id, string NonbreProcedimiento)
        {
            Models.Almacen tipo = new Models.Almacen();

            {
                using (SqlConnection conn = new SqlConnection(DbConexion.GetConnectionString().ToString()))
                {


                    conn.Open();


                    using (var command = new SqlCommand(NonbreProcedimiento, conn))
                    {

                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Almacen", id);

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
