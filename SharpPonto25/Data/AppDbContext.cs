using Microsoft.EntityFrameworkCore;
using SharpPonto25.Entities;

namespace SharpPonto25.Data
{
    /// <summary>
    /// Contexto de banco de dados para a aplicação SharpPonto.
    /// </summary>
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// Conjunto de registros de ponto no banco de dados.
        /// </summary>
        public DbSet<Registro> Registros { get; set; }

        /// <summary>
        /// Configura as opções do contexto de banco de dados.
        /// </summary>
        /// <param name="optionsBuilder">O construtor de opções a ser configurado.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=SharpPonto.db");

        /// <summary>
        /// Aplica migrações pendentes do banco de dados.
        /// </summary>
        public void AplicarMigracao()
        {
            Database.Migrate();
        }

        /// <summary>
        /// Retorna o caminho completo do arquivo de banco de dados.
        /// </summary>
        /// <returns>Caminho completo para o arquivo de banco de dados.</returns>
        public static string CaminhoDb()
        {
            string diretorioAplicacao = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(diretorioAplicacao, "SharpPonto.db");
            return path;
        }
    }
}
