using Infrastructure;
using Infrastructure.Data.Migrations;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;

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
            _currenyGetter = currencyGetter;
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

            currencies.currencyList.Sort((x, y) => x.Priority.CompareTo(y.Priority));

            return View(currencies);
        }

        
    }
}
