using System;

namespace MetricsAgent.Requests
{
    internal class CpuMetricCreateRequest : Models.CpuMetricCreateRequest
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
    }
}