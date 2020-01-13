using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Ejec.Authorization;

namespace Ejec
{
    [DependsOn(
        typeof(EjecCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EjecApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EjecAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EjecApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
