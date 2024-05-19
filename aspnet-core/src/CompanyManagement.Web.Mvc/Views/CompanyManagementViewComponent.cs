using Abp.AspNetCore.Mvc.ViewComponents;

namespace CompanyManagement.Web.Views
{
    public abstract class CompanyManagementViewComponent : AbpViewComponent
    {
        protected CompanyManagementViewComponent()
        {
            LocalizationSourceName = CompanyManagementConsts.LocalizationSourceName;
        }
    }
}
