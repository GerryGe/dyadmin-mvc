using Abp.AutoMapper;
using Dychar.Dyadmin.Authentication.External;

namespace Dychar.Dyadmin.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
