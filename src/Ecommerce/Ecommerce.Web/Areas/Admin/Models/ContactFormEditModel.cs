using Autofac;
using AutoMapper;
using Ecommerce.Store.BusinessObjects;
using Ecommerce.Store.Services;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ContactFormEditModel
    {
        private IContactFormService _contactFormService;
        private ILifetimeScope _scope;
        private IMapper _mapper;

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool IsArchived { get; set; }

        public ContactFormEditModel()
        {

        }

        public ContactFormEditModel(IMapper mapper, IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
            _mapper = mapper;
        }

        public void Resolve(ILifetimeScope scope)
        {
            _scope = scope;
            _contactFormService = _scope.Resolve<IContactFormService>();
            _mapper = _scope.Resolve<IMapper>();
        }

        public void EditContactForm()
        {
            var contactForm = _mapper.Map<ContactForm>(this);

            _contactFormService.EditContactForm(contactForm);
        }

        public void LoadData(Guid id)
        {
            var contactForm = _contactFormService.GetContactForm(id);
            _mapper.Map(contactForm, this);
        }

      
    }
}