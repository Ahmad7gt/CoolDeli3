using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductApi.Areas.Context.Data;
using ProductApi.Data;

namespace CoolDeli.Pages.Details
{
    public class DetailsModel : PageModel
    {
        private readonly ProductContext _context;

        [BindProperty]
        public Product _product { get; set; } = new Product();
        public DetailsModel(ProductContext productContext)
        {
            _context = productContext;
        }

        public void OnGet(int productId)
        {
           
                var product = _context.products.Where(x => x.Id ==  (productId)).FirstOrDefault();

                if (product is not null)
                {
                    _product = product;
                }
                else
                {
                    product = null;
                }
            
        }

    }
}
