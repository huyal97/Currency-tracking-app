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
    [Route("[controller]/[action]")]
    public class CurrencyController : Controller
    {

        private readonly ICurrencyRepository _currenciesRepository;
        

        public CurrencyController(ICurrencyRepository currenciesRepository)
        {
            _currenciesRepository = currenciesRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            

            return View();
        }
        [HttpGet]
        public IActionResult GetLastCurrencies()
        {
            Currencies currencies = _currenciesRepository.ListAll();
            
            return View(currencies);
        }

        
    }
}
