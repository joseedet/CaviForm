﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Dal
{
    public static class DbConnection
    {

        private static string connectionString;

        static DbConnection()
        {
            LoadConnectionString();
        }

        private static void LoadConnectionString()
        {
            try
            {
                var json = File.ReadAllText("config.json");
                var config = JObject.Parse(json);
                connectionString = config["ConnectionStrings"]["DefaultConnection"].ToString();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al leer el archivo de configuración: {ex.Message}");
            }
        }

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }

}

