using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CaviForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        //public static IConfiguration ?Configuration;
        [STAThread]
        static void Main ( )
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            var builder = CreateHostBuilder().Build();
            var principal = builder.Services.GetRequiredService<frmPrincipal>();
            //Application.Run(new frmPrincipal>());
            Application.Run(principal);
        }
        /// <summary>
        /// Creamos el constructor del host
        /// </summary>
        /// <returns>HostBuilder</returns>
        static IHostBuilder CreateHostBuilder ( ) => Host.CreateDefaultBuilder()
            .ConfigureAppConfiguration((context, config) => { config.AddJsonFile("config.json", optional: false, reloadOnChange: true); })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<frmPrincipal>();
            });
    }
}