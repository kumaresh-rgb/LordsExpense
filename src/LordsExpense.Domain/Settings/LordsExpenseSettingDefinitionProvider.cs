using Volo.Abp.Settings;

namespace LordsExpense.Settings;

public class LordsExpenseSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(LordsExpenseSettings.MySetting1));
    }
}
