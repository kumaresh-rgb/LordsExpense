using Microsoft.Extensions.Localization;
using LordsExpense.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace LordsExpense;

[Dependency(ReplaceServices = true)]
public class LordsExpenseBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<LordsExpenseResource> _localizer;

    public LordsExpenseBrandingProvider(IStringLocalizer<LordsExpenseResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
