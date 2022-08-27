using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Services
{
    public interface IImageService
    {
        void DeleteImage(Guid productId);
    }
}
