using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class BladDækningDao
    {
        private readonly DiMPdotNetDevEntities _entities;

        public BladDækningDao()
        {
            _entities = new DiMPdotNetDevEntities();
            
                _entities.Configuration.LazyLoadingEnabled = true;
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladID"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetDækningGradByBladId(int bladID)
        {
            try
            {
                var res = from dg in _entities.tblBladDækning from e in _entities.tblPostNrs
                          where dg.PostNr == e.PostNr   & dg.BladID == bladID
                        
        

                    select new Bladdaeknik()
                    {
                       BladID1 = dg.BladID,
                       DaekningsGrad1 = dg.DækningsGrad,
                       Oplag1 = dg.Oplag,
                       
                        PostNr1 = dg.PostNr,
                       Postby =  e.PostBy
                   
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("BladDækningDao GetDækningGradByBladId", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="postnr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetDækningGrapPrPostNr(int bladid)
        {
            try
            {
                var res = from dp in _entities.tblBladDækning
                    where dp.BladID == bladid
                    select new
                    {
                        dp.BladID, dp.Oplag, dp.DækningsGrad, dp.PostNr
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException( e.InnerException);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblBladDækning"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> OpretBladDækning(tblBladDækning tblBladDækning)
        {

           
            try
            {
                _entities.tblBladDækning.AddOrUpdate(tblBladDækning);

                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("BladDækningDao OpretBladDækning " , e.InnerException);
            }
        }

        public Task<int> DeleteDaeking(int bladid, int postnr)
        {
            var res = from d in _entities.tblBladDækning where d.BladID == bladid & d.PostNr == postnr select d;

            var table = res.Single();
            _entities.tblBladDækning.Remove(table);
            return _entities.SaveChangesAsync();
;        }


    }

   
}