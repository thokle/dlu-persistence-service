using System.Linq;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class RegionDao
    {
        private DiMPdotNetEntities _entities;

        public RegionDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }


        public string GetRegions()
        {
            var res = from r in _entities.tblRegions
                orderby r.RegionNavn, r.RegionID
                select new
                {

                    r.RegionID, r.RegionNavn, r.timestamp, r.RegionSortKey
                };

            return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);

        }
    }
}