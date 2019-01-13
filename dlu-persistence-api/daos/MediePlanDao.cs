using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class MediePlanDao : IDisposable
    {
        private DiMPdotNetEntities entities;

        /// <summary>
        /// 
        /// </summary>
        public MediePlanDao()
        {
            using (entities = new DiMPdotNetEntities())
            {
                entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medieplanNr"></param>
        /// <returns></returns>
        public string GetMediePlanByNumber(int medieplanNr)
        {
            var mediePlan = from m in entities.tblMedieplans
                where m.MedieplanNr == medieplanNr
                orderby m.MedieplanNr
                select new
                {
                };

            return JsonConvert.SerializeObject(mediePlan, Formatting.Indented);
        }

        public void Dispose()
        {
            entities?.Dispose();
        }
    }
}