using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Abp.Application.Services.Dto;
using Abp.Web.Mvc.Authorization;
using MyCompanyName.AbpZeroTemplate.Authorization;
using MyCompanyName.AbpZeroTemplate.Authorization.Permissions;
using MyCompanyName.AbpZeroTemplate.Authorization.Users;
using MyCompanyName.AbpZeroTemplate.Web.Areas.Mpa.Models.Users;
using MyCompanyName.AbpZeroTemplate.Web.Controllers;
using MyCompanyName.AbpZeroTemplate.Authorization.Roles;
using MyCompanyName.AbpZeroTemplate.Authorization.Roles.Dto;
using System.Collections.Generic;

namespace MyCompanyName.AbpZeroTemplate.Web.Areas.Mpa.Controllers
{
    public class ProductController : AbpZeroTemplateControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
       
    }
}