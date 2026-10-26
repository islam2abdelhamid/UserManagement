using UserManagement.Domain.Entities;

namespace UserManagement.Application.Abstraction.Services
{
    public interface IOrderService
    {
        public Guid CreateOrder();
        public void UpdateOrder(Guid orderId, Order order);
        public void DeleteOrder(Guid orderId);
        public Order GetOrderById(Guid orderId);
        public List<Order> GetAllOrders();
    }


}