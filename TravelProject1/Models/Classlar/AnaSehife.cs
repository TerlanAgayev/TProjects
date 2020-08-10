using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class AnaSehife
    {    
        [Key]
        public int Id { get; set; }
        public string Basliq { get; set; }
        public string  Aciqlama { get; set; }
    }
}