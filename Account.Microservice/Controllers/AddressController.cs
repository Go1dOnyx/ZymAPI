using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AddressController : Controller
    {
        //Create new address
        [HttpPost]
        public async Task<ActionResult> CreateAddr(/*[FromBody] AddressModel*/)
        {
            return Ok();
        }

        //Get address info
        [HttpGet]
        public async Task<ActionResult> GetAddr() 
        {
            return Ok();
        }

        //Get all addresses
        //[HttpGet]
       // public async Task<IQueryable<ActionResult>> GetAllAddr() 
        //{
        //    return View();
        //}

        //Edit address
        [HttpPut]
        public async Task<ActionResult> EditAddr()
        {
            return Ok();
        }

        //Delete address
        [HttpDelete]
        public async Task<ActionResult> DeleteAddr()
        {
            return Ok();
        }
    }
}
