using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Areas.Context.Data
{
    public class Product
    {
        public Guid Id { get; set; }

        public string  Name { get; set; }

        public string Details { get; set; }
        public string Price { get; set; }

        public string Image { get; set; }

        public bool Instock { get; set; }


        public bool Enabled { get; set; }

        public Country country { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual List<Supplier> Suppliers { get; set; }







    }
}
