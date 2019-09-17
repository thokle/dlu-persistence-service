using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using  System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{    
    /// <summary>
    /// 
    /// </summary>
    public class KonkurrenceDaekningDao

    {
    private DiMPdotNetDevEntities _entities;

    public KonkurrenceDaekningDao()
    {
            _entities = new DiMPdotNetDevEntities();
       
    }
        public string GetKonkurrenter()
        {
            try
            {
                var res = from k in _entities.tblKonkurrenters select new {
                    k.KonkurentKode, k.KonkurrentID,k.KonkurrentNavn, k.MedieMappingFraDO, konkurrentDaekning = from kd   in k.tblKonkurrentDækning select new
                    {
                        kd.KonkurrentID, kd.Oplag, kd.PostNr
                    }
                };
                return JsonConvert.SerializeObject(res, Formatting.Indented, new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            catch (Exception e)
            {

                throw;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="postnr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetKomkurrenceDækningPrPostNr(int postnr)
        {
            try
            {
                var res = from k in _entities.tblKonkurrentDækning
                    where k.PostNr == postnr
                    orderby k.PostNr
                    select new
                    {
                        k.PostNr, k.Oplag, k.DækningsGrad
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  DaoExceptions("GetKomkurrenceDækningPrPostNr ", e.InnerException);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="daekg"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetKonkurrenceDækningPrDaeknngGrad(int daekg)
        {

            try
            {
                var res = from k in _entities.tblKonkurrentDækning
                    where k.DækningsGrad == daekg
                    orderby k.DækningsGrad
                    select new
                    {
                        k.PostNr, k.Oplag, k.DækningsGrad,
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetKonkurrenceDækningPrDaeknngGrad", e.InnerException);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblKonkurrentDækning"></param>
        /// <returns></returns>
        /// <exception cref="FormattedDbEntityValidationException"></exception>
        public Task<int> CreateOrUpdate(tblKonkurrentDækning tblKonkurrentDækning)
        {
            try
            {
                _entities.tblKonkurrentDækning.AddOrUpdate(tblKonkurrentDækning);
                return _entities.SaveChangesAsync();
            }
            catch (DbEntityValidationException e)
            {
                throw new    FormattedDbEntityValidationException(e.InnerException);
            }

            
        }
        
        
        public void Dispose()
        {
           _entities.Dispose();
        }
    }
}