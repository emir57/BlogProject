using BlogMvcApp.Models.Entities;
using BlogMvcApp.Models.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace BlogMvcApp.Models.EntityFramework
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> Categories = new List<Category>()
            {
                new Category(){CategoryName="C#"},
                new Category(){CategoryName="Asp.Net MVC"},
                new Category(){CategoryName="Asp.Net WebForm"},
                new Category(){CategoryName="Windows Form"}
            };
            foreach (var item in Categories)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();


            List<Blog> Blogs = new List<Blog>()
            {
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-10),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="1.jpg",CategoryId=1},
                new Blog(){Title="C# Delegates",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-11),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="1.jpg",CategoryId=1},
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-12),IsHomePage=false,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="1.jpg",CategoryId=1},
                new Blog(){Title="C# Generic List Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-15),IsHomePage=false,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="1.jpg",CategoryId=2},
                new Blog(){Title="C# EntityFramework Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-4),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-1),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="2.jpg",CategoryId=2},
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-19),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="2.jpg",CategoryId=3},
                new Blog(){Title="C# Kalıtım Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-20),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="2.jpg",CategoryId=3},
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-12),IsHomePage=false,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="3.jpg",CategoryId=3},
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-13),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="3.jpg",CategoryId=3},
                new Blog(){Title="C# Dependency Injection Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-14),IsHomePage=true,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="3.jpg",CategoryId=4},
                new Blog(){Title="C# Abstract Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-11),IsHomePage=false,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="4.jpg",CategoryId=4},
                new Blog(){Title="C# Delegates Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-5),IsHomePage=true,IsOk=false,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="4.jpg",CategoryId=4},
                new Blog(){Title="C# Interface Hakkında",Description="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında",AddingDate=DateTime.Now.AddDays(-4),IsHomePage=false,IsOk=true,Content="C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında C# Delegates Hakkında.",Picture="4.jpg",CategoryId=4},
            };
            foreach (var item in Blogs)
            {
                context.Blogs.Add(item);
            }
            context.SaveChanges();


            base.Seed(context);
        }
    }
}