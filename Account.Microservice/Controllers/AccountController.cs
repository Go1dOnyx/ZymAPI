using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Contorller]")]
    [ApiController]
    public class AccountController : Controller
    {
        //Create new user
        [HttpPost]
        public IActionResult CreateUser()
        {
            //validate here or either on the service folder section if account exist or not.
            return View();
        }

        //Get user information 
        [HttpGet]
        public IActionResult GetUser()
        {
            return View();
        }

        //Get all users
        [HttpGet]
        public IQueryable<IActionResult> GetAllUsers() //IQueryable
        {
            return View();
        }

        //Update user info
        [HttpPut]
        public IActionResult UpdateUser()
        {
            return View();
        }

        //Delete existing user
        [HttpDelete]
        public IActionResult DeleteUser()
        {
            return View();
        }
    }
}
