using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Owin.Security.MpWeChat
{
    public interface IMpWeChatAuthenticationProvider
    {
        Task Authenticated(MpWeChatAuthenticatedContext context);
        Task ReturnEndpoint(MpWeChatReturnEndpointContext context);
    }
}
