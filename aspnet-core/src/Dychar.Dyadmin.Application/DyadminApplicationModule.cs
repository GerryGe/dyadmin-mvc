using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dychar.Dyadmin.Authorization;

namespace Dychar.Dyadmin
{
    [DependsOn(
        typeof(DyadminCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DyadminApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DyadminAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DyadminApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
