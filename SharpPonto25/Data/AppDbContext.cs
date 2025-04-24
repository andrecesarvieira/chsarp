using Microsoft.EntityFrameworkCore;
using SharpPonto25.Entities;

namespace SharpPonto25.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=SharpPonto.db");

        public void AplicarMigracao()
        {
            Database.Migrate();
        }

        public static string CaminhoDb()
        {
            string diretorioAplicacao = AppDomain.CurrentDomain.BaseDirectory;
            string path = Path.Combine(diretorioAplicacao, "SharpPonto.db");
            return path;
        }
    }
}
