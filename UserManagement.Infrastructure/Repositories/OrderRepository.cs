using UserManagement.Application.Abstraction.Repositories;
using UserManagement.Domain.Entities;

namespace UserManagement.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Guid CreateOrder()
        {
            return Guid.NewGuid();
        }

        public void DeleteOrder(Guid orderId)
        {
            // TODO: Implement delete order
        }

        public List<Order> GetAllOrders()
        {
            // TODO: Implement get all orders
            return new List<Order>();
        }

        public Order GetOrderById(Guid orderId)
        {
            // TODO: Implement get order by id
            return new Order();
        }

        public void UpdateOrder(Guid orderId, Order order)
        {
            // TODO: Implement update order
        }
    }
}