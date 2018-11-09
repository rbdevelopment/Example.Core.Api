using Example.Core.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Core.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        /// <summary>
        ///     Performs a health check.
        /// </summary>
        [HttpGet]
        [HttpHead]
        [Route("health")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetHealth()
        {
            return Ok(HealthCheckProvider.CheckHealth);
        }
    }
}