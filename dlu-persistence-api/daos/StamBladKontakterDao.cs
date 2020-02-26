using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class StamBladKontakterDao
    {
        private DiMPdotNetDevEntities entities;

        public StamBladKontakterDao()
        {
            entities = new DiMPdotNetDevEntities();
            entities.Configuration.LazyLoadingEnabled = false;
        }


        public string GetStamBladKontakterByStambladId(int stambladid)
        {
            try
            {
                var res = from st in entities.tblStambladKontakters
                          where st.StamBladId == stambladid
                          select new
                          {
                              st.StamBladId,
                              st.KontakPersonEmail,
                              st.KontakPersonNavn,
                              st.KontakPersonTelefon,
                              st.KontakPersonTitel
                          };

                return JsonConvert.SerializeObject(res, Formatting.Indented);




            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }


        public Task<int> AddOrUpdateStamBladKontkt(tblStambladKontakter tblStambladKontakter)
        {
            entities.tblStambladKontakters.AddOrUpdate(tblStambladKontakter);
            return entities.SaveChangesAsync();


        }
    }
}
