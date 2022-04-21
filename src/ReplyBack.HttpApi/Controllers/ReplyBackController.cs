using ReplyBack.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ReplyBack.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ReplyBackController : AbpControllerBase
{
    protected ReplyBackController()
    {
        LocalizationResource = typeof(ReplyBackResource);
    }
}
