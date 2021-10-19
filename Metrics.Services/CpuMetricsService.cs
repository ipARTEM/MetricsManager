using Metrics.Services.Interfaces;
using System;

namespace Metrics.Services
{
    public class CpuMetricsService : ICpuMetricsService
    {
        public long GetMetricsFromAgent(int agentId, TimeSpan fromTime, TimeSpan toTime)
        {
            throw new NotImplementedException();
        }

        public void GetMetricsFromAgent()
        {
            throw new NotImplementedException();
        }

        public static void Main()
        {

        }
    }
}
