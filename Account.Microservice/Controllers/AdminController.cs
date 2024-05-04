using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        //Create a new admin user
        [HttpPost]
        public IActionResult CreateAdmin()
        {
            return View();
        }

        //Get admin info
        [HttpGet]
        public IActionResult GetAdmin() 
        {
            return View();
        }

        //Get all admins
        [HttpGet]
        public IQueryable<IActionResult> GetAdminList() 
        {
            return View();
        }

        //Edit admin user
        [HttpPut]
        public IActionResult EditAdmin() 
        {
            return View();
        }

        //Delete admin user
        [HttpDelete]
        public IActionResult DeleteAdmin() 
        {
            return View();
        }
    }
}
