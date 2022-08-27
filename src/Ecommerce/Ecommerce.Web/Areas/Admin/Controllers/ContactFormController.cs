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
    public class ContactFormController : Controller
    {
        private readonly ILogger<ContactFormController> _logger;
        private ILifetimeScope _scope;

        public ContactFormController(ILogger<ContactFormController> logger, ILifetimeScope scope)
        {
            _logger = logger;
            _scope = scope;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetContactMessages()
        {
            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfAllContactMessagesModel>();

            return Json(model.GetAllContactMessages(dataTableModel));
        }

        public IActionResult Edit(Guid id)
        {
            var model = _scope.Resolve<ContactFormEditModel>();
            model.LoadData(id);

            return View(model);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Edit(ContactFormEditModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);

                try
                {
                    model.EditContactForm();

                    TempData["ResponseMessage"] = "Successfuly updated contact form data.";
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

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var model = _scope.Resolve<ListOfAllContactMessagesModel>();
                model.DeleteContactForm(id);

                TempData["ResponseMessage"] = "Successfuly deleted contact message.";
                TempData["ResponseType"] = ResponseTypes.Success;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                TempData["ResponseMessage"] = "There was a problem in deleteing contact message.";
                TempData["ResponseType"] = ResponseTypes.Danger;
            }

            return RedirectToAction("Index");
        }


    }
}

