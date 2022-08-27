using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using Ecommerce.Web.Areas.Customer.Models.ImageModel;
using System.Text.Json.Nodes;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ProductDetailsModel
    {
        private readonly IProductService _productService;
        public Product product;
        private IMapper _mapper;


        public ProductDetailsModel(IProductService productService, IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public void GetProductById(Guid Id)
        {
            var value = _productService.GetProductById(Id);
            product= value;
        }
    }
}