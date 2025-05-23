using Volo.Abp.Modularity;

namespace LordsExpense;

[DependsOn(
    typeof(LordsExpenseDomainModule),
    typeof(LordsExpenseTestBaseModule)
)]
public class LordsExpenseDomainTestModule : AbpModule
{

}
