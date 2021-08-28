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
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly IGenericRepository<Currencies> _currenciesRepository;

        public CurrencyController(IGenericRepository<Currencies> currenciesRepository)
        {
            _currenciesRepository = currenciesRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var getter = new CurrencyStarter();

            var currens = getter.GetCurrencies();
            _currenciesRepository.Add(currens);
            return Ok(getter);
            
        }
    }
}
