using Newtonsoft.Json.Linq;
namespace Dal
{
    public static class DbConexion
    {

        private static string connectionString;

        static DbConexion()
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
                Console.WriteLine(connectionString);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al leer el archivo de configuración: {ex.Message.ToString()}");
            }
        }

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }

}

