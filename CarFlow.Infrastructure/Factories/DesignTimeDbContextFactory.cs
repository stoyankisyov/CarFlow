using CarFlow.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CarFlow.Infrastructure.Factories;

internal class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarFlowContext>
{
    private static IConfiguration Configuration => new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("db-design-settings.json").Build();

    public CarFlowContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<CarFlowContext>();

        var connectionString = Configuration.GetConnectionString("SQLConnection");

        if (string.IsNullOrEmpty(connectionString))
        {
            throw new InvalidOperationException("The environment variable 'SQLConnection' is not set");
        }

        optionsBuilder.UseSqlServer(connectionString);
        return new CarFlowContext(optionsBuilder.Options);
    }
}