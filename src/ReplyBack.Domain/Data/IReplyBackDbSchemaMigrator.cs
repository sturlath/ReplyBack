using System.Threading.Tasks;

namespace ReplyBack.Data;

public interface IReplyBackDbSchemaMigrator
{
    Task MigrateAsync();
}
