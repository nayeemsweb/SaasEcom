using Autofac;
using Ecommerce.Common;
using Ecommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscriptionPlanController : Controller
    {
        private readonly ILifetimeScope _lifetimeScope;
        private readonly ILogger<SubscriptionPlanController> _logger;

        public SubscriptionPlanController(ILogger<SubscriptionPlanController> logger,
                                  ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetSubscriptionPlanes()
        {
            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _lifetimeScope.Resolve<SubscriptionPlanListModel>();
            return Json(model.GetPagedSubscriptionPlanes(dataTableModel));
        }

        public IActionResult Create()
        {
            var model = _lifetimeScope.Resolve<SubscriptionPlanCreateModel>();
            return View(model);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Create(SubscriptionPlanCreateModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_lifetimeScope);

                try
                {
                    model.CreateSubscriptionPlan();

                    //TempData.Put<ResponseModel>("ResponseMessage", new ResponseModel
                    //{
                    //    Message = "Successfully added a new student.",
                    //    Type = ResponseTypes.Success
                    //});

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);

                    //TempData.Put<ResponseModel>("ResponseMessage", new ResponseModel
                    //{
                    //    Message = "There was a problem in creating student.",
                    //    Type = ResponseTypes.Danger
                    //});
                }
            }
            return View(model);
        }
        [HttpPost]
        public object SubscriptionPlanDelete(string id)
        {
            var model = _lifetimeScope.Resolve<SubscriptionPlanModel>();
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
