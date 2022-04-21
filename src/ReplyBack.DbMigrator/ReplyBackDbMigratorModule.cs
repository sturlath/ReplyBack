using ReplyBack.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ReplyBack.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ReplyBackEntityFrameworkCoreModule),
    typeof(ReplyBackApplicationContractsModule)
    )]
public class ReplyBackDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
