using Ecommerce.Store.BusinessObjects;

namespace Ecommerce.Store.Services
{
    public interface IContactFormService
    {
        void CreateContactForm(ContactForm contactForm);
        void DeleteContactForm(Guid id);
        void EditContactForm(ContactForm contactForm);
        ContactForm GetContactForm(Guid id);
        (int total, int totalDisplay, IList<ContactForm> records) GetContactMessages(int pageIndex, int pageSize, string searchText, string orderBy);
    }
}