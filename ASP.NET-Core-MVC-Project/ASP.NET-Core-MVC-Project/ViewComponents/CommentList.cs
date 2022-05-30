using ASP.NET_Core_MVC_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Onur"
                },
                 new UserComment
                {
                    ID=2,
                    Username="Tarık"
                },
                  new UserComment
                {
                    ID=3,
                    Username="Mahir"
                }

            };
            return View(commentvalues);
        }
    }
}
