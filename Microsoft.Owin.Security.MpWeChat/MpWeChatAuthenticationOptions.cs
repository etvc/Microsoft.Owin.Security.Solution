using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Owin.Security;

namespace Microsoft.Owin.Security.MpWeChat
{
    public class MpWeChatAuthenticationOptions : AuthenticationOptions
    {
        public const string AUTHENTICATION_TYPE = "MpWeChat";
        public MpWeChatAuthenticationOptions()
            : base(AUTHENTICATION_TYPE)
        {
            Caption = "微信公众账号";
            ReturnEndpointPath = "/signin-mpwechatconnect";
            AuthenticationMode = AuthenticationMode.Passive;
            Scope = new List<string> { "snsapi_userinfo" };
            BackchannelTimeout = TimeSpan.FromSeconds(60);
        }

        public ISecureDataFormat<AuthenticationProperties> StateDataFormat { get; set; }

        public TimeSpan BackchannelTimeout { get; set; }

        public WebRequestHandler BackchannelHttpHandler { get; set; }

        public IMpWeChatAuthenticationProvider Provider { get; set; }

        public ICertificateValidator BackchannelCertificateValidator { get; set; }

        public IList<string> Scope { get; private set; }

        public string ReturnEndpointPath { get; set; }

        public string SignInAsAuthenticationType { get; set; }

        public string Caption
        {
            get { return Description.Caption; }
            set { Description.Caption = value; }
        }

        public string AppId { get; set; }

        public string AppSecret { get; set; }
    }
}
