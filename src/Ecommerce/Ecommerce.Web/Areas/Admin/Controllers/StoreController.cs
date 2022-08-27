using Autofac;
using Ecommerce.Common;
using Ecommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StoreController : Controller
    {
        private readonly ILifetimeScope _lifetimeScope;
        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger,
                                  ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult All()
        {
            return View();
        }
        public JsonResult GetStores()
        {
            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _lifetimeScope.Resolve<StoreListModel>();
            return Json(model.GetPagedStores(dataTableModel));
        }
        [HttpPost]
        public object StoreDelete(string id)
        {
            var model = _lifetimeScope.Resolve<StoreModel>();
            try
            {
                model.Delete(new Guid(id));
                return new { Code = 200, Message = "Success" };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };

        }
    }
}
