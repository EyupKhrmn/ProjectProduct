using System.Reflection;
using DataAccessLayer.Configurations;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class AppContext: DbContext
    {
       
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Product>(new ProductConfigurations());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfigurations());
            
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Category>().HasKey(x => x.CategoryId);

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}