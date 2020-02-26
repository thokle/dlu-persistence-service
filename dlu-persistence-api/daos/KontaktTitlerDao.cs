using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Data.Entity.Migrations;
using System.Linq;

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
                              di.TitelID,
                              di.Titel
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }


        }

        public int CreateOrUpdate(tblKontaktTitler tblKontaktTitler)
        {
            entities.tblKontaktTitlers.AddOrUpdate(tblKontaktTitler);
            return entities.SaveChanges();
        }
    }
}
