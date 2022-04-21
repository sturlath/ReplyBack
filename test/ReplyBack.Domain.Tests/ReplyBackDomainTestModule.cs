using ReplyBack.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ReplyBack;

[DependsOn(
    typeof(ReplyBackEntityFrameworkCoreTestModule)
    )]
public class ReplyBackDomainTestModule : AbpModule
{

}
