
using System;
using System.Data.Entity.Migrations;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class MediePlanLinjerDao: IDisposable
    {
        private DiMPdotNetEntities _entities;


        public MediePlanLinjerDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medieId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetMediePlanLinjerByMediePlanId(int medieId)
        {
            try
            {
                var res = from m in _entities.tblMedieplanLinjers
                    where m.MedieplanNr == medieId
                    orderby m.MedieplanNr
                    select new
                    {
                        m.Bemærkning, m.Mm, m.Total, m.Version, m.FarveMax, m.FarveMin, m.FarveRabat, m.FarvePris,
                        m.FarveTillæg, m.FarveTotal, m.ManueltÆndret, m.NormalMmPris

                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MediePlanLinjerDao GetMediePlanLinjerByMediePlanId ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMedieplanLinjer"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateOrUpdateMediePlanLinjer(tblMedieplanLinjer tblMedieplanLinjer)
        {
            try
            {
                _entities.tblMedieplanLinjers.AddOrUpdate(tblMedieplanLinjer);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("CreateOrUpdateMediePlanLinjer ", e.InnerException);
            }

        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}