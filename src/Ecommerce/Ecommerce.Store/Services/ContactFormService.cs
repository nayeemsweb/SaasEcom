using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.UnitOfWorks;
using ContactFormEntity = Ecommerce.Store.Entities.ContactForm;

namespace Ecommerce.Store.Services
{
    public class ContactFormService : IContactFormService
    {
        private readonly IContactFormUnitOfWork _contactFormUnitOfWork;
        private readonly IMapper _mapper;

        public ContactFormService(IMapper mapper,
            IContactFormUnitOfWork contactFormUnitOfWork)
        {
            _contactFormUnitOfWork = contactFormUnitOfWork;
            _mapper = mapper;
        }


        public void CreateContactForm(ContactForm contactForm)
        {
            var contactFormCount = _contactFormUnitOfWork.ContactForms
                .GetCount(x => x.Name == contactForm.Name);

            var entity = _mapper.Map<ContactFormEntity>(contactForm);

            _contactFormUnitOfWork.ContactForms.Add(entity);
            _contactFormUnitOfWork.Save();


        }

        public (int total, int totalDisplay, IList<ContactForm> records) GetContactMessages(int pageIndex,
         int pageSize, string searchText, string orderBy)
        {
            var result = _contactFormUnitOfWork.ContactForms.GetDynamic(x => x.Name.Contains(searchText),
                orderBy, string.Empty, pageIndex, pageSize, true);

            List<ContactForm> contactMessages = new List<ContactForm>();
            foreach (ContactFormEntity contactForm in result.data)
            {
                contactMessages.Add(_mapper.Map<ContactForm>(contactForm));
            }

            return (result.total, result.totalDisplay, contactMessages);
        }

        //public void DeleteProduct(Guid id)
        //{
        //    _productUnitOfWork.Products.Remove(id);
        //    _productUnitOfWork.Save();
        //}

        //public void EditProduct(Product product)
        //{
        //    var productEntity = _productUnitOfWork.Products.GetById(product.Id);

        //    productEntity = _mapper.Map(product, productEntity);

        //    _productUnitOfWork.Save();
        //}
        //public void ChangeVisibility(Guid id)
        //{
        //    var productEntity = _productUnitOfWork.Products.GetById(id);

        //    productEntity.ActiveStatus = (productEntity.ActiveStatus) ? false : true;
        //    _productUnitOfWork.Save();
        //}


        //public int GetProductCount()
        //{
        //    return _productUnitOfWork.Products.GetAll().Count();

        //}


        //public (int total, int totalDisplay, IList<Product> Products) GetProducts(Guid StoreId, int pageIndex,
        //    int pageSize, string searchText, string orderBy)
        //{
        //    var result = _productUnitOfWork.Products.GetDynamic(x => x.StoreId == StoreId
        //        && x.Name.Contains(searchText),
        //        orderBy, "ProductImages,ProductCategories,ProductInventory", pageIndex, pageSize, true);

        //    List<Product> products = new List<Product>();
        //    foreach (ProductEntity product in result.data)
        //    {
        //        products.Add(_mapper.Map<Product>(product));
        //    }

        //    return (result.total, result.totalDisplay, products);
        //}

        //public (int total, int totalDisplay, IList<Product> products)
        //    GetProducts(int pageIndex, int pageSize,
        //    string searchText, string orderBy)
        //{
        //    var result = _productUnitOfWork.Products.GetDynamic(
        //        x => x.Name.Contains(searchText),
        //        orderBy, "ProductImages,ProductCategories,Reviews", pageIndex, pageSize, true
        //        );


        //    List<Product> products = new List<Product>();
        //    foreach (ProductEntity product in result.data)
        //    {
        //        products.Add(_mapper.Map<Product>(product));
        //    }

        //    return (result.total, result.totalDisplay, products);
        //}


        //public Product GetProductById(Guid id)
        //{
        //    var result = _productUnitOfWork.
        //        Products.Get(x => x.Id.Equals(id),
        //        "ProductImages,ProductCategories,Reviews");

        //    var product = _mapper.Map<Product>(result[0]);

        //    return product;
        //}


        //public IList<Product> GetProducts()
        //{
        //    var productEntities = _productUnitOfWork.Products.GetAll();

        //    List<Product> products = new List<Product>();

        //    foreach (ProductEntity entity in productEntities)
        //    {
        //        products.Add(_mapper.Map<Product>(entity));
        //    }

        //    return products;
        //}


        ////fetch product from db with specific store
        //public IList<Product> GetProducts(Guid StoreId)
        //{
        //    var productEntities = _productUnitOfWork.Products.
        //            GetDynamic(x => x.StoreId == StoreId, "", "ProductImages,ProductCategories,ProductInventory", false);

        //    List<Product> products = new List<Product>();

        //    foreach (ProductEntity entity in productEntities)
        //    {
        //        products.Add(_mapper.Map<Product>(entity));
        //    }

        //    return products;
        //}

        public void DeleteContactForm(Guid id)
        {
            _contactFormUnitOfWork.ContactForms.Remove(id);
            _contactFormUnitOfWork.Save();
        }

        public void EditContactForm(ContactForm contactForm)
        {
            var contactFormCount = _contactFormUnitOfWork.ContactForms
                .GetCount(x => x.Name == contactForm.Name
                && x.Id != contactForm.Id);

            if (contactFormCount == 0)
            {
                var contactFormEntity = _contactFormUnitOfWork.ContactForms.GetById(contactForm.Id);

                contactFormEntity = _mapper.Map(contactForm, contactFormEntity);

                _contactFormUnitOfWork.Save();
            }
            //else
            //    throw new DuplicateException("Course name already exists");
        }

        public ContactForm GetContactForm(Guid id)
        {
            var contactFormEntity = _contactFormUnitOfWork.ContactForms.GetById(id);

            var contactForm = _mapper.Map<ContactForm>(contactFormEntity);

            return contactForm;
        }


    }
}

