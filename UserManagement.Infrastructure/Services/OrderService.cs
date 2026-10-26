using UserManagement.Application.Abstraction.Repositories;
using UserManagement.Application.Abstraction.Services;
using UserManagement.Domain.Entities;

namespace UserManagement.Infrastructure.Services
{
    public class OrderService(IOrderRepository orderRepository) : IOrderService
    {
        public Guid CreateOrder()
        {
            return orderRepository.CreateOrder();
        }

        public void DeleteOrder(Guid orderId)
        {
            orderRepository.DeleteOrder(orderId);
        }

        public List<Order> GetAllOrders()
        {
            return orderRepository.GetAllOrders();
        }

        public Order GetOrderById(Guid orderId)
        {
            return orderRepository.GetOrderById(orderId);
        }

        public void UpdateOrder(Guid orderId, Order order)
        {
            orderRepository.UpdateOrder(orderId, order);
        }
    }
}