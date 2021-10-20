using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Dapper.MSSQL.DAL.Models
{
    public class TimeSpanHandler : SqlMapper.TypeHandler<TimeSpan>
    {
        public override TimeSpan Parse(object value)
            => TimeSpan.FromSeconds((long)value);

        public override void SetValue(IDbDataParameter parameter, TimeSpan value)
            => parameter.Value = value;
    }

}
