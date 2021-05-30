using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.Areas.Context.Data;
using Microsoft.EntityFrameworkCore;


namespace ProductApi.Data
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> products { get; set; }
   

        public DbSet<ProductType> productTypes { get; set; }

      

        

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
