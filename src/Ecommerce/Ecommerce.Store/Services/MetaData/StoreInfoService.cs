using Ecommerce.Store.Services.MetaData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Store.Entities;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.UnitOfWorks.MetaData;
using EcomStoreEntity = Ecommerce.Store.Entities.Store;

namespace Ecommerce.Store.Services.MetaData
{
    public class StoreInfoService : IStoreInfoService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly IStoreInfoUnitOfWork _storeInfoUnitOfWork;

        public StoreInfoService(IHttpContextAccessor httpContext,
            IStoreInfoUnitOfWork storeInfoUnitOfWork)
        {
            _httpContext = httpContext;
            _storeInfoUnitOfWork = storeInfoUnitOfWork;
        }
        public string GetStoreUrl()
        {
            return _httpContext.HttpContext.Request.Host.Value;
        }

        public string GetStoreId()
        {
            var storeUrl = GetStoreUrl();

            //If colon exists then remove that part
            var indexOfColon = storeUrl.ToString().IndexOf(":");
            var end = storeUrl.Length;
            var trimmedPart = storeUrl.Remove(indexOfColon, end - indexOfColon);

            //if local host exists then remove that part
            var local = "local";
            var newUrl = "";
            if (trimmedPart.Contains(local))
            {
                var getIndex = trimmedPart.IndexOf(local);
                var endIndex = trimmedPart.Length + 1;        
                newUrl = trimmedPart.Remove(getIndex - 1, endIndex - getIndex);

                //get handle
                var getDotIndex = newUrl.LastIndexOf('.') + 1;
                var handle = newUrl.Remove(0, getDotIndex);

                return GetHandle(handle.ToString());
            }
            else
            {
                return GetMainUrl(trimmedPart.ToString());
            }            
        }
        
        public string GetHandle(string url)
        {
            EcomStoreEntity entity = null;

            entity = _storeInfoUnitOfWork.StoreInfoRepository.Get(x => x.Handle == url, "").FirstOrDefault();

            if (entity != null)
                return entity.Id.ToString();
            
            return null;
        }

        public string GetMainUrl(string url)
        {
            EcomStoreEntity entity = null;

            entity = _storeInfoUnitOfWork.StoreInfoRepository.Get(x => x.StoreUrl == url, "").FirstOrDefault();

            if (entity != null)
                return entity.Id.ToString();

            return null;
        }
    }
}
