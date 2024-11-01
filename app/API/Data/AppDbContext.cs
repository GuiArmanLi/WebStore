using Microsoft.EntityFrameworkCore;
using Produtos.Data.Entities;

namespace Produtos.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Product> Products { get; set; }

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = _configuration.GetConnectionString("Default");
            optionsBuilder.UseMySQL(connection);
        }
    }
}