using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Saho.SchoolManagementSystem.Configuration;

namespace Saho.SchoolManagementSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(SchoolManagementSystemWebCoreModule))]
    public class SchoolManagementSystemWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolManagementSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManagementSystemWebHostModule).GetAssembly());
        }
    }
}
