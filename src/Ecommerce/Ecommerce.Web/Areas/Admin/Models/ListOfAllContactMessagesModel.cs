using Ecommerce.Common;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ListOfAllContactMessagesModel
    {
        private readonly IContactFormService _contactFormService;
        public ListOfAllContactMessagesModel(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
            
        }

        public object? GetAllContactMessages(DataTablesAjaxRequestModel dataTableModel)
        {
            var data = _contactFormService.GetContactMessages(
                    dataTableModel.PageIndex,
                    dataTableModel.PageSize,
                    dataTableModel.SearchText,
                    dataTableModel.GetSortText(
                        new string[] {"Name",
                                      "Email",
                                       "Message"}));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.Email,                             
                                record.Message,                             
                                record.Id.ToString()
                        }
                    ).ToArray()
            };
        }

        public void DeleteContactForm(Guid id)
        {
            _contactFormService.DeleteContactForm(id);
        }
    }
}
