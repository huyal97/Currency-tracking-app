using Infrastructure;
using Infrastructure.Data.Migrations;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        
        private readonly IGenericRepository<Currencies> _currenciesRepository;

        public CurrencyController(IGenericRepository<Currencies> currenciesRepository)
        {
            _currenciesRepository = currenciesRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok();
            
        }
    }
}
