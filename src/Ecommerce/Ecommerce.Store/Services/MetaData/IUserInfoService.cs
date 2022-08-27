namespace Ecommerce.Store.Services.MetaData
{
    public interface IUserInfoService
    {
        string GetUserId();
        string GetUserEmailAddress();
        string GetUserMobileNumber();
    }
}