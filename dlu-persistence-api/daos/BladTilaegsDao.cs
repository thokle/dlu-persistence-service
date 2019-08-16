using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
   public class BladTilaegsDao
    {
        private DiMPdotNetDevEntities entities;

        public BladTilaegsDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public string GetTillaegsTypeByBladId(int bladid)
        {
            try
            {
                var res = from bl in entities.tblBladTillaegs
                          join d in entities.tblBladTillaegsTypes on bl.typeId equals d.id into ds
                          from d in ds.DefaultIfEmpty()
                          where bl.bladId == bladid
                          select new
                          {
                              bl.bladId,
                              bl.pris,
                              d.type
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
             }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<int> CreateOrUpdate(tblBladTillaeg tblBladTillaeg)
        {
            try
            {
                entities.tblBladTillaegs.AddOrUpdate(tblBladTillaeg);
                return entities.SaveChangesAsync();
              
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
          
            
        }
    }
}
