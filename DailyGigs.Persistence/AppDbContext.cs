using DailyGigs.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyGigs.Persistence
{
   public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hustler> Hustlers { get; set; }
        public DbSet<Plug> Plugs { get; set; }
        public DbSet<Gig> Gig { get; set; }

        public DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed data into Category
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1 ,Name="Events"});
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2 ,Name = "Arts/Crafts" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3 ,Name = "Social Media" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4 ,Name = "Content Creation" });



        }

    }
}
