using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
    }
}
