using Zony.Abp.WeChat.Official.Infrastructure;

namespace Zony.Abp.WeChat.Official
{
    public class AbpWeChatOfficialOptions : IWeChatOfficialOptions
    {
        public string Token { get; set; }

        public string AppId { get; set; }

        public string AppSecret { get; set; }

        public string EncodingAesKey { get; set; }

        public string OAuthRedirectUrl { get; set; }
    }
}