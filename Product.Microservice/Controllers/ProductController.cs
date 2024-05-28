using Microsoft.AspNetCore.Mvc;
using Product.Microservice.Models;

namespace Product.Microservice.Controllers
{
    public class ProductController : Controller
    {
        //Create a new product
        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody]Products item)
        {
            return View();
        }

        //Get product by id
        [HttpGet]
        public async Task<ActionResult> GetProduct(int productID) 
        {
            return View();
        }

        //Get all products
        [HttpGet]
      ///  public async Task<IQueryable<ActionResult>> GetAllProducts() 
      //  {
       //     return View();
      //  }

        [HttpPut]
        public async Task<ActionResult> EditProduct(int productID) 
        {
            return View();
        }
        
        [HttpDelete]
        public async Task<ActionResult> DeleteProduct(int productID) 
        {
            return View();
        }
    }
}
