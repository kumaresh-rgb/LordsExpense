using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LordsExpense.Data;

/* This is used if database provider does't define
 * ILordsExpenseDbSchemaMigrator implementation.
 */
public class NullLordsExpenseDbSchemaMigrator : ILordsExpenseDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
