using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestMSSQL.Models
{
    public class CpuMetric :BaseEntity
    {
        

        public int Value { get; set; }

        public DateTime Time { get; set; }

    }
}
