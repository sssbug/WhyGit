using Microsoft.EntityFrameworkCore;
using System;
using Why.Data.Models;

namespace Why.Data
{
    public class WhyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AV3G4UK;database=WhyDb; integrated security=true;"); 
        }
        //public WhyDbContext(DbContextOptions option) : base(option)
        //{

        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Thumb> Thumbs { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        
    }
}
