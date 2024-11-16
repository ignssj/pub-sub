using Microsoft.AspNetCore.Mvc;
using publisher_api.src.Application.Dto;
using publisher_api.src.Domain.Interfaces;

namespace publisher_api.src.Api
{
    [Route("api/messages")]
    [ApiController]
    public class MessageController(IPublisher publisher) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateMessage([FromBody] CreateMessageRequestDto msg)
        {
            await publisher.PublishAsync(msg.Description);
            return Ok();
        }
    }
}