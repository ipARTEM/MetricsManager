
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFDB.Mapper
{
    
    public class TestMapper : ITestMapper
    {

        public TestMapper()
        {

        }

        
        public IConfigurationProvider ConfigurationProvider => throw new NotImplementedException();

        public T Map<T>(object source)
        {
            throw new NotImplementedException();
        }

        public void Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            throw new NotImplementedException();
        }
    }
}
