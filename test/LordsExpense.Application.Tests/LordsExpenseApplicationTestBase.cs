using Volo.Abp.Modularity;

namespace LordsExpense;

public abstract class LordsExpenseApplicationTestBase<TStartupModule> : LordsExpenseTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
