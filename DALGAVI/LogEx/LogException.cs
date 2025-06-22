using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL.LogEx
{
    public class LogException
    {
        public static void LogError(Exception ex, string message = "")
        {
            // Aquí puedes implementar la lógica para registrar el error en un archivo, base de datos, etc.
            // Por ejemplo, podrías usar NLog, Serilog o cualquier otra biblioteca de logging.
            Console.WriteLine($"Error: {ex.Message}");
            using (StreamWriter w = File.AppendText("log.txt"))
            {
                w.WriteLine($"{DateTime.Now}: {ex.Message}");
                if (!string.IsNullOrEmpty(message))
                {
                    w.WriteLine($"Mensaje adicional: {message}");
                }
                w.WriteLine(ex.StackTrace);
            }
        }
    }
}
