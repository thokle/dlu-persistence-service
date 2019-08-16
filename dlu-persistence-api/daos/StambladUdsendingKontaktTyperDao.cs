using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
   public class StambladUdsendingKontaktTyperDao
    {
        private DiMPdotNetDevEntities entities;

        public StambladUdsendingKontaktTyperDao()
        {
            entities = new DiMPdotNetDevEntities();
            entities.Configuration.LazyLoadingEnabled = true;
        }


        public string GetStamBladUdsendingKontaktType()
        {
            try
            {
                var res = from suk in entities.tblStambladUdsendingEmailTypers select new
                {
                    suk.id, suk.titel                   
                };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException  e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
