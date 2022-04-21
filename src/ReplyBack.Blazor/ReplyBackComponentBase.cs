using ReplyBack.Localization;
using Volo.Abp.AspNetCore.Components;

namespace ReplyBack.Blazor;

public abstract class ReplyBackComponentBase : AbpComponentBase
{
    protected ReplyBackComponentBase()
    {
        LocalizationResource = typeof(ReplyBackResource);
    }
}
