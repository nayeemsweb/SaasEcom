using Ecommerce.Common;
using Ecommerce.Store.Enums;
using Ecommerce.Store.Services;
using Ecommerce.Store.Services.MetaData;

namespace Ecommerce.Web.Areas.Customer.Models
{
    public class ListOfMyOrdersModel
    {
        private readonly IOrderService _orderService;
        private readonly IUserInfoService _userInfoService;

        public ListOfMyOrdersModel(IOrderService orderService, IUserInfoService userInfoService)
        {
            _orderService = orderService;
            _userInfoService = userInfoService;
        }

        public object? GetAllOrders(DataTablesAjaxRequestModel dataTableModel, Guid StoreId)
        {


            var data = _orderService.GetOrders(
                    StoreId,
                    dataTableModel.PageIndex,
                    dataTableModel.PageSize,
                    dataTableModel.GetSortText(
                        new string[] {"OrderNumber",
                                      "CreatedAt",
                                       "",
                                        "OrderStatus"}));
            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from orderInfo in data.Orders
                        select new string[]
                        {
                            orderInfo.OrderNumber.ToString(),
                            orderInfo.CreatedAt.ToShortDateString(),
                            (orderInfo.OrderedProducts != null) ?
                                orderInfo.OrderedProducts.Sum(x => x.ProductPrice).ToString()
                                :string.Empty,
                            ((OrderStatus)(orderInfo.OrderStatus)).ToString()
                            
                            
                        }).ToArray()
            };
        }
    }
}
