using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Blog();
            return View(values);
        }
    }
}
