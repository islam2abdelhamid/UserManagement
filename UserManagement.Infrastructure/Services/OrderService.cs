using UserManagement.Application.Abstraction.Services;

namespace UserManagement.Infrastructure.Services
{
    public class OrderService : IOrderService
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