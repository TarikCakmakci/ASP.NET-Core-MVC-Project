﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Project.Controllers
{
    [AllowAnonymous]
  
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogByID(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCategoryByWriterBm(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                select new SelectListItem
                {
                    Text=x.CategoryName,
                    Value= x.CategoryId.ToString()

                }).ToList();
            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator bv = new BlogValidator();
            ValidationResult results = bv.Validate(p);
            if (results.IsValid)
            {
                p.BlogStatus = true;
                //Status false yapılıp, post admin onayına sunulabilir.
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterId = 1;
                bm.TAdd(p);
                return RedirectToAction("BlogListByWriter", "Blog");

            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();
            
        }
        public IActionResult DeleteBlog(int id)
        {
            var blogvalue = bm.TGetById(id);
            bm.TDelete(blogvalue);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
