using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Contorller]")]
    [ApiController]
    public class AccountController : Controller
    {
        //Create new user
        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody]UserModel user)
        {
            //validate here or either on the service folder section if account exist or not.
            return Ok(user);
        }

        //Get user information 
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser()
        {
            return Ok();
        }

        //Get all users
        //[HttpGet("getusers/{id}")]
        //public async Task<IQueryable<ActionResult>> GetAllUsers() //IQueryable
        //{
            //return View();
        //}

        //Update user info
        [HttpPut]
        public async Task<ActionResult> UpdateUser()
        {
            return View();
        }

        //Delete existing user
        [HttpDelete]
        public async Task<ActionResult> DeleteUser()
        {
            return View();
        }
    }
}
