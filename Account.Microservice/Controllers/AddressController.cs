using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Contorller]")]
    [ApiController]
    public class AddressController : Controller
    {
        //Create new address
        [HttpPost]
        public IActionResult CreateAddr()
        {
            return View();
        }

        //Get address info
        [HttpGet]
        public IActionResult GetAddr() 
        {
            return View();
        }

        //Get all addresses
        [HttpGet]
        public IQueryable<IActionResult> GetAllAddr() 
        {
            return View();
        }

        //Edit address
        [HttpPut]
        public IActionResult EditAddr()
        {
            return View();
        }

        //Delete address
        [HttpDelete]
        public IActionResult DeleteAddr()
        {
            return View();
        }
    }
}
