using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metrics.Services.Interfaces
{
    public interface ICpuMetricsService
    {
        long GetMetricsFromAgent( int agentId, TimeSpan fromTime, TimeSpan toTime);
        void GetMetricsFromAgent();
    }
}
