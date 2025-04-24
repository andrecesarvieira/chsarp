using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SharpPonto25.Data;
using SharpPonto25.Interfaces;
using SharpPonto25.Repositories;
using SharpPonto25.Services;

namespace SharpPonto25
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configura��o padr�o da aplica��o WinForms
            ApplicationConfiguration.Initialize();

            // Configura��o do Host com inje��o de depend�ncia
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // Executa o formul�rio obtendo a inst�ncia atrav�s do container IoC
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        // Propriedade para acessar o provedor de servi�os em toda a aplica��o
        public static IServiceProvider? ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    // Registro do DbContext
                    services.AddDbContext<AppDbContext>();

                    // Registro de reposit�rios
                    services.AddScoped<IRegistroRepository, RegistroRepository>();

                    // Registro de servi�os
                    services.AddScoped<IRegistroService, RegistroService>();

                    // Registro de servi�os
                    services.AddScoped<IExportarService, ExportarService>();

                    // Registro de formul�rios
                    services.AddTransient<MainForm>();
                });
        }
    }
}
