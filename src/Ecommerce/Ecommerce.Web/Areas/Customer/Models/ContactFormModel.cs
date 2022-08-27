using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ContactFormModel
    {
        private IContactFormService _contactFormService;
        private ILifetimeScope _lifetimeScope;
        private IMapper _mapper;

        public ContactFormModel()
        {

        }
        public ContactFormModel(IContactFormService contactFormService, IMapper mapper)
        {
            _contactFormService = contactFormService;
            _mapper = mapper;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsArchived { get; set; }

        public void Resolve(ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _contactFormService = _lifetimeScope.Resolve<IContactFormService>();
            _mapper = _lifetimeScope.Resolve<IMapper>();
        }
        public void CreateContactForm()
        {
            var contactForm = _mapper.Map<ContactForm>(this);

            _contactFormService.CreateContactForm(contactForm);
        }


    }
}

