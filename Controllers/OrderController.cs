using Microsoft.AspNetCore.Mvc;
using Messaging.Common.Publishing;

namespace ECommerceSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateOrder()
        {
            var publisher = new MessagePublisher();

            publisher.Publish("New order created!");

            return Ok("Message sent to RabbitMQ");
        }
    }
}
