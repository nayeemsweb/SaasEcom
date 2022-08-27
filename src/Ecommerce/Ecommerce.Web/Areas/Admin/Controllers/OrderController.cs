using Autofac;
using Ecommerce.Common;
using Ecommerce.Store.Enums;
using Ecommerce.Store.Services;
using Ecommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<OrderController> _logger;
        private readonly IEmailService _emailService;
        public OrderController(ILogger<OrderController> logger, ILifetimeScope scope
                                , IEmailService emailService)

        
        {
            _scope = scope;
            _logger = logger;
            _emailService = emailService;
        }

        [HttpPost]
        public JsonResult Add(string userId)
        {
            var newUserId = Guid.Parse(userId);
            var model = _scope.Resolve<OrderAddModel>();
            try
            {
                var id = model.CreateOrder(newUserId);
                _emailService.CreateEmail("", "", "", "",0);
                Response.StatusCode = (int)HttpStatusCode.OK;
                model.DeleteCart(newUserId);
                return Json(new { success = true, message = "ok", status = 200 });

            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { success = false, message = "error", status = 500 });
            }
        }
        [HttpPost]
        public IActionResult Edit(int orderNumber,string status)
        {
            int orderStatus;
            switch (status)
            {
                
                case "Shipped":
                    orderStatus = 1;
                    break;
                case "Delivered":
                    orderStatus = 2;
                    break;
                case "Canceled":
                    orderStatus = 3;
                    break;
                case "Archived":
                    orderStatus = 4;
                    break;
                default: 
                    orderStatus = 0;
                    break;
            }
            var model = _scope.Resolve<OrderEditModel>();
            try
            {
                model.LoadData(orderNumber);
                model.EditOrder(orderStatus);
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(new { success = true, message = "ok", status = 200 });

            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { success = false, message = "error", status = 500 });
            }
        }
        public JsonResult GetOrders(string id)//sends all orders to dataTable in View
        {
            var DataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfAllOrdersModel>();

            return Json(model.GetAllOrders(DataTableModel, new Guid(id)));
        }
        [HttpPost]
        public JsonResult ModalPartialInvoice(int orderNumber)//sends all orderedProducts to partial view Invoice
        {
            try
            {
                var model = _scope.Resolve<AllOrderedProducts>();
                model.GetAllProducts(orderNumber);
                var jsonResult = new { OrderedProducts = model.OrderedProducts};
                return Json(jsonResult);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return Json(new { success = false, message = "error", status = 500 });
        }

        

        public IActionResult Index()
        {
            return View();
        }
    }
}
