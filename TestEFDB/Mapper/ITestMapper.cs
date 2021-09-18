using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFDB.Mapper
{
    public interface ITestMapper
    {
        /// <summary>
        /// Провайдер конфигурации для Mapper
        /// </summary>
        IConfigurationProvider ConfigurationProvider { get; }

        /// <summary>
        /// Конвертирует объект в объект типа <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Тип, в который конфигурируется объект</typeparam>
        /// <param name="source">Исходный обьект</param>
        /// <returns></returns>
        T Map<T>(object source);

        /// <summary>
        /// Конвертирует объект в объект типа
        /// </summary>
        /// <typeparam name="TSource">Исходный тип</typeparam>
        /// <typeparam name="TDestination">Тип, в который конфигурируется объект</typeparam>
        /// <param name="source">Исходный обьект</param>
        /// <param name="destination">Целевой объект</param>
        void Map<TSource, TDestination>(TSource source, TDestination destination);



    }
}
