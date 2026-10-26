using UserManagement.Domain.Entities;

namespace UserManagement.Application.Abstraction.Repositories
{
    public interface IOrderRepository
    {
        public Guid CreateOrder();
        public void UpdateOrder(Guid orderId, Order order);
        public void DeleteOrder(Guid orderId);
        public Order GetOrderById(Guid orderId);
        public List<Order> GetAllOrders();
    }


}