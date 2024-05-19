using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CompanyManagement.EntityFrameworkCore;
using CompanyManagement.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace CompanyManagement.Web.Tests
{
    [DependsOn(
        typeof(CompanyManagementWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CompanyManagementWebTestModule : AbpModule
    {
        public CompanyManagementWebTestModule(CompanyManagementEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CompanyManagementWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CompanyManagementWebMvcModule).Assembly);
        }
    }
}