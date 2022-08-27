using Ecommerce.Membership.Services;
using System.Web;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Membership.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Ecommerce.Membership.DbContexts;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace Ecommerce.Store.Services.MetaData
{
    public class UserInfoService : IUserInfoService
    {
        private readonly IHttpContextAccessor _httpContext;
        public UserInfoService(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public string GetUserId()
        {
            if(_httpContext.HttpContext.User?.Identity.IsAuthenticated == true)
                return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            else
                return null;
        }

        public string GetUserEmailAddress()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.Email);
        }

        public string GetUserMobileNumber()
        {
            if (_httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.MobilePhone) != null)
                return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.MobilePhone);
            else
                return "";
        }
    }
}
