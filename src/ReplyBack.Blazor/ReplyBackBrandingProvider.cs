using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ReplyBack.Blazor;

[Dependency(ReplaceServices = true)]
public class ReplyBackBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ReplyBack";
}
