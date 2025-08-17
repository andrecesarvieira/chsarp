using Microsoft.EntityFrameworkCore;
using SharpPonto25.Entities;

namespace SharpPonto25.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SharpPonto;Trusted_Connection=True;TrustServerCertificate=True;");
            // optionsBuilder.UseSqlite("Data Source=SharpPonto.db"); // Usado anteriormente com SQLite
        }

        public void AplicarMigracao()
        {
            Database.Migrate();
        }

        //public static string CaminhoDb()
        //{
        //    string diretorioAplicacao = AppDomain.CurrentDomain.BaseDirectory;
        //    string path = Path.Combine(diretorioAplicacao, "SharpPonto.db");
        //    return path;
        //}
    }
}
