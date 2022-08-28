using System.Diagnostics;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserInfoService _userInfo;

        public HomeController(ILogger<HomeController> logger, IUserInfoService userInfo)
        {
            _logger = logger;
            _userInfo = userInfo;
        }

        public IActionResult Index()
        {
            var userId = _userInfo.GetUserId();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DataDeletion()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}