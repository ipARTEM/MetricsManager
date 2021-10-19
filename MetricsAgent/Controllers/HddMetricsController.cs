using AutoMapper;
using MetricsAgent.DAL.Interfaces;
using MetricsAgent.DAL.Models;
using MetricsAgent.Models;
using MetricsAgent.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    [Route("api/metrics/hdd/left")]
    [ApiController]
    public class HddMetricsController : BaseController<HddMetricDto>
    {
        private readonly IHddMetricsRepository repository;

        private readonly IMapper mapper;

        private readonly ILogger<HddMetricsController> _logger;

        public HddMetricsController()
        {
        }

        public HddMetricsController(IHddMetricsRepository repository, ILogger<HddMetricsController> logger, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;


            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в HddMetricsController");
        }


        [HttpGet("all")]
        public IActionResult GetAll()
        {
            IList<HddMetric> metrics = repository.GetAll();

            var response = new AllHddMetricsResponse()
            {
                Metrics = new List<HddMetricDto>()
            };

            foreach (var metric in metrics)
            {
                response.Metrics.Add(mapper.Map<HddMetricDto>(metric));
            }

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetHi()
        {
            _logger.LogInformation("Сообщение из  GetHi");
            return Ok("Hi, I am cpu controller");
        }


        //public HddMetricsDto GetMetricsFromAgent(
        //     [FromRoute] int agentId,
        //    [FromRoute] TimeSpan fromTime,
        //    [FromRoute] TimeSpan toTime)
        //{
        //    return new HddMetricsDto();
        //}

        //[HttpGet("from/{fromTime}/to/{toTime}")]
        //public IActionResult GetMetricsFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        //{
        //    _logger.LogInformation("Сообщение из  GetMetricsFromAgent");
        //    return Ok();
        //}

        [HttpGet("from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            _logger.LogInformation("Сообщение из  GetMetricsFromAllCluster");
            return Ok();
        }
    }
}
