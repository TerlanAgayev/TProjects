using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelProject1.Models.Classlar
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Istifadeci { get; set; }
        public string Parol { get; set; }
    }
}