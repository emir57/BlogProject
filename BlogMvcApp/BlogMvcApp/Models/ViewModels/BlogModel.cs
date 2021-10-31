using BlogMvcApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models.ViewModels
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime AddingDate { get; set; }
        public bool IsOk { get; set; }
        public bool IsHomePage { get; set; }

        public string CategoryName { get; set; }
        public string Content { get; set; }

    }
}