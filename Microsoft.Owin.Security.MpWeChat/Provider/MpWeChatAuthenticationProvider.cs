using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Owin.Security.MpWeChat
{
    public class MpWeChatAuthenticationProvider : IMpWeChatAuthenticationProvider
    {
        public MpWeChatAuthenticationProvider()
        {
            onAuthenticated = (c) => Task.FromResult<MpWeChatAuthenticatedContext>(null);
            onReturnEndpoint = (c) => Task.FromResult<MpWeChatReturnEndpointContext>(null);
        }

        public Func<MpWeChatAuthenticatedContext, Task> onAuthenticated { get; set; }
        public Func<MpWeChatReturnEndpointContext, Task> onReturnEndpoint { get; set; }

        public Task Authenticated(MpWeChatAuthenticatedContext context)
        {
            return onAuthenticated(context);
        }

        public Task ReturnEndpoint(MpWeChatReturnEndpointContext context)
        {
            return onReturnEndpoint(context);
        }
    }
}
