using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using Autofac;
using Ecommerce.Membership.Entities;
using Ecommerce.Store.Services.MetaData;
using Ecommerce.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;

namespace Ecommerce.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly ILifetimeScope _lifetimeScope;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        //private readonly IEmailService _emailService;
        private readonly IEmailSender _emailSender;
        private readonly IStoreInfoService _storeInfo;

        public AccountController(ILogger<AccountController> logger,
            ILifetimeScope lifetimeScope,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            IStoreInfoService storeInfo
            )
        {
            _logger = logger;
            _lifetimeScope = lifetimeScope;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _storeInfo = storeInfo;
        }

        #region Register
        public async Task<IActionResult> Register(string returnUrl = null)
        {
            var model = _lifetimeScope.Resolve<RegisterModel>();
            model.ReturnUrl = returnUrl;
            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            return View(model);
        }

        [HttpPost, AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            registerModel.ReturnUrl ??= Url.Content("~/");
            registerModel.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync())
                .ToList();

            if (ModelState.IsValid)
            {
                //var user = new ApplicationUser { UserName = model.Email, Email = model.Email };

                var user = new ApplicationUser
                {
                    UserName = registerModel.Email,
                    Email = registerModel.Email,
                    FirstName = registerModel.FirstName,
                    LastName = registerModel.LastName,
                    StoreId = registerModel.StoreId
                };

                var result = await _userManager.CreateAsync(user, registerModel.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Admin");
                    //await _userManager.AddToRolesAsync(user, new string[] { "Vendor", "Distributor" });
                    //await _userManager.AddClaimAsync(user, new Claim("ViewTestPage", "true"));

                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

                    var callbackUrl = Url.Action(
                    "ConfirmEmail",
                    "Account",
                    values: new { area = "", userId = user.Id, code = code, returnUrl = registerModel.ReturnUrl },
                    protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(registerModel.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    //await _emailSender.SendEmailAsync(model.Email, "Confirm your email",
                    //    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToAction("RegisterConfirmation", new { email = registerModel.Email, returnUrl = registerModel.ReturnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(registerModel.ReturnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            return View(registerModel);
        }

        #endregion

        #region Facebook Login

        [AllowAnonymous]
        public IActionResult FacebookLogin()
        {
            var model = _lifetimeScope.Resolve<LoginModel>();
            //var redirectUrl = Url.Content("~/");
            var redirectUrl = Url.Action("FacebookResponse");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            return new ChallengeResult("Facebook", properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> FacebookResponse()
        {
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction(nameof(Login));

            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);

            string[] userInfo =
                {
                    info.Principal.FindFirst(ClaimTypes.Name).Value,
                    info.Principal.FindFirst(ClaimTypes.Email).Value
                };

            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");
                //return Json(userInfo);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var user = new ApplicationUser
                {
                    Email = info.Principal.FindFirst(ClaimTypes.Email).Value,
                    UserName = info.Principal.FindFirst(ClaimTypes.Email).Value
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
                        //return Json(userInfo);
                        return RedirectToAction("Index", "Home");
                    }
                }
                return RedirectToAction("Privacy", "Home");
            }
        }

        #endregion

        #region Built-in Login

        public async Task<IActionResult> Login(string returnUrl = null)
        {
            var model = _lifetimeScope.Resolve<LoginModel>();

            if (!string.IsNullOrEmpty(model.ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, model.ErrorMessage);
            }

            returnUrl ??= Url.Content("~/");

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
            model.ReturnUrl ??= Url.Content("~/");

            model.ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            if (ModelState.IsValid)
            {
                var userEmail = model.Email;
                var userStoreId = _userManager.FindByEmailAsync(userEmail).Result.StoreId;

                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                if (userStoreId == null)
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

        #region RegisterConfirmation
        public async Task<IActionResult> RegisterConfirmation(string email, string returnUrl = null)
        {
            var model = _lifetimeScope.Resolve<RegistrationConfirmationModel>();

            if (email == null)
            {
                return RedirectToAction("Register");
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            model.Email = email;
            // Once you add a real email sender, you should remove this code that lets you confirm the account
            model.DisplayConfirmAccountLink = true;
            if (model.DisplayConfirmAccountLink)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                model.EmailConfirmationUrl = Url.Action(
                    "ConfirmEmail",
                    "Account",
                    values: new { area = "", userId = userId, code = code, returnUrl = returnUrl },
                    protocol: Request.Scheme);
            }

            return View();
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
                return RedirectToAction();
            }
        }
        #endregion

    }
}