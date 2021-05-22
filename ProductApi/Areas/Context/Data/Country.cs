using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Areas.Context.Data
{
    public class Country
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool  ImportTax { get; set; }

        public List<Product> products { get; set; }
    }
}
