using Core;
using MetricsAgent.Models;
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
        private readonly IDbRepository<CpuMetric> _repository;

        //счётчик для метрики CPU
        private readonly PerformanceCounter _cpuCounter;
        private readonly PerformanceCounter _ramCounter;

        public CpuMetricJob(IDbRepository<CpuMetric> repository)
        {
            _repository = repository;
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        public Task Execute(IJobExecutionContext context)
        {
            var cpuUsageInPercents = Convert.ToInt32(_cpuCounter.NextValue());
            var ramCounter = Convert.ToInt32(_ramCounter.NextValue());

            var cpuMetric = new CpuMetric();
            cpuMetric.Time = DateTime.Now;
            cpuMetric.Value = cpuUsageInPercents;
            _repository.AddAsync(cpuMetric);


            Debug.WriteLine($"CpuMetricJob, {DateTime.Now:ddd HH:mm:ss} CpuPercent:   {cpuUsageInPercents}% RAM: {ramCounter} mb");

            return Task.CompletedTask;
        }
    }
}

