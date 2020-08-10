using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class Haqqimizda
    {
        [Key]
        public int Id { get; set; }
        public string ImgUrl { get; set; }
        public string Aciqlama { get; set; }
    }
}