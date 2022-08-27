using Autofac;
using Ecommerce.Common;
using Ecommerce.Store.Exceptions;
using Ecommerce.Web.Models;
using Ecommerce.Web.Areas.Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Ecommerce.Web.Areas.Admin.Models;

namespace Ecommerce.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class ProductSubscriptionNotificationController : Controller
    {
        private readonly ILogger<ProductSubscriptionNotificationController> _logger;
        private ILifetimeScope _scope;

        public ProductSubscriptionNotificationController(ILogger<ProductSubscriptionNotificationController> logger, ILifetimeScope scope)
        {
            _logger = logger;
            _scope = scope;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetSubscriptionNotifications()
        {
            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfAllSubscriptionNotificationsModel>();

            return Json(model.GetAllSubscriptionNotifications(dataTableModel));
        }


     
        public IActionResult ArchiveNotification(Guid id)
        {
            try
            {
                var model = _scope.Resolve<ListOfAllSubscriptionNotificationsModel>();
                model.ArchiveNotification(id);

                TempData["ResponseMessage"] = "Successfully archived...!!!.";
                TempData["ResponseType"] = ResponseTypes.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                TempData["ResponseMessage"] = "There was a problem in archiving.";
                TempData["ResponseType"] = ResponseTypes.Danger;
            }

            return RedirectToAction("Index");
        }
        public IActionResult ShowArchivedSubscriptions()
        {
            return View();
        }

        public JsonResult GetAllArchivedSubscriptions()
        {
            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfAllArchivedSubscriptionsModel>();

            return Json(model.GetAllArchivedSubscriptions(dataTableModel));
        }

        public IActionResult Edit(Guid id)
        {
            var model = _scope.Resolve<ProductSubscriptionEditModel>();
            model.LoadData(id);

            return View(model);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Edit(ProductSubscriptionEditModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);

                try
                {
                    model.EditProductSubscriptionNotification();

                    TempData["ResponseMessage"] = "Successfully updated contact form data.";
                    TempData["ResponseType"] = ResponseTypes.Success;

                    return RedirectToAction("Index");
                }
                catch (DuplicateException ioe)
                {
                    _logger.LogError(ioe, ioe.Message);

                    TempData["ResponseMessage"] = ioe.Message;
                    TempData["ResponseType"] = ResponseTypes.Danger;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                    TempData["ResponseMessage"] = "There was a problem in updating contact form.";
                    TempData["ResponseType"] = ResponseTypes.Danger;
                }
            }

            return View(model);
        }

        public IActionResult EditArchived(Guid id)
        {
            var model = _scope.Resolve<ProductSubscriptionEditModel>();
            model.LoadData(id);

            return View(model);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var model = _scope.Resolve<ListOfAllSubscriptionNotificationsModel>();
                model.DeleteSubscriptionNotification(id);

                TempData["ResponseMessage"] = "Successfully deleted...!!!.";
                TempData["ResponseType"] = ResponseTypes.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                TempData["ResponseMessage"] = "There was a problem in archiving.";
                TempData["ResponseType"] = ResponseTypes.Danger;
            }

            return RedirectToAction("ShowArchivedSubscriptions");
        }


    }
}

