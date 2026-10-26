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

    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}