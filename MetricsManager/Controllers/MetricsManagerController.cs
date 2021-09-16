using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetricsManagerController : ControllerBase
    {
        private readonly ILogger<MetricsManagerController> _logger;
        public MetricsManagerController(ILogger<MetricsManagerController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в MetricsManagerController");
        }


        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Сообщение из  GetMetricsFromAgent");
            return Ok();
        }

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Сообщение из  GetMetricsFromAllCluster");
            return Ok();
        }
    }
}
