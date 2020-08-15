using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPTest.EntityFrameworkCore;
using ABPTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ABPTest.Web.Tests
{
    [DependsOn(
        typeof(ABPTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ABPTestWebTestModule : AbpModule
    {
        public ABPTestWebTestModule(ABPTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ABPTestWebMvcModule).Assembly);
        }
    }
}