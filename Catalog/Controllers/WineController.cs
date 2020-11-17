using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WineController : Controller
    {
        private readonly IWineRepository _wineRepository;

        public WineController(IWineRepository wineRepository)
        {
            _wineRepository = wineRepository;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult GetAllWines()
        {
            return Ok(_wineRepository.GetAllWines());
        }
    }
}
