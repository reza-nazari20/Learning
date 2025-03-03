using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using Tag_Helper.Models;

namespace Tag_Helper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Home.Index", Name = "indexroute")]
        [HttpPost]
        public IActionResult Index(User user)
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TeamView()
        {
            var TehranGroup = new SelectListGroup() { Name = "تهران" };
            var OtherGroup = new SelectListGroup() { Name = "شهرهای دیگر" };

            TeamViewModel model = new TeamViewModel()
            {
                Teams = new List<SelectListItem>()
                {
                    new SelectListItem {Value="1",Text="پرسپولیس"},
                    new SelectListItem {Value="2",Text="استقلال"},
                    new SelectListItem {Value="3",Text="سپاهان"},
                    new SelectListItem {Value="4",Text="تراکتورسازی"},
                },
                TeamOptionGroup = new List<SelectListItem>()
                {
                    new SelectListItem {Group=TehranGroup,Value="1",Text="پرسپولیس"},
                    new SelectListItem {Group=TehranGroup,Value="2",Text="استقلال"},
                    new SelectListItem {Group=OtherGroup,Value="3",Text="سپاهان"},
                    new SelectListItem {Group=OtherGroup,Value="4",Text="تراکتورسازی"},
                },
                TeamMltipleItem = new List<SelectListItem>()
                {
                    new SelectListItem {Value="1",Text="پرسپولیس"},
                    new SelectListItem {Value="2",Text="استقلال"},
                    new SelectListItem {Value="3",Text="سپاهان"},
                    new SelectListItem {Value="4",Text="تراکتورسازی"},
                }
            };
            return View(model);
        }
    }
}
