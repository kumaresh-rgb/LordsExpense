using LordsExpense.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LordsExpense.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class LordsExpenseController : AbpControllerBase
{
    protected LordsExpenseController()
    {
        LocalizationResource = typeof(LordsExpenseResource);
    }
}
