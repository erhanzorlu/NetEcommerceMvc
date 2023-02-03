using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NetECommerce.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetEcommerce.DAL.Context
{
    public class ProjectContext : IdentityDbContext<AppUser, AppUserRole, int>
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        //FakeData
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //AppUser




            //Product


            //Categories
            List<Category> categories = new List<Category>
           {
               new Category{Id=1,CategoryName="Teknoloji",Description="teknolojik ürünler",Status=NetECommerce.Entity.Enum.Status.Inserted},
               new Category{Id=2,CategoryName="Giyim",Description="yazlık kışlık giyim ürünleri",Status=NetECommerce.Entity.Enum.Status.Inserted}
           };

            //Products
            List<Product> products = new List<Product>() 
            { 
                new Product {Id=1, ProductName="MSI",UnitPrice=20000,UnitsInStock=50,CategoryId=categories.Where(x=>x.CategoryName=="Teknoloji").FirstOrDefault().Id,Status=NetECommerce.Entity.Enum.Status.Inserted},
            new Product {Id=2,ProductName="Nike Ayakkabı",UnitPrice=2000,UnitsInStock=150,CategoryId=categories.Where(x=>x.CategoryName=="Giyim").FirstOrDefault().Id, Status = NetECommerce.Entity.Enum.Status.Inserted}
            };

            builder.Entity<Product>().HasData(products);
            builder.Entity<Category>().HasData(categories);



            base.OnModelCreating(builder);
        }

    }
}
