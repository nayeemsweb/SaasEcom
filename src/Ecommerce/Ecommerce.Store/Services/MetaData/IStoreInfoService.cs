namespace Ecommerce.Store.Services.MetaData
{
    public interface IStoreInfoService
    {
        string GetStoreUrl();
        string GetStoreId();
        string GetHandle(string url);
        string GetMainUrl(string url);
    }
}