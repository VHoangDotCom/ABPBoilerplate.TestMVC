using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CompanyManagement.Controllers;

namespace CompanyManagement.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CompanyManagementControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
