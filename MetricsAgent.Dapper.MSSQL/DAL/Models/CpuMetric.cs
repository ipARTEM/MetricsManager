using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Dapper.MSSQL.DAL.Models
{
    public class CpuMetric : BaseDto
    {
        public int Value { get; set; }

        //public TimeSpan Time { get; set; }

        public int Period { get; set; }

        public string Name { get; set; }






    }
}