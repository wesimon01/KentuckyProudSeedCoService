﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KentuckyProudSeedCo.Service.Controllers
{
    [Authorize]
    [ApiController]
    public class ProductGroupController : ControllerBase
    {
        public IActionResult Index()
        {
            return Ok();
        }

        //public Task<IActionResult> GetAllVegetables() 
        //{
            
            
        //}

        //public Task<I>

        
    }
}