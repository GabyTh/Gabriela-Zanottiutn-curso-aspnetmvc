using System.Net;
using Microsoft.AspNetCore.Mvc;
using UTNCurso.Core.Domain;

namespace UTNCursoApi.Controllers.v1
{
    [ApiVersion("1.0")]
    [ApiController]
    [Route("{v:apiVersion}/[controller]")]
    public class GTController : ControllerBase
    {
        private readonly ILogger<GTController> _logger;

        public GTController(ILogger<GTController> logger)
        {
            _logger = logger;
        }

        [HttpGet("healthcheck")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult healthcheck()
        {
            return Ok();
        }

    }
}