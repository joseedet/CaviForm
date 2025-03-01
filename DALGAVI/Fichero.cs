using Newtonsoft.Json.Linq;

namespace DAL
{
    public class Fichero
    {
        private static string ruta;
        static Fichero()
        {
            CargarRuta();


        }

        private static void CargarRuta ( )
        {
            try
            {
                var json = File.ReadAllText("config.json");
                var config = JObject.Parse(json);
                ruta = config["Logs"]["Path"].ToString();
                Console.WriteLine(ruta);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error al leer el archivo de configuración: {ex.Message.ToString()}");
            }
        }
        private static string GetRuta()
        {

            return ruta;
        }
        public static void EscribirFichero(string mensajeError)
        {
           StreamWriter streamWriter;
           if(File.Exists(GetRuta().ToString()))
           {

                streamWriter=File.AppendText(GetRuta());
                streamWriter.WriteLine(mensajeError);
                // File.AppendAllText(ruta, mensajeError);

                streamWriter.Close();
               

           }
           else
           {

                streamWriter=File.AppendText(GetRuta());
                streamWriter.WriteLine(mensajeError);
                streamWriter.Close();
                //File.WriteAllText(ruta, mensajeError);
           }
            

        }
    }
}
