using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Saho.SchoolManagementSystem.Authorization;

namespace Saho.SchoolManagementSystem
{
    [DependsOn(
        typeof(SchoolManagementSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SchoolManagementSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SchoolManagementSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SchoolManagementSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
