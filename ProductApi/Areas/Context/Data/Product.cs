using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Areas.Context.Data
{
    public class Product
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        public string  Name { get; set; }

        public string Details { get; set; }
        public string Price { get; set; }

        public string Image { get; set; }

        public bool Instock { get; set; }


        public bool Enabled { get; set; }


        public virtual ProductType ProductType { get; set; }








    }
}
