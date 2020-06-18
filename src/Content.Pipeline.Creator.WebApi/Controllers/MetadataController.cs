using System.Threading.Tasks;
using Content.Pipeline.Creator.Clients.Interfaces;
using Content.Pipeline.Creator.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Content.Pipeline.Creator.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetadataController : ControllerBase
    {
        private readonly ILogger<MetadataController> _logger;
        private readonly IMessagingClient _messagingClient;

        public MetadataController(ILogger<MetadataController> logger, IMessagingClient messagingClient)
        {
            _logger = logger;
            _messagingClient = messagingClient;
        }

        [Route("basic")]
        [HttpPut]
        public async Task<IActionResult> BasicMetadataUpdate([FromBody] BasicMetadata basicMetadata)
        {
            if (basicMetadata == null)
            {
                return BadRequest();
            }

            await _messagingClient.SendMessageAsync(basicMetadata);

            return Ok();
        }

        [Route("theme/{id}")]
        [HttpPut]
        public async Task<IActionResult> ThemeUpdate([FromBody] Theme theme)
        {
            if (theme == null)
            {
                return BadRequest();
            }

            await Task.CompletedTask;

            return Ok();
        }

        [Route("ping")]
        [HttpGet]
        public async Task<IActionResult> Ping()
        {
            return Ok(new { Text = "Pong" });
        }
    }
}
