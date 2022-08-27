using Autofac;
using Ecommerce.Common;
using Ecommerce.Membership.Entities;
using Ecommerce.Store.Exceptions;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Web.Areas.Admin.Models;
using Ecommerce.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
  
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private ILifetimeScope _scope;
        private IWebHostEnvironment _webHostEnvironment;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserInfoService _userInfo;
        private readonly IStoreInfoService _storeInfo;
        private readonly UserManager<ApplicationUser> _userManager;

        public ProductController(ILogger<ProductController> logger,
            ILifetimeScope scope, IWebHostEnvironment webHostEnvironment,
            SignInManager<ApplicationUser> signInManager, IUserInfoService userInfo,
            IStoreInfoService storeInfo, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _scope = scope;
            _webHostEnvironment = webHostEnvironment;
            _signInManager = signInManager;
            _userInfo = userInfo;
            _storeInfo = storeInfo;
            _userManager = userManager;
        }

        public IActionResult index()
        {

            return View();
        }
        public IActionResult All()//for viewing all products
        {
            return View();
        }
        //StoreId must be needed to fetch product from a specific store
        public JsonResult GetProducts()//sends all products to dataTable in View
        {
            var DataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfAllProductsModel>();
            var storeId = _storeInfo.GetStoreId();
            //var storeId = "C1457E73-ABC4-42A4-AF2F-CE7CA1C65FF1";
            var res = Json(model.GetAllProducts(DataTableModel, new Guid(storeId)));
            return res;
        }
        [HttpPost]
        public object ProductFeedVisibility(string id)
        {
            var model = _scope.Resolve<ProductVisibilityChangeModel>();
            try
            {
                model.changeVisibility(new Guid(id));
                return new { Code = 200, Message = "Success" };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };

        }
        [HttpPost]
        public object ProductFeatureAvailability(string id)
        {
            var model = _scope.Resolve<ProductFeatureChangeModel>();
            try
            {
                model.changeFeatureProperty(new Guid(id));
                return new { Code = 200, Message = "Success" };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };

        }
        [HttpPost]
        public object MakeTrash(string id, string StoreId)
        {
            var model = _scope.Resolve<ProductDeleteModel>();
            try
            {
                model.makeTrash(new Guid(id), new Guid(StoreId));
                return new { Code = 200, Message = "Success" };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };

        }
        public IActionResult Trash()//for viewing deleted products
        {
            return View();
        }
        //StoreId must be needed, parameter is StoreId
        public JsonResult GetTrashedProducts()//sends all products to dataTable in View
        {
            var DataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfAllTrashProductsModel>();
            var storeId = _storeInfo.GetStoreId();
            var obj = Json(model.GetAllTrashProducts(DataTableModel, new Guid(storeId)));
            return obj;
        }
        [HttpPost]
        public object RestoreProduct(string productId)
        {
            var model = _scope.Resolve<ProductDeleteModel>();
            try
            {
                model.Restore(new Guid(productId));
                return new { Code = 200, Message = "Success" };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };

        }
        [HttpPost]
        public object ForceDelete(string productId)
        {
            var model = _scope.Resolve<ProductDeleteModel>();
            try
            {
                model.ForceDelete(new Guid(productId));
                return new { Code = 200, Message = "Success" };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };

        }
        //[HttpPost]
        //public object ProductDelete(string id)
        //{
        //    var model = _scope.Resolve<ProductDeleteModel>();
        //    try
        //    {
        //        model.Delete(new Guid(id));
        //        return new { Code = 200, Message = "Success" };
        //    }
        //    catch (Exception ioe)
        //    {
        //        _logger.LogError(ioe, ioe.Message);
        //    }
        //    return new { Code = 400, Message = "Unsuccessful" };

        //}
        public IActionResult Add()
        {
            var model = _scope.Resolve<ProductAddModel>();
            return View(model);
        }

        public IActionResult Edit(Guid Id)
        {
            var model = _scope.Resolve<ProductEditModel>();
            model.LoadData(Id);

            return View(model);
        }
        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Edit(ProductEditModel model)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);
                var storeId = _storeInfo.GetStoreId();
                model.setStoreId(new Guid(storeId));
                try
                {
                    var imageUrls = model?.ImageUrlsParam?.Split(",");
                    List<string> validImages = new List<string>();
                    if (imageUrls == null)
                    {
                        validImages.Add("Files/NoImageFound.png");
                    }
                    else
                    {
                        foreach (var imageUrl in imageUrls)
                        {
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath,
                                               imageUrl);
                            var validPath = imageUrl.Replace("\\", "/");
                            if(validPath != "Files/NoImageFound.png")
                                validImages.Add(validPath);
                        }
                    }
                    model?.EditProduct(validImages);
                    TempData["Msg"] = $"{model?.Name} is successfully updated ";
                    return RedirectToAction("All");
                }
                catch (DuplicateException ioe)
                {
                    _logger.LogError(ioe, ioe.Message);

                    TempData["Msg"] = ioe.Message;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);
                    TempData["Msg"] = "Product could not be updated due to some error";
                }

            }
            return View(model);
        }

        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Add(ProductAddModel model)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);
                var storeId = _storeInfo.GetStoreId();
                model.setStoreId(new Guid(storeId));
                try
                {
                    var imageUrls = model?.ImageUrlsParam?.Split(",");

                    var categoriesId = model?.CategoriesId?.Split(",");

                    List<string> validImages = new List<string>();

                    if (imageUrls == null)
                    {
                        validImages.Add("Files/NoImageFound.png");
                    }
                    else
                    {
                        foreach (var imageUrl in imageUrls)
                        {
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath,
                                               imageUrl);
                            var validPath = imageUrl.Replace("\\", "/");
                            validImages.Add(validPath);

                        }
                    }
                    if (categoriesId == null)
                        model?.CreateProduct(validImages, new string[] { "default" });
                    else
                        model?.CreateProduct(validImages, categoriesId);

                    TempData["Msg"] = $"{model?.Name} is successfully added ";

                    return RedirectToAction("All");
                }
                catch (DuplicateException ioe)
                {
                    _logger.LogError(ioe, ioe.Message);

                    TempData["Msg"] = ioe.Message;

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, ex.Message);

                    TempData["Msg"] = "Product could not be added due to some error";

                    //TempData.Put<ResponseModel>("ResponseMessage", new ResponseModel
                    //{
                    //    Message = "There was a problem in adding the product.",
                    //    Type = ResponseTypes.Danger
                    //});
                }

            }
            return View(model);
        }

        public JsonResult ImageByProductID(Guid productId)
        {
            var model = new ProductImageModel();
            model.Resolve(_scope);

            var result = model.GetImagesByProductId(productId);

            return Json(result);
        }

    }
}
