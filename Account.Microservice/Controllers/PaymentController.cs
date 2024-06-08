using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        //Create new payment
        [HttpPost]
        public async Task<ActionResult> CreatePayment([FromBody] PaymentModel payment)
        {
            return Ok();
        }

        //Get payment info
        [HttpGet]
        public async Task<ActionResult> GetPayment() 
        {
            return Ok();
        }

        //Get all list of payments
        //[HttpGet]
        //public async Task<IQueryable<ActionResult>> GetAllPayment() 
        //{
           // return View();
        //}

        //Edit payment info
        [HttpPut]
        public async Task<ActionResult> EditPayment() 
        {
            return Ok();    
        }

        //Delete payment info
        [HttpDelete]
        public async Task<ActionResult> DeletePayment() 
        {
            return Ok();
        }
    }
}
