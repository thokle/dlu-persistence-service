using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class MediePlanLinjerDao
    {
        private DiMPdotNetEntities _entities;


        public MediePlanLinjerDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
                
            }
        }


        public string GetMediePlanLinjerByMediePlanId(int medieId)
        {


            var res = from m in _entities.tblMedieplanLinjers
                where m.MedieplanNr == medieId
                orderby m.MedieplanNr
                select new
                {
                    m.Bemærkning, m.Mm, m.Total, m.Version, m.FarveMax, m.FarveMin, m.FarveRabat, m.FarvePris, m.FarveTillæg, m.FarveTotal, m.ManueltÆndret, m.NormalMmPris
                    
                };
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }


        public Task<int> CreateOrUpdateMediePlanLinjer(tblMedieplanLinjer tblMedieplanLinjer)
        {
            _entities.tblMedieplanLinjers.AddOrUpdate(tblMedieplanLinjer);
            return _entities.SaveChangesAsync();

        }

    }
}