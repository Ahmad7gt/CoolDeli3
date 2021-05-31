using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductApi.Areas.Context.Data;
using ProductApi.Data;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductContext _context;

        public ProductController(ProductContext productContext)
        {
            _context = productContext;
        }

        [Route("/GetAllProducts")]
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _context.products.ToList();

            return Ok(products);

        }

        [Route("/GetProductDetails")]
        [HttpGet]
        public IActionResult GetProductDetails(int id)
        {
            var productDetails = _context.products.Where(x => x.Id == id).FirstOrDefault().Details;
            return Ok(productDetails);
        }


    }
   



}
