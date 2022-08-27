using AutoMapper;
using Ecommerce.Store.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.Services
{
    public class ImageService:IImageService
    {
        private readonly IImageUnitOfWork _imageUnitOfWork;
        private readonly IMapper _mapper;

        public ImageService(IMapper mapper,
            IImageUnitOfWork imageUnitOfWork)
        {
            _imageUnitOfWork = imageUnitOfWork;
            _mapper = mapper;
        }
        public void DeleteImage(Guid productId)
        {
            _imageUnitOfWork.ImageRepository.Remove(x =>x.ProductId==productId);
            _imageUnitOfWork.Save();

        }
    }
}
