using System.Threading.Tasks;
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

        public MetadataController(ILogger<MetadataController> logger)
        {
            _logger = logger;
        }

        [Route("metadata/basic")]
        [HttpPut]
        public async Task<IActionResult> BasicMetadataUpdate([FromBody] BasicMetadata basicMetadata)
        {
            if (basicMetadata == null)
            {
                return BadRequest();
            }

            await Task.CompletedTask;

            return Ok();
        }

        [Route("metadata/theme/{id}")]
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
    }
}
