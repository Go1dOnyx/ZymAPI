using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Contorller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        //Create new payment
        [HttpPost]
        public async Task<ActionResult> CreatePayment([FromBody] PaymentModel payment)
        {
            return View();
        }

        //Get payment info
        [HttpGet]
        public async Task<ActionResult> GetPayment() 
        {
            return View();
        }

        //Get all list of payments
        [HttpGet]
        //public async Task<IQueryable<ActionResult>> GetAllPayment() 
        //{
           // return View();
        //}

        //Edit payment info
        [HttpPut]
        public async Task<ActionResult> EditPayment() 
        {
            return View();    
        }

        //Delete payment info
        [HttpDelete]
        public async Task<ActionResult> DeletePayment() 
        {
            return View();
        }
    }
}
