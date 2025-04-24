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
            // Configuração padrão da aplicação WinForms
            ApplicationConfiguration.Initialize();

            // Configuração do Host com injeção de dependência
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            // Executa o formulário obtendo a instância através do container IoC
            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        // Propriedade para acessar o provedor de serviços em toda a aplicação
        public static IServiceProvider? ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    // Registro do DbContext
                    services.AddDbContext<AppDbContext>();

                    // Registro de repositórios
                    services.AddScoped<IRegistroRepository, RegistroRepository>();

                    // Registro de serviços
                    services.AddScoped<IRegistroService, RegistroService>();

                    // Registro de serviços
                    services.AddScoped<IExportarService, ExportarService>();

                    // Registro de formulários
                    services.AddTransient<MainForm>();
                });
        }
    }
}
