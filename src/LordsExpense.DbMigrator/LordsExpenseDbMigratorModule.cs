using LordsExpense.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace LordsExpense.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LordsExpenseEntityFrameworkCoreModule),
    typeof(LordsExpenseApplicationContractsModule)
)]
public class LordsExpenseDbMigratorModule : AbpModule
{
}
