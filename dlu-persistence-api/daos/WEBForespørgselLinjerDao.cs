using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using dlu_persistence_api;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos{
/// <summary>
/// 
/// </summary>
    public class WEBForespørgselLinjerDao
    {
        private DiMPdotNetDevEntities _entities;

        public WEBForespørgselLinjerDao()
        {
            _entities = new DiMPdotNetDevEntities();
             
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladID"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetForspørgelsesLinjerByBladId(int bladID)
        {
            try
            {
                var res = from fl in _entities.tblWEBForespørgselLinjer
                    where fl.BladID == bladID
                    orderby fl.BladID
                    select new
                    {
                        fl.BladID, fl.BesvaretAf, fl.BladBemærkning, fl.BladFarveRabat, fl.BladFarveTillæg, fl.BladMmPris, fl.BladMmRabat, fl.ForespørgselID, fl.PlaceringUB, 
                        fl.DLUFarveRabat, fl.DLUFarveTillæg, fl.DLUMmPris, fl.DLUMmRabat

                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetForspørgelsesLinjerByBladId  ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Task<int> CreateOrUpdate(tblWEBForespørgselLinjer forespørgselLinjer)
        {
            try
            {
                 _entities.tblWEBForespørgselLinjer.AddOrUpdate(forespørgselLinjer);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
              
                throw new FormattedDbEntityValidationException(e);
              
            }
        }
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}