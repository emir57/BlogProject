using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models.Entities
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Icerik { get; set; }
        public DateTime AddingDate { get; set; }
        public bool IsOk { get; set; }
        public bool IsHomePage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}