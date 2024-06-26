﻿using Microsoft.AspNetCore.Mvc;

namespace Account.Microservice.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AdminController : Controller
    {
        //Create a new admin user
        [HttpPost]
        public async Task<ActionResult> CreateAdmin([FromBody] AdminModel admin)
        {
            return Ok();
        }

        //Get admin info
        [HttpGet]
        public async Task<ActionResult> GetAdmin() 
        {
            return Ok();
        }

        //Get all admins
        //[HttpGet]
       // public async Task<IQueryable<ActionResult>> GetAdminList() 
        //{
            //return View();
        //}

        //Edit admin user
        [HttpPut]
        public async Task<ActionResult> EditAdmin() 
        {
            return Ok();
        }

        //Delete admin user
        [HttpDelete]
        public async Task<ActionResult> DeleteAdmin() 
        {
            return Ok();
        }
    }
}
