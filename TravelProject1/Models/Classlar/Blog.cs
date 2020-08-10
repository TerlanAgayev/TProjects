using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Basliq { get; set; }
        public DateTime Tarix { get; set; }
        public string Aciqlama { get; set; }
        public string  BlogImg { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}