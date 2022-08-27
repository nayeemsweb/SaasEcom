using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Ecommerce.Membership.Services
{
    public class SignInManager
        : SignInManager<ApplicationUser>
    {
        public SignInManager(UserManager<ApplicationUser> userManager,
            IHttpContextAccessor contextAccessor,
            IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor,
            ILogger<SignInManager<ApplicationUser>> logger,
            IAuthenticationSchemeProvider schemes,
            IUserConfirmation<ApplicationUser> userConfirmation)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, userConfirmation)
        {

        }
    }
}
