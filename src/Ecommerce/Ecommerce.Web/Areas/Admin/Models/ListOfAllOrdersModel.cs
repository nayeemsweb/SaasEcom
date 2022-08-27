using Ecommerce.Common;
using Ecommerce.Store.Enums;
using Ecommerce.Store.Services;

namespace Ecommerce.Web.Areas.Admin.Models
{
    public class ListOfAllOrdersModel
    {
        private readonly IOrderService _orderService;
        public ListOfAllOrdersModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public object? GetAllOrders(DataTablesAjaxRequestModel dataTableModel, Guid StoreId)
        {
            var data = _orderService.GetOrders(
                    StoreId,
                    dataTableModel.PageIndex,
                    dataTableModel.PageSize,
                    dataTableModel.GetSortText(
                        new string[] {"OrderNumber"
                                      }));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from orderInfo in data.Orders
                        select new string[]
                        {
                            orderInfo.OrderNumber.ToString(),
                            DateTime.Now.ToShortDateString(),
                            (orderInfo.OrderedProducts != null) ?
                                orderInfo.OrderedProducts.Sum(x => x.ProductPrice).ToString()
                            :string.Empty,
                            ((OrderStatus)(orderInfo.OrderStatus)).ToString(),
                        }).ToArray()
            };
        }
    }
}
