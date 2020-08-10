using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class BlogComent
    {
        public IEnumerable<Blog> Blog1 { get; set; }
        public IEnumerable<Comment> Comment1 { get; set; }
        public IEnumerable<Blog> SonBlog { get; set; }

    }
}