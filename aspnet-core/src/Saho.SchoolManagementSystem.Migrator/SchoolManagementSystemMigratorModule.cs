using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Saho.SchoolManagementSystem.Configuration;
using Saho.SchoolManagementSystem.EntityFrameworkCore;
using Saho.SchoolManagementSystem.Migrator.DependencyInjection;

namespace Saho.SchoolManagementSystem.Migrator
{
    [DependsOn(typeof(SchoolManagementSystemEntityFrameworkModule))]
    public class SchoolManagementSystemMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolManagementSystemMigratorModule(SchoolManagementSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SchoolManagementSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SchoolManagementSystemConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManagementSystemMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
