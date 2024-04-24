using Microsoft.AspNetCore.Mvc;

namespace ZymAPI.Controllers
{
    public class AccountController : Controller
    {
        //Create new user
        public IActionResult CreateUser()
        {
            return View();
        }

        //Get user information 
        public IActionResult GetUser() 
        {
            return View();
        }

        //Get all users
        public List<IActionResult> GetAllUsers() 
        {
            return View();
        }

        //Update user info
        public IActionResult UpdateUser() 
        {
            return View();
        }

        //Delete existing user
        public IActionResult DeleteUser() 
        {
            return View();
        }

    }
}
