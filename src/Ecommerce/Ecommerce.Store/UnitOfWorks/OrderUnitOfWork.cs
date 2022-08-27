using Ecommerce.Data;
using Ecommerce.Store.DbContexts;
using Ecommerce.Store.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Store.UnitOfWorks
{
    public class OrderUnitOfWork : UnitOfWork, IOrderUnitOfWork
    {
        public IOrderRepository Orders { get; private set; }
        public OrderUnitOfWork(IStoreDbContext storeDbContext,
            IOrderRepository orderRepository) : base((DbContext)storeDbContext)
        {
            Orders = orderRepository;
        }
    }
}
