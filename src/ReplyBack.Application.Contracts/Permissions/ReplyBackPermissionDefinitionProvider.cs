using ReplyBack.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ReplyBack.Permissions;

public class ReplyBackPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ReplyBackPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ReplyBackPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ReplyBackResource>(name);
    }
}
