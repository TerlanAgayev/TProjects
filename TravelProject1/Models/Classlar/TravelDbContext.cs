using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelProject1.Models.Classlar
{
    public class TravelDbContext:DbContext
    {
        public DbSet<Admin>  Admins { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Haqqimizda> Haqqimizdas { get; set; }

    }
}