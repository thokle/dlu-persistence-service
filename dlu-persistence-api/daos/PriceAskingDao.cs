using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class PriceAskingDao
    {
        private DiMPdotNetDevEntities _entities;

        public PriceAskingDao()
        {
            _entities = new DiMPdotNetDevEntities();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladid"></param>
        /// <returns></returns>
        /// <exception cref="FormattedDbEntityValidationException"></exception>
        public string GetPriceAskigListByBladId(int bladid)
        {
            try
            {
                var res = from p in _entities.tblPriceAskings
                          where p.stambladId == bladid
                          select new
                          {
                              p.email,
                              p.telefon,
                              p.name

                          };
                return Newtonsoft.Json.JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="asking"></param>
        /// <returns></returns>
        /// <exception cref="FormattedDbEntityValidationException"></exception>

        public Task<int> CreatePriceAskingEntry(tblPriceAsking asking)
        {
            try
            {
                _entities.tblPriceAskings.AddOrUpdate(asking);
                return _entities.SaveChangesAsync();

            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }

        }
    }
}
