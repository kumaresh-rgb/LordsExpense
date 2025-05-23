using LordsExpense.Localization;
using Volo.Abp.Application.Services;

namespace LordsExpense;

/* Inherit your application services from this class.
 */
public abstract class LordsExpenseAppService : ApplicationService
{
    protected LordsExpenseAppService()
    {
        LocalizationResource = typeof(LordsExpenseResource);
    }
}
