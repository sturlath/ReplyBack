using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ReplyBack.Data;

/* This is used if database provider does't define
 * IReplyBackDbSchemaMigrator implementation.
 */
public class NullReplyBackDbSchemaMigrator : IReplyBackDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
