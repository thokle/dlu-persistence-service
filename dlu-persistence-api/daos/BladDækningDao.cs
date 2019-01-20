using System;
using System.CodeDom;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class BladDækningDao
    {
        private DiMPdotNetEntities _entities;

        public BladDækningDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }

        public string GetDækningGradByBladId(int bladID)
        {
            var res = from dg in _entities.tblBladDækning
                where dg.BladID == bladID
                select new
                {
                    dg.BladID, dg.Oplag, dg.DækningsGrad, dg.PostNr
                };
            return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
        }


        public string GetDækningGrapPrPostNr(int postnr)
        {
            var res = from dp in _entities.tblBladDækning
                where dp.PostNr == postnr
                select new
                {
                    dp.BladID, dp.Oplag, dp.DækningsGrad, dp.PostNr
                };
            
            return  JsonConvert.SerializeObject(res, Formatting.Indented);
        }

        public Task<int> OpretBladDækning(tblBladDækning tblBladDækning)
        {
            _entities.tblBladDækning.AddOrUpdate(tblBladDækning);

            return _entities.SaveChangesAsync();
        }
    }
}