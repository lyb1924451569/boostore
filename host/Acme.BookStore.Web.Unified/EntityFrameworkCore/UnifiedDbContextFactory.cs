using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStore.EntityFrameworkCore;

public class UnifiedDbContextFactory : IDesignTimeDbContextFactory<UnifiedDbContext>
{
    public UnifiedDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<UnifiedDbContext>()
            .UseMySql(configuration.GetConnectionString("Default"),new MySqlServerVersion("8.0"));

        return new UnifiedDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
