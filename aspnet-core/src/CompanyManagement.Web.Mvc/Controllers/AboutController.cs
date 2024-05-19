using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CompanyManagement.Controllers;

namespace CompanyManagement.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : CompanyManagementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
