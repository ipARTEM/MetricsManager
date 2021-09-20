using Quartz;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TestMSSQL.Models
{
    public class CpuMetricJob : IJob
    {
        //счётчик для метрики CPU
        private readonly PerformanceCounter _cpuCounter;
        private readonly PerformanceCounter _ramCounter;

        public CpuMetricJob()
        {
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        public Task Execute(IJobExecutionContext context)
        {
            var cpuUsageInPercents = Convert.ToInt32(_cpuCounter.NextValue());
            var ramCounter = Convert.ToInt32(_ramCounter.NextValue());

            Debug.WriteLine($"CpuMetricJob, {DateTime.Now:ddd HH:mm:ss} CpuPercent:   {cpuUsageInPercents}% RAM: {ramCounter} mb");

            return Task.CompletedTask;
        }
    }
}

