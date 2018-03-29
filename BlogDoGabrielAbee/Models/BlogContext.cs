using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogDoGabrielAbee.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BlogContext() : base ("DefaultConnection")
        {

        }


    }
}