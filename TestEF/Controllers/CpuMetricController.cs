using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestEFDB;

namespace TestEF.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CpuMetricController : ControllerBase
    {

        private readonly IDbRepository<CpuMetric> _сpuMetricRepo;

        public CpuMetricController(IDbRepository<CpuMetric> сpuMetricRepo)
        {
            _сpuMetricRepo = сpuMetricRepo;
        }


        [HttpGet("hi")]
        public IActionResult GetHi()
        {
            
            return Ok("Hi, I am cpu controller");
        }

        [HttpGet]
        public Task<List<CpuMetric>> GetAll()
        {
            return _сpuMetricRepo.GetAll().ToListAsync();
        }

        

        [HttpPost]
        public Task Add(CpuMetric сpuMetric)
        {
            return _сpuMetricRepo.AddAsync(сpuMetric);
        }

        [HttpPut]
        public Task Update(CpuMetric сpuMetric)
        {
            return _сpuMetricRepo.UpdateAsync(сpuMetric);
        }

        [HttpDelete]
        public Task Delete(CpuMetric сpuMetric)
        {
            return _сpuMetricRepo.DeleteAsync(сpuMetric);
        }
    }
}
