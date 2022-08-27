using Autofac;
using Ecommerce.Common;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly ILifetimeScope _lifetimeScope;
        private readonly ILogger<CategoryController> _logger;
        private IWebHostEnvironment _webHostEnvironment;
        private readonly IStoreInfoService _storeInfo;

        public CategoryController(ILogger<CategoryController> logger,
                                  ILifetimeScope lifetimeScope,
                                  IWebHostEnvironment env, IStoreInfoService storeInfo)
        {
            _lifetimeScope = lifetimeScope;
            _logger = logger;
            _webHostEnvironment = env;
            _storeInfo = storeInfo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult All()
        {
            return View();
        }

        public JsonResult GetCategories()
        {
            var storeId = _storeInfo.GetStoreId();
            var dataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _lifetimeScope.Resolve<CategoryListModel>();
            model.setStoreId(new Guid(storeId));
            return Json(model.GetPagedCategories(dataTableModel));
        }
          
        public IActionResult Create()
        {
            var model = _lifetimeScope.Resolve<CategoryCreateModel>();
            return View(model);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Create(CategoryCreateModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_lifetimeScope);
                var storeId = _storeInfo.GetStoreId();
                model.setStoreId(new Guid(storeId));
                try
                {
                    model.CreateCategory();

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
        

        public IActionResult CreateProduct()
        {
            var model = _lifetimeScope.Resolve<CategoryCreateModel>();
            return View(model);
        }

        public JsonResult GetAllCategories()
        {
            var storeId = new Guid(_storeInfo.GetStoreId());
            var model = _lifetimeScope.Resolve<CategoryListModel>();
            
            return Json(model.GetCategories(storeId));
        }
    }
}
