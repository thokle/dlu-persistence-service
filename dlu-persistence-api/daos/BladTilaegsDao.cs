using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;


namespace dlu_persistence_api.daos
{
    public class BladTilaegsDao
    {
        private DiMPdotNetDevEntities entities;

        public BladTilaegsDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<BladTillæg> GetTillaegsTypeByBladId(int bladid)
        {
            try
            {
                var res = (from bl in entities.tblBladTillaegs
                           join d in entities.tblBladTillaegsTypes on bl.typeId equals d.id into ds
                           from d in ds.DefaultIfEmpty()
                           where bl.bladId == bladid
                           select new BladTillæg()
                           {
                               BladId = bl.bladId,
                               Pris = bl.pris,
                               type = d.type,
                               fastpris = bl.fastpris,
                               mmpris = bl.mmpris


                           }).ToList<BladTillæg>();
                return res;
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
