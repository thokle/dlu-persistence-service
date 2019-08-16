using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class KontaktTitlerDao
    {
        private DiMPdotNetDevEntities entities;

        public KontaktTitlerDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public string GetTitler()
        {
            try
            {
                var res = from di in entities.tblKontaktTitlers
                          select new
                          {
                            di.TitelID, di.Titel
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
