using Microsoft.AspNetCore.Mvc;
using Account.DataAccess.EF.Context;
using Account.DataAccess.EF.Repositories;
using Account.DataAccess.EF.Models;
using Account.DataAccess.EF.Repositories.Contract;

namespace Account.Microservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        public AccountController(AccountContext dbContext) 
        {
            _accountRepository = new AccountRepository(dbContext);
        }

        //Create new user
        [HttpPost]
        public async Task<ActionResult> CreateUser([FromBody]User user)
        {
            if (ModelState.IsValid && user != null)
            {
                await _accountRepository.CreateAccountAsync(user);

                return Ok();
            }
            
            throw new InvalidOperationException();
        }

        //Get user information 
        [HttpGet("{id}")]
        public async Task<ActionResult> GetUser(Guid userID)
        {
            if (userID != Guid.Empty) 
            {
                User getUser = await _accountRepository.GetAccountByIdAsync(userID);

                return Ok(getUser);
            }

            throw new InvalidOperationException();
        }

        //Get all users
        //[HttpGet("getusers/{id}")]
        [HttpGet("users")]
        public async Task<IQueryable<User>> GetAllUsers() //IQueryable
        {
            IQueryable<User> getAllUsers = await _accountRepository.GetAllAccountsAsync();

            return getAllUsers;
        }

        //Update user info
        [HttpPut("{id}")]
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
