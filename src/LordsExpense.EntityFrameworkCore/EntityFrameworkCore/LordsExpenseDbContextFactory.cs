using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LordsExpense.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class LordsExpenseDbContextFactory : IDesignTimeDbContextFactory<LordsExpenseDbContext>
{
    public LordsExpenseDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        LordsExpenseEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<LordsExpenseDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new LordsExpenseDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LordsExpense.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
