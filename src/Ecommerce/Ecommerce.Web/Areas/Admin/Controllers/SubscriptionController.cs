using Autofac;
using Ecommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubscriptionController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<SubscriptionController> _logger;

        public SubscriptionController(ILogger<SubscriptionController> logger,
                                  ILifetimeScope scope)
        {
            _scope = scope;
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = _scope.Resolve<SubscriptionPlanModel>();
            return View(model);
        }
        [HttpPost]
        public object CreatePlan(string jsonInput="")
       {
            SubscriptionPlanModel model = new SubscriptionPlanModel();
            try
            {
                model = JsonConvert.DeserializeObject<SubscriptionPlanModel>(jsonInput);

                if (model.PlanName == "")
                    return new { Code = 200, Message = "Add Name", Action = false };
                if (model.PlanPrice < 0)
                    return new { Code = 200, Message = "Price can't be negative", Action = false };
                if (model.StorageLimit < 0)
                    return new { Code = 200, Message = "Storage can't be negative", Action = false };
                if (model.ProductUploadLimit < 0)
                    return new { Code = 200, Message = "Ulpoad limit can't be negative", Action = false };
                if (model.PlanColor == "")
                    return new { Code = 200, Message = "Assign card color", Action = false };
            }
            catch(Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
                return new { Code = 200, Message = "Input Error", Action = false };
            }



            try
            {                
                model.Resolve(_scope);
                model.AddPlan();
                return new { Code = 200, Message = "Plan Added", Action=true};
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 404, Message = "Plan Add Error", Action=false };
        }
        [HttpPost]
        public object DeletePlan(string Id)
        {
            SubscriptionPlanModel model = new SubscriptionPlanModel();
            try
            {
                model.Resolve(_scope);
                model.DeletePlan(new Guid(Id));
                return new { Code = 200, Message = "Plan Deleted", Action = true };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 404, Message = "Plan Delete Error", Action = false };
        }
        [HttpPost]
        public object Edit(string jsonInput = "")
        {
            SubscriptionPlanModel model = new SubscriptionPlanModel();
            try
            {
                model = JsonConvert.DeserializeObject<SubscriptionPlanModel>(jsonInput);

                if (model.PlanName == "")
                    return new { Code = 200, Message = "Add Name", Action = false };
                if (model.PlanPrice < 0)
                    return new { Code = 200, Message = "Price can't be negative", Action = false };
                if (model.StorageLimit < 0)
                    return new { Code = 200, Message = "Storage can't be negative", Action = false };
                if (model.ProductUploadLimit < 0)
                    return new { Code = 200, Message = "Ulpoad limit can't be negative", Action = false };
                if (model.PlanColor == "")
                    return new { Code = 200, Message = "Assign card color", Action = false };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
                return new { Code = 200, Message = "Input Error", Action = false };
            }



            try
            {
                model.Resolve(_scope);
                model.Id = new Guid(model.PlanId);
                model.EditPlan();
                return new { Code = 200, Message = "Plan Updated", Action = true };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 404, Message = "Plan Update Error", Action = false };
        }
        [HttpGet]
        public object GetPlan(string Id)
        {
            
            try
            {
                if (Id != null)
                {
                    SubscriptionPlanModel model = new SubscriptionPlanModel();
                    model.Resolve(_scope);
                    var ResultedPlan = model.GetPlan(new Guid(Id));
                    return new { Code = 200, Message = "Plan fetched", Plan=ResultedPlan};
                }
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 404, Message = "Plan Fetch Error" };
        }
    }
}
