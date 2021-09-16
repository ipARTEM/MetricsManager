using MetricsAgent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/dotnet/errors-count")]
    [ApiController]
    public class DotNetMetricsController : ControllerBase
    {
        private readonly ILogger<DotNetMetricsController> _logger;
        public DotNetMetricsController(ILogger<DotNetMetricsController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в DotNetMetricsController");
        }

        private DotNetMetricsController repository;

        //public DotNetMetricsController(ICpuMetricsRepository repository)
        //{
        //    this.repository = repository;
        //}

        //[HttpPost("create")]
        //public IActionResult Create([FromBody] CpuMetricCreateRequest request)
        //{
        //    _logger.LogInformation("Сообщение из  Create");
        //    repository.Create(new CpuMetric
        //    {
        //        Time = request.Time,
        //        Value = request.Value
        //    });

        //    return Ok();
        //}


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
