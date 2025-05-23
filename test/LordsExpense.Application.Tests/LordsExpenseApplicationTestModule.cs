using Volo.Abp.Modularity;

namespace LordsExpense;

[DependsOn(
    typeof(LordsExpenseApplicationModule),
    typeof(LordsExpenseDomainTestModule)
)]
public class LordsExpenseApplicationTestModule : AbpModule
{

}
