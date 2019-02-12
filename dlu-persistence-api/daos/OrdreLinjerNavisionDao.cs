using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class OrdreLinjerNavisionDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public OrdreLinjerNavisionDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string GetOrderLinerByBladID(int bladId)
        {
            try
            {
                var res = from na in _entities.tblOrdreLinjerNavisions
                    where na.BladId == bladId
                    orderby na.BladId
                    select new
                    {
                        na.BureauOrdreNr, na.Format, na.Mm, na.AnvendtPris, na.BladId, na.Document_Type, na.FirstTime,
                        na.MaterialeGodt, na.MaterialePris, na.Previous_Version, na.SpecialRabat, na.FarveTillægsPris,
                        na.FarveTillægsRabat, na.Previous_Order_No
                        
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
               
                throw new DaoExceptions("GetOrderLinerByBladID ", e.InnerException);
            }
        }

        public string GetOrderLinjerByBureaOrderNr(string bureaorderne)
        {
            try
            {
                var res = from na in _entities.tblOrdreLinjerNavisions
                    where na.BureauOrdreNr == bureaorderne
                    orderby na.BureauOrdreNr
                    select new
                    {
                        na.BureauOrdreNr, na.Format, na.Mm, na.AnvendtPris, na.BladId, na.Document_Type, na.FirstTime,
                        na.MaterialeGodt, na.MaterialePris, na.Previous_Version, na.SpecialRabat, na.FarveTillægsPris,
                        na.FarveTillægsRabat, na.Previous_Order_No

                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {

                throw new DaoExceptions("GetOrderLinerByBladID ", e.InnerException);
            }

        }

        public Task<int> CreateOrUpdate(tblOrdreLinjerNavision tblOrdreLinjerNavision)
        {
            _entities.tblOrdreLinjerNavisions.AddOrUpdate(tblOrdreLinjerNavision);
            return _entities.SaveChangesAsync();
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}