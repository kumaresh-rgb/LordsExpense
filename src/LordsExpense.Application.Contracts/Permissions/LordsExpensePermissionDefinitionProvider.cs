using LordsExpense.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace LordsExpense.Permissions;

public class LordsExpensePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LordsExpensePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(LordsExpensePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LordsExpenseResource>(name);
    }
}
