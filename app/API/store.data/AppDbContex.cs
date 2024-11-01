using Microsoft.Extensions.Configuration;

namespace src.store.data;

using Microsoft.EntityFrameworkCore;

public class AppDbContex(IConfiguration configuration) : DbContext
{
    private IConfiguration _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(new MySqlServerVersion(new Version(9, 0, 1)));
    }
}