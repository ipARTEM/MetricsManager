﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFDB
{
    public  class CpuMetric : BaseEntity
    {
        public int Value { get; set; }

        public TimeSpan Time { get; set; }
    }
}
