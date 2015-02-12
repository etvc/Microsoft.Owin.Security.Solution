using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Provider;

namespace Microsoft.Owin.Security.MpWeChat
{
    public class MpWeChatReturnEndpointContext : ReturnEndpointContext
    {
        public MpWeChatReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket)
            : base(context, ticket)
        {
        }
    }
}
