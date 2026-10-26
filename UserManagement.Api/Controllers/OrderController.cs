using Microsoft.AspNetCore.Mvc;
using UserManagement.Application.Abstraction.Services;
using UserManagement.Domain.Entities;

namespace UserManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public IActionResult GetAllOrders()
        {
            return Ok(_orderService.GetAllOrders());
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderById(Guid id)
        {
            return Ok(_orderService.GetOrderById(id));
        }

        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            _orderService.CreateOrder();
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOrder(Guid id, Order order)
        {
            _orderService.UpdateOrder(id, order);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(Guid id)
        {
            _orderService.DeleteOrder(id);
            return Ok();
        }
    }
}