using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Acme.BookStore.EntityFrameworkCore;

public class BookStoreHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BookStoreHttpApiHostMigrationsDbContext>
{
    public BookStoreHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BookStoreHttpApiHostMigrationsDbContext>()
            .UseMySql(configuration.GetConnectionString("BookStore"), new MySqlServerVersion("8.0"));

        return new BookStoreHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
