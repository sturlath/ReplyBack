using System;
using System.Collections.Generic;
using System.Text;
using ReplyBack.Localization;
using Volo.Abp.Application.Services;

namespace ReplyBack;

/* Inherit your application services from this class.
 */
public abstract class ReplyBackAppService : ApplicationService
{
    protected ReplyBackAppService()
    {
        LocalizationResource = typeof(ReplyBackResource);
    }
}
