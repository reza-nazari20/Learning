using Filter_Authorization.Models;
using Filter_Authorization.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Filter_Authorization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[CacheResourceFilter]
        //[TypeFilter(typeof(CacheResourceFilter))]
        [AddHeaderFilter]
        public IActionResult Index()
        {
            return View("Index",$"This Is a Text and Gnerated at : { DateTime.Now.TimeOfDay}");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [AuthorizeActionFilter("Admin")]
        public IActionResult Edite()
        {
            return View();
        }

        [AuthorizeActionFilter("Admin")]
        public IActionResult List()
        {
            return View();
        }

        [HttpPost]
        [ValidateModelAttribute]
        public IActionResult ProductEdite([FromForm] ProductViewmodel product)
        {
            return View();
        }

        [TypeFilter(typeof(CustomExeptionFilter))]
        public IActionResult Error()
        {
            throw new NotImplementedException();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
