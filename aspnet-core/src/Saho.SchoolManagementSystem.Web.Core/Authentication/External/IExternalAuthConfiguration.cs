using System.Collections.Generic;

namespace Saho.SchoolManagementSystem.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
