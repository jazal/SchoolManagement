using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Saho.SchoolManagementSystem.EntityFrameworkCore;
using Saho.SchoolManagementSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Saho.SchoolManagementSystem.Web.Tests
{
    [DependsOn(
        typeof(SchoolManagementSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SchoolManagementSystemWebTestModule : AbpModule
    {
        public SchoolManagementSystemWebTestModule(SchoolManagementSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManagementSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SchoolManagementSystemWebMvcModule).Assembly);
        }
    }
}