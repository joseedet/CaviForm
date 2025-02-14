using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DAL
{
    public class ErrorLog
    {
        private static string cadenaconexion;
        static ErrorLog ()
        {
            FileConnectionString();
        }
        private static void FileConnectionString()
        {
            try
            {
                var json = File.ReadAllText("config.json");
                var config = JObject.Parse(json);
                cadenaconexion = config["Logs"]["Path"].ToString();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al leer el archivo de configuración: {ex.Message}");
            }
        }
        public static string GetConnectionString ( )
        {
            return cadenaconexion;
        }

    }
}
