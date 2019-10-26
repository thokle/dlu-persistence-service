using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System.Collections.Generic;
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


        public List<StambladUdsendingEmailTyper> GetStamBladUdsendingKontaktType()
        {
            try
            {
                var res = from suk in entities.tblStambladUdsendingEmailTypers
                          select new StambladUdsendingEmailTyper
                          {
                              id = suk.id,
                              titel = suk.titel
                          };

                return res.ToList<StambladUdsendingEmailTyper>();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
