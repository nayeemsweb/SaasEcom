using Autofac;
using AutoMapper;
using Ecommerce.Store.Services;
using PSHostsFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceSubDomain.Worker.HostFiles
{
    internal class HostFile
    {
        private ILifetimeScope _scope;
        private IMapper _mapper; 
        private IStoreService _storeService;
        public HostFile()
        {

        }
        public HostFile(ILifetimeScope scope, IStoreService storeService, IMapper mapper)
        {
            _scope = scope;
            _mapper = mapper;
            _storeService = storeService;
        }
        internal void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _mapper = _scope.Resolve<IMapper>();
            _storeService = _scope.Resolve<IStoreService>();
        }
        public void View()
        {
            foreach (var hostsEntry in HostsFile.Get())
            {
                Console.WriteLine("Have host {0} - {1}.", hostsEntry.Hostname, hostsEntry.Address);
            }
        }
        /// <summary>
        /// In Db
        /// action 0 means nothing added to host file
        /// action 1 means only subdomain added to host file
        /// action 2 means subdomain and url added to db
        /// </summary>
        public void AddSubDomain()
        {
            int action = 0;
            var stores = _storeService.GetByHostTrigger(action);
            var subDomain = "";
            if (stores.Count>0)
            {
                foreach (var store in stores)
                {
                    subDomain = store.Handle + ".localhost";
                    HostsFile.Set(subDomain, "127.0.0.1");
                    store.HostTrigger = 1;//mark as subdomain/handle added to hostFile
                    _storeService.EditStore(store);
                }
            }
        }
        public void AddUrl()
        {
            int action = 1;
            var stores = _storeService.GetByHostTrigger(action);
            var url = "";
            if (stores.Count > 0)
            {
                foreach (var store in stores)
                {
                    if (store.StoreUrl != null)
                    {
                        url = store.StoreUrl;
                        if(url!=null)
                        {
                            HostsFile.Set(url, "127.0.0.1");
                            store.HostTrigger = 2;//mark as StoreUrl added to hostFile
                        }
                        _storeService.EditStore(store);
                    }
                }
            }
        }
        public void DeleteUrl(Guid StoreId)
        {

            var store = _storeService.GetStore(StoreId);
            var url = store.StoreUrl;
            if (url != null)
            {
                store.StoreUrl = null;
                store.HostTrigger = 1;//mark as url removed
                _storeService.EditStore(store);
                HostsFile.Remove(url);
            }
        }
        public void EditUrl(Guid StoreId, string newUrl)
        {

            var store = _storeService.GetStore(StoreId);
            var url = store.StoreUrl;
            if (url != null)
            {
                store.StoreUrl = newUrl;
                store.HostTrigger = 2;//mark as url added
                _storeService.EditStore(store);
                HostsFile.Remove(url);
                HostsFile.Set(newUrl, "127.0.0.1");
            }
        }
            public void FromDB()
            {
            var stores=_storeService.GetAll();
            foreach (var store in stores)
                Console.WriteLine("Hanlde "+store.Handle);
            }
    }
}
