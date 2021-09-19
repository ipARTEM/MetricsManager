
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Models
{
    // задаем хэндлер для парсинга значений в TimeSpan если таковые попадутся в наших классах моделей
    public class TimeSpanHandler
        //: SqlMapper.TypeHandler<TimeSpan>
    {
    //    public override TimeSpan Parse(object value)
    //        => TimeSpan.FromSeconds((long)value);

    //    public override void SetValue(IDbDataParameter parameter, TimeSpan value)
    //        => parameter.Value = value;
    }

}
