using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Models
{
    public class CpuMetricDto: BaseDto
    {
        
        
        public int Value { get; set; }

        public TimeSpan Time { get; set; }

    }
}
