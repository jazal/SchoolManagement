using Abp.AutoMapper;
using Saho.SchoolManagementSystem.Authentication.External;

namespace Saho.SchoolManagementSystem.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
