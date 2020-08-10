using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Basliq { get; set; }
        public string Aciqlama { get; set; }
        public string Unvan { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Yer { get; set; }
    }
}