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
    public class BladKommentarDao
    {
        private DiMPdotNetEntities entities;

        public BladKommentarDao()
        {
            entities = new DiMPdotNetEntities();
        }

        public string GetKommentarByStamBladId(int bladid)
        {
            try
            {
                var res = from bk in entities.tblBladKommentars
                          where bk.bladid == bladid
                          orderby bk.date
                          select new
                          {
                              bk.bladid, bk.tekst, bk.date
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }


        public Task<int> CreateBladKommentar(tblBladKommentar tblBladKommentar)
        {
            try
            {
                entities.tblBladKommentars.AddOrUpdate(tblBladKommentar);
                return entities.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
            
        }

    }
}
