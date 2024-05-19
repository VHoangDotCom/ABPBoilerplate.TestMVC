using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CompanyManagement.Authorization;

namespace CompanyManagement
{
    [DependsOn(
        typeof(CompanyManagementCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CompanyManagementApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CompanyManagementAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CompanyManagementApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
