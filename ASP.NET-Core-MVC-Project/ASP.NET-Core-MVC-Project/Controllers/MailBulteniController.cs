using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Controllers
{
    public class MailBulteniController : Controller
    {
        MailBulteniManager mb = new MailBulteniManager(new EfMailBulteniRepository());

        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView(); 
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(MailBulteni m)
        {
            m.EmailStatus = true;
            mb.AddMailBulteni(m);
            return PartialView();
        }
    }
}
