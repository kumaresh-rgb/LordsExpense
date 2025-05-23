using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using LordsExpense.Data;
using Volo.Abp.DependencyInjection;

namespace LordsExpense.EntityFrameworkCore;

public class EntityFrameworkCoreLordsExpenseDbSchemaMigrator
    : ILordsExpenseDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLordsExpenseDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the LordsExpenseDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<LordsExpenseDbContext>()
            .Database
            .MigrateAsync();
    }
}
