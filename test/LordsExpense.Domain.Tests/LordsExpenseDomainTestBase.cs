using Volo.Abp.Modularity;

namespace LordsExpense;

/* Inherit from this class for your domain layer tests. */
public abstract class LordsExpenseDomainTestBase<TStartupModule> : LordsExpenseTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
