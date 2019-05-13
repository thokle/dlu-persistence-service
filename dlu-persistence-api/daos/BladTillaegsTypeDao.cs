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
    public class BladTillaegsTypeDao
    {
        private DiMPdotNetEntities entities;

        public BladTillaegsTypeDao()
        {
            entities = new DiMPdotNetEntities();
        }
        public string GetBladTilKLaegs(int bladid)
        {
            try
            {

                var res = from wb in entities.tblBladTiLaegsTypes where wb.bladid == bladid

                          select new
                          {
                              wb.bladid, wb.tillaegsTypeId
                            
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
           }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }

        public Task<int> CreateBladTillaegs(tblBladTiLaegsType tblBladTiLaegsType)
        {
            try
            {
                entities.tblBladTiLaegsTypes.AddOrUpdate(tblBladTiLaegsType);
                return entities.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {
                throw new Exception(e.Message); 
            }
        }
             
    }
}
