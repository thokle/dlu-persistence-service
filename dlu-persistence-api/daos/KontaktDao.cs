using System;
using System.Linq;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class KontaktDao
    {
        private readonly DiMPdotNetEntities _entities;
    
        public KontaktDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladid"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetKontakterPrBlad(int bladid)
        {
            try
            {
                var res = from ko in _entities.tblKontakterPrBlads
                    where ko.BladID == bladid
                    select new
                    {
                        ko.BladID,
                        ko.KontaktID,
                        ko.tblKontakter,
                        ko.tblKontaktFunktioners,

                        kontakter = from t in _entities.tblKontakters
                            where t.KontaktID == ko.KontaktID
                            select new
                            {
                                t.KontaktID, t.Fornavn, t.Efternavn, t.Email, t.Tlfnr, t.Mobilnr, t.TitelID
                            }
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("KontaktDao GetKontakterPrBlad " , e.InnerException );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetKontaktTitler()
        {
            try
            {
                var res = from kt in _entities.tblKontaktTitlers
                    orderby kt.Titel
                    select new
                    {
                        kt.TitelID,
                        kt.Titel
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions(" KontaktDao GetKontaktTitler", e.InnerException);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetKontakterArbOmråderKontkter()
        {
            try
            {
                var res = from kk in _entities.tblKontaktArbOmråder
                    orderby kk.ArbOmråde
                    select new
                    {
                        kk.ArbOmråde,
                        kk.ArbOmrådeID
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  FormattedDbEntityValidationException(e.InnerException);
            }
        }
        
        
    }
}