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

            builder.Entity<Product>().HasData(new Product
            {
                Id=1,
               Name = "Ham",

               Details = "Ham is traditionally pork cut from a hog’s hind leg that has been preserved through salting, smoking or curing. However, it’s also possible to get chicken ham, preserved in the same manner. Ham is available in a variety of flavours; some of my favourites are honey-glazed ham, Serrano ham, which is a Spanish variety, Prosciutto, an Italian dry-cured ham and Black Forest ham, a German variety. Ham can be served as is, or baked, boiled or fried. It works well with sweet potatoes, tomatoes and white wine.",

               Price = "90",
               Image = "https://www.hungryforever.com/wp-content/uploads/2015/04/ham_compressed-293x300.jpg",
               Instock =true,
               Enabled=true


            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Salami",

                Details = "Salami is also traditionally pork, or beef, which is seasoned with garlic, minced fat, salt, spices, wines and a range of herbs. Popular salami varieties are chorizo, pepperoni (bet you’ve heard of that one) and Saucisson sec. Salami tastes good on pizzas, in pastas, or simply in sandwiches.",

                Price = "150",
                Image = "https://www.hungryforever.com/wp-content/uploads/2015/04/sliced-salami_compressed-300x214.jpg",
                Instock = true,
                Enabled = true


            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Roast Meat",

                Details = "Either beef or pork is slow roasted, and served as a whole meal. Leftovers are then used in sandwiches and other recipes. Roast beef is the signature national dish of England, so if you’re hosting a British themed party, be sure to serve some up.",

                Price = "120",
                Image = "https://www.hungryforever.com/wp-content/uploads/2015/04/beef_compressed-300x208.jpg",
                Instock = true,
                Enabled = true


            });

            builder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Meatloaf",

                Details = "To prepare traditional meatloaf, beef is ground, mixed with spices and herbs, formed into a loaf shape and then baked or smoked. Meatloaf can also be made from lamb, pork, seafood, veal, venison and poultry. It can be served with rice or potatoes with a side of veggies, or spread on a sandwich.",

                Price = "70",
                Image = "https://www.hungryforever.com/wp-content/uploads/2015/04/meatloaf_compressed-300x201.jpg",
                Instock = true,
                Enabled = true


            });


            builder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Bierwurst",

                Details = "Bierwurst is a German sausage seasoned with pepper, mustard seeds and paprika. It is often eaten as a snack with beer.",

                Price = "50",
                Image = "https://www.hungryforever.com/wp-content/uploads/2015/04/bierwurst_compressed-300x225.jpg",
                Instock = true,
                Enabled = true


            });


        }
    }
}
