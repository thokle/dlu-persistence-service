using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class StambladKontaktPersonDao
    {
        private DiMPdotNetEntities entities;

        public StambladKontaktPersonDao()
        {
            this.entities = new DiMPdotNetEntities();
        }


        public string GetKontaktPersonerByBladID(int bladId)
        {
            try
            {
                var res = from sbk in entities.StamBladKontaktPersoners
                    where sbk.StamBladId == bladId
                    select new
                    {
                        sbk.StamBladId,
                        sbk.KontakPersonNavn, 
                        sbk.KontakPersonEmail,
                        sbk.KontakPersonTitel,
                        sbk.KontakPersonTelefon
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public Task<int> CreateOrUpdateKontaktPerson(StamBladKontaktPersoner personer)
        {
            try
            {
               entities.StamBladKontaktPersoners.AddOrUpdate(personer);
               return entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
        
      
    }
}