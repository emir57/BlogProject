using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogMvcApp.Models.Entities;
using BlogMvcApp.Models.EntityFramework.Context;
using BlogMvcApp.Models.ViewModels;

namespace BlogMvcApp.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Blogs
        public async Task<ActionResult> Index(string message)
        {
            ViewBag.message = message;
            var blogs = db.Blogs.Include(b => b.Category);
            return View(await blogs.OrderByDescending(a=>a.AddingDate).ToListAsync());
        }

        // GET: Blogs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var blog = await db.Blogs
                .Select(a => new BlogModel
                {
                    Id= a.Id,
                    Title=a.Title,
                    Description= a.Description,
                    Content= a.Content,
                    AddingDate= a.AddingDate,
                    Picture= a.Picture,
                    CategoryName= a.Category.CategoryName
                }).FirstOrDefaultAsync(a => a.Id == id);
            
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // GET: Blogs/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Blogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Title,Description,Picture,Content,IsOk,IsHomePage,CategoryId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                blog.AddingDate = DateTime.Now;
                db.Blogs.Add(blog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // GET: Blogs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = await db.Blogs.FindAsync(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // POST: Blogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Title,Description,Picture,Content,IsOk,IsHomePage,CategoryId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                var findBlog = db.Blogs.FirstOrDefault(a => a.Id == blog.Id);
                findBlog.Title = blog.Title;
                findBlog.Picture = blog.Picture;
                findBlog.Description = blog.Description;
                findBlog.Content = blog.Content;
                findBlog.CategoryId = blog.CategoryId;
                findBlog.IsHomePage = blog.IsHomePage;
                findBlog.IsOk = blog.IsOk;

                db.Entry(findBlog).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index",new {@message="Başarıyla Güncellendi." });
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", blog.CategoryId);
            return View(blog);
        }

        // GET: Blogs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Blog blog = await db.Blogs.FindAsync(id);
            if (blog == null)
            {
                return HttpNotFound();
            }
            return View(blog);
        }

        // POST: Blogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Blog blog = await db.Blogs.FindAsync(id);
            db.Blogs.Remove(blog);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
