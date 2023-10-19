using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebUI.Models;

namespace WebUI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext  (DbContextOptions options) :base (options){

        }
        public DbSet<Banner> Banners {get; set;}
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Categry> Categries { get; set; }
        public DbSet<About> Abouts { get; set; }

    }
}