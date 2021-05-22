using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Areas.Context.Data
{
    public class Supplier
    {

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Url { get; set; }

        public virtual List<Product> Product { get; set; }


    }
}
