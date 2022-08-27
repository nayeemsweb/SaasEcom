using Autofac;
using Ecommerce.Common;
using Ecommerce.Web.Areas.Admin.Models;

using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;
        private readonly ILifetimeScope _scope;
        private readonly ILogger<HomeController> _logger;


        public HomeController(IWebHostEnvironment webHostEnvironment,
            ILifetimeScope scope, ILogger<HomeController> logger)
        {
            _webHostEnvironment = webHostEnvironment;
            _scope = scope;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Setup(ShopSetupModel model)
        {
            if (ModelState.IsValid)
            {
               
                    try
                    {
                        model.Resolve(_scope);
                        if(model.checkHandle(model.Handle))
                        {
                            model.CreateStore();


                        //HostWorker.triggerHostService = true;
                       // Console.WriteLine(CustomQueue.triggerHostService);
                        }
                        else//for same handle redirect to same page
                          return RedirectToAction("Setup", "Home", new { area = "Admin" });
                        
                    }
                    catch (Exception ioe)
                    {
                        _logger.LogError(ioe, ioe.Message);
                    }
                
            }
            else//for wrong model redirect to same page
                return RedirectToAction("Setup", "Home", new { area = "Admin" });

            //for successful entry to db
            //go to all product page product
            var address = "https://" + model.Handle + ".localhost:7190/Admin/Product/All";
            //Response.Redirect(address);
            return Redirect(address);
            //return RedirectToAction("All", "Product", new { area = "Admin" });

        }
        public IActionResult Setup()
        {
            var model = _scope.Resolve<ShopSetupModel>();
            return View(model);
        }

        [HttpPost]
        public object StoreHandleChecker(string handle)
        {
            var model = _scope.Resolve<ShopSetupModel>();
            try
            {
                var value = model.checkHandle(handle);
                return new { Code = 200, Message = value };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 404, Message = "Unsuccessful" };

        }






    }
}
