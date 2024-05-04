using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Contorller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        //Create new payment
        [HttpPost]
        public IActionResult CreatePayment()
        {
            return View();
        }

        //Get payment info
        [HttpGet]
        public IActionResult GetPayment() 
        {
            return View();
        }

        //Get all list of payments
        [HttpGet]
        public IQueryable<IActionResult> GetAllPayment() 
        {
            return View();
        }

        //Edit payment info
        [HttpPut]
        public IActionResult EditPayment() 
        {
            return View();    
        }

        //Delete payment info
        [HttpDelete]
        public IActionResult DeletePayment() 
        {
            return View();
        }
    }
}
