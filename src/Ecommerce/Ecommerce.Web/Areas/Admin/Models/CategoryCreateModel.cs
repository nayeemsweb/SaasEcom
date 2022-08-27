using System.ComponentModel.DataAnnotations;
using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using Ecommerce.Web.Areas.Admin.Controllers;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class CategoryCreateModel : SetStoreId
    {
        private ICategoryService _categoryService;
        private ILifetimeScope _lifetimeScope;
        private IMapper _mapper;

        [StringLength(100, ErrorMessage = "Name should be less than 100 chars")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public Guid StoreId { get; set; }

        internal void setStoreId(Guid storeId)
        {
            StoreId = storeId;
        }
        public CategoryCreateModel()
        {

        }

        public CategoryCreateModel(IMapper mapper, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _categoryService = _lifetimeScope.Resolve<ICategoryService>();
            _mapper = _lifetimeScope.Resolve<IMapper>();
        }

        internal void CreateCategory()
        {
            var category = _mapper.Map<Category>(this);

            _categoryService.CreateCategory(category);
        }
    }
}
