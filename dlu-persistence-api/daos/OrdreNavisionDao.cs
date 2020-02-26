using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class OrdreNavisionDao : IDisposable
    {
        private DiMPdotNetDevEntities _entities;

        public OrdreNavisionDao()
        {
            _entities = new DiMPdotNetDevEntities();

            _entities.Configuration.LazyLoadingEnabled = false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orderNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetOrderNavisionByOrderNr(int orderNr)
        {
            try
            {
                var res = from an in _entities.tblOrdreNavisions
                          where an.OrdreNr == orderNr
                          orderby an.OrdreNr
                          select new
                          {
                              an.Uge,
                              an.Advertiser,
                              an.Bureau,
                              an.Placement,
                              an.Status,
                              an.Version,
                              an.AntalFarver,
                              an.Credit_Reason,
                              an.Document_Type,
                              an.EnOrdre,
                              an.FakBem1,
                              an.FakBem2,
                              an.FakBem3,
                              an.InfoGodt,
                              an.Item_Description,
                              an.OrdreDato,
                              an.OrdreNr,
                              an.Previous_Version,
                              an.SamletPris,
                              an.SikkerhedsGodt,
                              an.SælgerKode,
                              an.AnnoncørID,
                              an.BureauOrdreNr,
                              an.MaterialeGodtgørelseTil,
                              an.Previous_Order_No,
                              an.SammeBureauOrdreNr

                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetOrderNavisionByOrderNr  ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saelgerKode"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetOrderNavisionbySaelgerKode(string saelgerKode)
        {
            try
            {
                var res = from an in _entities.tblOrdreNavisions
                          where an.SælgerKode == saelgerKode
                          orderby an.SælgerKode
                          select new
                          {
                              an.Uge,
                              an.Advertiser,
                              an.Bureau,
                              an.Placement,
                              an.Status,
                              an.Version,
                              an.AntalFarver,
                              an.Credit_Reason,
                              an.Document_Type,
                              an.EnOrdre,
                              an.FakBem1,
                              an.FakBem2,
                              an.FakBem3,
                              an.InfoGodt,
                              an.Item_Description,
                              an.OrdreDato,
                              an.OrdreNr,
                              an.Previous_Version,
                              an.SamletPris,
                              an.SikkerhedsGodt,
                              an.SælgerKode,
                              an.AnnoncørID,
                              an.BureauOrdreNr,
                              an.MaterialeGodtgørelseTil,
                              an.Previous_Order_No,
                              an.SammeBureauOrdreNr

                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetOrderbySaelgerKode  ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bureaOrderNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetOrderByNavisionByBureaOrderNy(string bureaOrderNr)
        {
            try
            {
                var res = from an in _entities.tblOrdreNavisions
                          where an.BureauOrdreNr == bureaOrderNr
                          orderby an.BureauOrdreNr
                          select new
                          {
                              an.Uge,
                              an.Advertiser,
                              an.Bureau,
                              an.Placement,
                              an.Status,
                              an.Version,
                              an.AntalFarver,
                              an.Credit_Reason,
                              an.Document_Type,
                              an.EnOrdre,
                              an.FakBem1,
                              an.FakBem2,
                              an.FakBem3,
                              an.InfoGodt,
                              an.Item_Description,
                              an.OrdreDato,
                              an.OrdreNr,
                              an.Previous_Version,
                              an.SamletPris,
                              an.SikkerhedsGodt,
                              an.SælgerKode,
                              an.AnnoncørID,
                              an.BureauOrdreNr,
                              an.MaterialeGodtgørelseTil,
                              an.Previous_Order_No,
                              an.SammeBureauOrdreNr

                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetOrderbySaelgerKode  ", e.InnerException);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblOrdreNavision"></param>
        /// <returns></returns>
        public Task<int> CreateOrUpdate(tblOrdreNavision tblOrdreNavision)
        {
            _entities.tblOrdreNavisions.AddOrUpdate(tblOrdreNavision);
            return _entities.SaveChangesAsync(CancellationToken.None);
        }


        public void Dispose()
        {
            _entities?.Dispose();
        }



    }
}