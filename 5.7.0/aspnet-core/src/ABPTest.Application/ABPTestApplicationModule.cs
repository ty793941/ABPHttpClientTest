using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPTest.Authorization;

namespace ABPTest
{
    [DependsOn(
        typeof(ABPTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
