using Autofac;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Web.Areas.Customer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Ecommerce.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<CartController> _logger;
        private readonly IStoreInfoService _storeInfo;
        private readonly IUserInfoService _userInfoService;

        public CartController(ILogger<CartController> logger, ILifetimeScope scope, IStoreInfoService storeInfo, IUserInfoService userInfo)
        {
            _scope = scope;
            _logger = logger;
            _storeInfo = storeInfo;
            _userInfoService = userInfo;
        }
        public JsonResult Add(AddCartModel model)
        {
            model.Resolve(_scope);
            
            model.StoreId = new Guid(_storeInfo.GetStoreId());
            var userId = new Guid(_userInfoService.GetUserId());
            if (userId != null)
            {
                model.UserId = userId;

            }
            else
            {
                model.UserId = new Guid("E7F746E7-8B57-4484-8C7F-195E24BF78E4");
            }

            var result = model.Add();
            return Json(result);
        }
        public JsonResult Edit(EditCartModel model)
        {
            model.Resolve(_scope);
            model.StoreId = new Guid(_storeInfo.GetStoreId());
            var userId = new Guid(_userInfoService.GetUserId());
            if (userId != null)
            {
                model.UserId = userId;

            }
            else
            {
                model.UserId = new Guid("E7F746E7-8B57-4484-8C7F-195E24BF78E4");
            }
            var result = model.Edit();
            return Json(result);
        }



    }
}
