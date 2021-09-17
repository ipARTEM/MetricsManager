using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Models
{
    public class AllCpuMetricsResponse
    {
        public List<CpuMetricsDto> Metrics { get; set; }

    }
}
