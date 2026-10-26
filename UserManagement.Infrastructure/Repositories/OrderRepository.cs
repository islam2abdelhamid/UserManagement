using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Application.Abstraction.Repositories;

namespace UserManagement.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Guid CreateOrder()
        {
            throw new NotImplementedException();
        }

        public void DeleteOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Guid orderId, Order order)
        {
            throw new NotImplementedException();
        }
    }
}