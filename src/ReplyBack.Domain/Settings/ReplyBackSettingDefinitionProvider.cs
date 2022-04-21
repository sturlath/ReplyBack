using Volo.Abp.Settings;

namespace ReplyBack.Settings;

public class ReplyBackSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ReplyBackSettings.MySetting1));
    }
}
