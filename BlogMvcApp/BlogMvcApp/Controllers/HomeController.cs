using BlogMvcApp.Models.EntityFramework.Context;
using BlogMvcApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogMvcApp.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var blogs = await context.Blogs
                .Select(a => new BlogModel
                {
                    Id = a.Id,
                    Title = a.Title.Length > 100 ? a.Title.Substring(0, 100) + "..." : a.Title,
                    Description = a.Description,
                    Picture = a.Picture,
                    AddingDate = a.AddingDate,
                    IsOk=a.IsOk,
                    IsHomePage=a.IsHomePage
                })
                .Where(a => a.IsOk == true && a.IsHomePage == true)
                .OrderByDescending(a => a.AddingDate)
                .ToListAsync();
            ViewBag.categories = await context.Categories.ToListAsync();

            return View(blogs);
        }
    }
}