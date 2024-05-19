using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CompanyManagement.Configuration;

namespace CompanyManagement.Web.Host.Startup
{
    [DependsOn(
       typeof(CompanyManagementWebCoreModule))]
    public class CompanyManagementWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CompanyManagementWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CompanyManagementWebHostModule).GetAssembly());
        }
    }
}
