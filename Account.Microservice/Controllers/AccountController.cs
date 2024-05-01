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
        public List<IActionResult> GetAllUsers()
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
