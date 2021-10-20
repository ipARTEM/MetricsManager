using MetricsAgent.Dapper.MSSQL.DAL.Interfaces;
using MetricsAgent.Dapper.MSSQL.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Dapper.MSSQL.DAL.Repositories
{
    public class CpuMetricsRepository: ICpuMetricsRepository
    {

        public CpuMetricsRepository()
        {

        }

        public void Create(CpuMetric item)
        {
           
        }

        public void Delete(int id)
        {
            
        }

        public void Update(CpuMetric item)
        {
            
        }

        public IList<CpuMetric> GetAll()
        {
            List<CpuMetric> listCpu=new ();

            return listCpu;


        }

        public CpuMetric GetById(int id)
        {
            CpuMetric cpu = new ();

            return cpu;
            
        }

    }
}
