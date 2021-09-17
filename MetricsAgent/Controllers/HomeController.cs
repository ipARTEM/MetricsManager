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
    public class HomeController : ControllerBase
    {
        private readonly IEnumerable<INotifier> _notifiers;

        public HomeController(IEnumerable<INotifier> notifiers)
        {
            _notifiers = notifiers;
        }

        [HttpGet("")]
        public ActionResult<string> NotifyAll()
        {
            _notifiers.ToList().ForEach(x => x.Notify());
            return "Completed";
        }


    }


}
