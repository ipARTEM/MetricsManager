using MetricsAgent.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<Dto> : ControllerBase where Dto :BaseDto, new ()
    {
        [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
        public virtual Dto GetMetricsFromAgent(
           [FromRoute] int agentId,
           [FromRoute] TimeSpan fromTime,
           [FromRoute] TimeSpan toTime)
        {

            //service.GetMetricsFromAgent();

            //_logger.LogInformation("Сообщение из  GetMetricsFromAgent");
            return new Dto();
        }
    }
}
