using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string IstifadeciAd { get; set; }
        public string Mail { get; set; }
        public string CommentString { get; set; }
        public int Blogid { get; set; }
        public virtual Blog Blog { get; set; }
    }
}