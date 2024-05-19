using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CompanyManagement.Web.Views
{
    public abstract class CompanyManagementRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CompanyManagementRazorPage()
        {
            LocalizationSourceName = CompanyManagementConsts.LocalizationSourceName;
        }
    }
}
