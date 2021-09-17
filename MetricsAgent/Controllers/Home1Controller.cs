using Core;
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
    public class Home1Controller : ControllerBase
    {
        private readonly INotifierMediatorService _notifierMediatorService;

        public Home1Controller(INotifierMediatorService notifierMediatorService)
        {
            _notifierMediatorService = notifierMediatorService;
        }

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            _notifierMediatorService.Notify();
            return "Completed - 1";
        }
    }

}

