using Ecommerce.Store.BusinessObjects;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Services
{
    public interface ITestProductService
    {
        
        (int total, int totalDisplay, IList<TestProduct> products) 
            GetProducts(int pageIndex, int pageSize,
            string searchText, string orderBy);

        int GetProductCount();
        TestProduct GetProductByID(Guid id);

    }
}
