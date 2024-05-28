using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Contorller]")]
    [ApiController]
    public class AddressController : Controller
    {
        //Create new address
        [HttpPost]
        public async Task<ActionResult> CreateAddr(/*[FromBody] AddressModel*/)
        {
            return View();
        }

        //Get address info
        [HttpGet]
        public async Task<ActionResult> GetAddr() 
        {
            return View();
        }

        //Get all addresses
        [HttpGet]
       // public async Task<IQueryable<ActionResult>> GetAllAddr() 
        //{
        //    return View();
        //}

        //Edit address
        [HttpPut]
        public async Task<ActionResult> EditAddr()
        {
            return View();
        }

        //Delete address
        [HttpDelete]
        public async Task<ActionResult> DeleteAddr()
        {
            return View();
        }
    }
}
