using Microsoft.AspNetCore.Mvc;

namespace Product.Microservice.Controllers
{
    public class CategoryController : Controller
    {
        [HttpPost]
        public async Task<ActionResult> CreateCategory()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> GetCategory(int categoryID) 
        {
            return View();
        }
    }
}
