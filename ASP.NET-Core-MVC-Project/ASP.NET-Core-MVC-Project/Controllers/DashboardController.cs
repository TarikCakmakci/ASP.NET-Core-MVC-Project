using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
    }
}
