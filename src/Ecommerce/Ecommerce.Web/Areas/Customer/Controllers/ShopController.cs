using Autofac;
using Ecommerce.Membership.Entities;
using Ecommerce.Web.Areas.Customer.Models;
using Ecommerce.Web.Areas.Customer.Models.ShopAccountModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using System.Net;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Common;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Ecommerce.Web.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ShopController : Controller
    {
        #region Dependency Injection

        private readonly ILifetimeScope _scope;
        private readonly ILogger<ShopController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserInfoService _userInfo;
        private readonly IStoreInfoService _storeInfo;
        private readonly UserManager<ApplicationUser> _userManager;

        public ShopController(ILogger<ShopController> logger,
            ILifetimeScope scope,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IUserInfoService userInfo,
            IStoreInfoService storeInfo)
        {
            _scope = scope;
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _userInfo = userInfo;
            _storeInfo = storeInfo;
        }

        #endregion
        public IActionResult Index(ShopIndexModel model)
        {
            //var temp = _scope.Resolve<CreateEmailNotificationFile>();
            //temp.getCustomerName();



            //var storeId = _storeInfo.GetStoreId();
            model.Resolve(_scope);
            var storeId = _storeInfo.GetStoreId();
            //var storeId="C1457E73-ABC4-42A4-AF2F-CE7CA1C65FF1";
            model.setStoreId(storeId);
            return View(model);
        }
        
        [HttpPost]
        public object infiniteProduct(string steps, string volume)
        {
            var model = _scope.Resolve<ShopIndexModel>();
            var storeId = _storeInfo.GetStoreId();
            //var storeId = "C1457E73-ABC4-42A4-AF2F-CE7CA1C65FF1";
            model.setStoreId(storeId);
            try
            {
                var products = model.loadFeatureProduct(Int32.Parse(steps), Int32.Parse(volume));
                return new { Code = 200, Message = "Success", Products = products };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };
        }
        
        public IActionResult Category(string Id)
        {
            var model = _scope.Resolve<CategoryModel>();
            model.setCategoryId(new Guid(Id));
            model.getCurrentCategory();


            return View(model);
        }
        
        [HttpPost]        
        public object infiniteCategoryBasedProduct(string steps, string volume, string CategoryId)
        {
            var model = _scope.Resolve<CategoryModel>();
            var categoryId = new Guid(CategoryId);

            model.setCategoryId(categoryId);
            try
            {
                var products = model.LoadProducts(Int32.Parse(steps), Int32.Parse(volume));
                return new { Code = 200, Message = "Success", Products = products };
            }
            catch (Exception ioe)
            {
                _logger.LogError(ioe, ioe.Message);
            }
            return new { Code = 400, Message = "Unsuccessful" };
        }
        
        public IActionResult ShopGrid()
        {
            var storeId = _storeInfo.GetStoreId();
            var model = _scope.Resolve<ProductModel>();
            model.setStoreId(new Guid(storeId));
            model.GetAllProducts();
            return View(model);
        }

        public JsonResult GetProducts(ShopModel obj)
        {

            var storeId = _storeInfo.GetStoreId();
            var model = _scope.Resolve<ProductModel>();
            model.setStoreId(new Guid(storeId));
            return Json(model.GetFilteredProducts(obj.SortOrder, obj.pageIndex));
        }

        public IActionResult Product(Guid Id)
        {
            var model = _scope.Resolve<ProductDetailsModel>();
            model.GetProductById(Id);
            return View(model);
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult CheckOut()
        {
            var model = _scope.Resolve<CartModel>();
            model.GetCartItems();
            return View(model);
        }

        public IActionResult ShoppingCart() // no param
        {
            var model = _scope.Resolve<CartModel>();
            model.GetCartItems();
            return View(model);
        }

        public JsonResult DeleteProduct(Guid Id)
        {
            try
            {
                var model = _scope.Resolve<CartModel>();
                model.DeleteProduct(Id);
                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(new { success = true, message = "ok", status = 200 });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { success = false, message = "error", status = 500 });
            }

        }

        public IActionResult BlogDetails()
        {
            return View();
        }
        
        public IActionResult ShopDetails()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Wishlist(WishlistAddModel model, Guid Id)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);
                try
                {
                    model.CreateWishlist(Id);
                    //TempData["ResponseMessage"] = "Successfully added a new product.";
                    //TempData["ResponseType"] = ResponseTypes.Success;
                    Response.StatusCode = (int)HttpStatusCode.OK;
                    return Json(new { success = true, message = "ok", status = 200 });

                }
                catch (Exception ioe)
                {
                    _logger.LogError(ioe, ioe.Message);

                    //TempData["ResponseMessage"] = ioe.Message;
                    //TempData["ResponseType"] = ResponseTypes.Danger;

                    Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    return Json(new { success = false, message = "error", status = 500 });
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Wishlist()
        {
            var model = _scope.Resolve<WishlistModel>();
            model.GetAllWishlists();
            return View(model);
        }

        #region Register Methods
        public async Task<IActionResult> Register(string returnUrl = null)
        {
            var model = _scope.Resolve<RegisterModel>();
            model.ReturnUrl = returnUrl;
            model.ExternalLogins = (await _signInManager
                .GetExternalAuthenticationSchemesAsync())
                .ToList();

            return View(model);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            var storeId = _storeInfo.GetStoreId();
            model.StoreId = storeId;
            model.ReturnUrl ??= Url.Content("~/Customer/Shop/");
            model.ExternalLogins = (await _signInManager
                .GetExternalAuthenticationSchemesAsync())
                .ToList();
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    StoreId = model.StoreId
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Customer");

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = model.ReturnUrl },
                        protocol: Request.Scheme);

                    //await _emailSender.SendEmailAsync(model.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToAction("index", "Shop", new { email = model.Email });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(model.ReturnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        #endregion

        #region Login Methods
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            var model = _scope.Resolve<LoginModel>();
            if (!string.IsNullOrEmpty(model.ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, model.ErrorMessage);
            }

            returnUrl ??= Url.Content("~/Customer/Shop/");

            // Clear the existing external cookie to ensure a clean login process
            await _signInManager.SignOutAsync();
            //await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            model.ReturnUrl = returnUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            model.ReturnUrl ??= Url.Content("~/Customer/Shop/");

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var userEmail = model.Email;
                var userStoreId = _userManager.FindByEmailAsync(userEmail).Result.StoreId;
                var currentStoreId = _storeInfo.GetStoreId();

                if (userStoreId == currentStoreId)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User logged in.");
                        return LocalRedirect(model.ReturnUrl);
                    }
                    if (result.RequiresTwoFactor)
                    {
                        return RedirectToPage("./LoginWith2fa", new { ReturnUrl = model.ReturnUrl, RememberMe = model.RememberMe });
                    }
                    if (result.IsLockedOut)
                    {
                        _logger.LogWarning("User account locked out.");
                        return RedirectToPage("./Lockout");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                        return View(model);
                    }
                }
            }
            return View(model);
        }
        #endregion

        #region Facebook Login

        [AllowAnonymous]
        public IActionResult FacebookLogin()
        {
            var model = _scope.Resolve<LoginModel>();
            //var redirectUrl = Url.Action("Index", "Shop");
            var redirectUrl = Url.Action("FacebookResponse");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> FacebookResponse(RegisterModel model)
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction(nameof(Login));

            var userEmail = info.Principal.FindFirst(ClaimTypes.Email).Value;
            var userStoreId = _userManager.FindByEmailAsync(userEmail).Result.StoreId;
            var currentStoreId = _storeInfo.GetStoreId();

            if (userStoreId == currentStoreId)
            {
                var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);

                string[] userInfo =
                    {
                    info.Principal.FindFirst(ClaimTypes.Name).Value,
                    info.Principal.FindFirst(ClaimTypes.Email).Value,
                    info.Principal.Identities.Select(info => info.FindFirst(userStoreId)).ToString()
                };

                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return RedirectToAction("Index", "Shop");
                }
                else
                {
                    var storeId = _storeInfo.GetStoreId();
                    model.StoreId = storeId;
                    var user = new ApplicationUser
                    {
                        Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = info.Principal.FindFirst(ClaimTypes.Email).Value,
                        StoreId = _userManager.FindByEmailAsync(userEmail).Result.StoreId
                    };

                    var identResult = await _userManager.CreateAsync(user);
                    if (identResult.Succeeded)
                    {
                        _logger.LogInformation("User created.");
                        identResult = await _userManager.AddLoginAsync(user, info);
                        if (identResult.Succeeded)
                        {
                            _logger.LogInformation("User logged in.");
                            await _signInManager.SignInAsync(user, false);
                            return RedirectToAction("Index", "Shop");
                        }
                    }
                    return RedirectToAction("Index", "Shop");
                }
            }
            else
                return RedirectToAction("Index", "Shop");
        }

        #endregion

        #region Logout
        [HttpPost]
        public async Task<IActionResult> Logout(string returnUrl = null)
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        #endregion

        #region DeleteWishlist
        [HttpPost]
        public IActionResult DeleteWishlist(Guid Id)
        {
            try
            {
                var model = _scope.Resolve<WishlistModel>();
                model.DeleteWishlist(Id);

                //TempData["ResponseMessage"] = "Successfuly
                //deleted course.";
                //TempData["ResponseType"] = ResponseTypes.Success;

                Response.StatusCode = (int)HttpStatusCode.OK;
                return Json(new { success = true, message = "ok", status = 200 });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                //TempData["ResponseMessage"] = "There was a problem in deleteing course.";
                //TempData["ResponseType"] = ResponseTypes.Danger;
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { success = false, message = "error", status = 500 });
            }
            
            return RedirectToAction("Index");
        }
        #endregion

        #region CreateContactForm
        [ValidateAntiForgeryToken, HttpPost]
        public IActionResult Create(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);
                model.CreateContactForm();
                return RedirectToAction("Contact");
            }
            else
            {
                return RedirectToAction("Contact");
            }
        }

        #endregion

        #region GetMyOrders
        public JsonResult GetMyOrders(string id)//sends all orders to dataTable in View
        {
            var userId = _userInfo.GetUserId();
            var DataTableModel = new DataTablesAjaxRequestModel(Request);
            var model = _scope.Resolve<ListOfMyOrdersModel>();

            return Json(model.GetAllOrders(DataTableModel, new Guid(userId)));
        }
        #endregion

        #region ModalPartialInvoice
        public JsonResult ModalPartialInvoice(int orderNumber)//sends all orderedProducts to partial view Invoice
        {
            try
            {
                var model = _scope.Resolve<OrderedProductsModel>();
                model.GetAllProducts(orderNumber);
                var jsonResult = new { OrderedProducts = model.OrderedProducts };
                return Json(jsonResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return Json(new { success = false, message = "error", status = 500 });
        }

        #endregion

        #region ModalTrackOrder
        public JsonResult ModalTrackOrder(int orderNumber)//sends all orderedProducts to partial view Invoice
        {
            try
            {
                var model = _scope.Resolve<OrderedProductsModel>();
                model.GetAllProducts(orderNumber);
                var jsonResult = new { OrderedProducts = model.OrderedProducts };
                return Json(jsonResult);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return Json(new { success = false, message = "error", status = 500 });
        }

        #endregion

        #region MyOrders
        public IActionResult MyOrders()
        {
            return View();
        }

        #endregion

        #region ReceiveSubscriptionData
        public IActionResult ReceiveSubscriptionData(ProductSubscriptionNotificationModel model)
        {
            if (ModelState.IsValid)
            {
                model.Resolve(_scope);
                model.SaveSubscriptionData();
                return RedirectToAction("Contact");
            }
            else
            {
                return RedirectToAction("Contact");
            }
        }
        #endregion
    }
}
