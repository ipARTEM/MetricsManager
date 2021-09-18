using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestEFDB;

namespace TestEF.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        public HomeController()
        {

        }

        [HttpGet("hi")]
        public IActionResult GetHi()
        {

            return Ok("Hi, I am cpu controller");
        }

        [HttpGet]
        public async Task Get([FromServices] AppDbContext context)
        {
            await context.CpuMetrics.AddAsync(new CpuMetric { Value = 55 });
            await context.SaveChangesAsync();

        }
    }
}
