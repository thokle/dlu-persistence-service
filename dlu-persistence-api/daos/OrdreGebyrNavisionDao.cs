using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class OrdreGebyrNavisionDao: IDisposable
    {
        private DiMPdotNetDevEntities _entities;

        public OrdreGebyrNavisionDao()
        {
            _entities = new DiMPdotNetDevEntities();
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderid"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetOrderGebyNavisionByOrderId(int orderid)
        {
            try
            {
                var res = from od in _entities.tblOrdreNavisions
                    where od.OrdreNr == orderid
                    select new
                    {
                         od.Uge, od.Advertiser, od.Bureau, od.Placement, od.Status, od.Version, od.AntalFarver,
                        od.Credit_Reason, od.Document_Type, od.EnOrdre, od.FakBem1, od.FakBem2, od.FakBem3, od.InfoGodt, od.Item_Description, 
                        od.OrdreDato, od.Previous_Version, od.SamletPris, od.SikkerhedsGodt, od.SælgerKode, od.AnnoncørID, od.BureauOrdreNr,
                        od.Previous_Order_No
                    };
                return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
            }
            
            
            catch(Exception e)
            {
                
                throw new DaoExceptions("GetOrderGebyNavisionByOrderId", e.InnerException);
            }
        }


        public string GetOrderGebyNavisionBySælgerkode(string saelgerkode)
        {
            try
            {
                var res = from od in _entities.tblOrdreNavisions
                    where od.SælgerKode == saelgerkode
                    select new
                    {
                        od.Uge, od.Advertiser, od.Bureau, od.Placement, od.Status, od.Version, od.AntalFarver,
                        od.Credit_Reason, od.Document_Type, od.EnOrdre, od.FakBem1, od.FakBem2, od.FakBem3, od.InfoGodt, od.Item_Description, 
                        od.OrdreDato, od.Previous_Version, od.SamletPris, od.SikkerhedsGodt, od.SælgerKode, od.AnnoncørID, od.BureauOrdreNr,
                        od.Previous_Order_No
                    };
                return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
            }
            
            
            catch(Exception e)
            {
                
                throw new DaoExceptions("GetOrderGebyNavisionByOrderId", e.InnerException);
            }
        }

        public string GetOrderNavisionGebyrByBureau(string burea)
        {
            try
            {
                var res = from od in _entities.tblOrdreNavisions
                    where od.Bureau == burea
                    select new
                    {
                        od.Uge, od.Advertiser, od.Bureau, od.Placement, od.Status, od.Version, od.AntalFarver,
                        od.Credit_Reason, od.Document_Type, od.EnOrdre, od.FakBem1, od.FakBem2, od.FakBem3, od.InfoGodt, od.Item_Description, 
                        od.OrdreDato, od.Previous_Version, od.SamletPris, od.SikkerhedsGodt, od.SælgerKode, od.AnnoncørID, od.BureauOrdreNr,
                        od.Previous_Order_No
                    };
                return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
            }
            
            
            catch(Exception e)
            {
                
                throw new DaoExceptions("GetOrderGebyNavisionByOrderId", e.InnerException);
            }
            
        }


        public Task<int> CreateOrUpate(tblOrdreGebyrNavision tblOrdreGebyrNavision)
        {
            try
            {
                _entities.tblOrdreGebyrNavisions.AddOrUpdate(tblOrdreGebyrNavision);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        
        }
        
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}