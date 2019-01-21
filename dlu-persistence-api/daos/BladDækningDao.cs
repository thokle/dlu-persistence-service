using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{
    public class BladDækningDao
    {
        private readonly DiMPdotNetEntities _entities;

        public BladDækningDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string GetDækningGradByBladId(int bladID)
        {
            try
            {
                var res = from dg in _entities.tblBladDækning
                    where dg.BladID == bladID
                    select new
                    {
                        dg.BladID, dg.Oplag, dg.DækningsGrad, dg.PostNr
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("BladDækningDao GetDækningGradByBladId", e.InnerException);
            }
        }


        public string GetDækningGrapPrPostNr(int postnr)
        {
            try
            {
                var res = from dp in _entities.tblBladDækning
                    where dp.PostNr == postnr
                    select new
                    {
                        dp.BladID, dp.Oplag, dp.DækningsGrad, dp.PostNr
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("BladDækningDao GetDækningGradByBladId", e.InnerException);
            }
        }

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
    }
}