using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReplyBack.Data;
using Volo.Abp.DependencyInjection;

namespace ReplyBack.EntityFrameworkCore;

public class EntityFrameworkCoreReplyBackDbSchemaMigrator
    : IReplyBackDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreReplyBackDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ReplyBackDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ReplyBackDbContext>()
            .Database
            .MigrateAsync();
    }
}
