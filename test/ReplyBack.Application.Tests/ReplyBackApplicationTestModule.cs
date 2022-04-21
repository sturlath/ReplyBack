using Volo.Abp.Modularity;

namespace ReplyBack;

[DependsOn(
    typeof(ReplyBackApplicationModule),
    typeof(ReplyBackDomainTestModule)
    )]
public class ReplyBackApplicationTestModule : AbpModule
{

}
