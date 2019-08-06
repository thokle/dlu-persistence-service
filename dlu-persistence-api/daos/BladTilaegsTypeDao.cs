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
   public  class BladTilaegsTypeDao
    {
        private DiMPdotNetDevEntities DiMPdotNet;

        public BladTilaegsTypeDao()
        {
            DiMPdotNet = new DiMPdotNetDevEntities();
        }

        public string GetBladtillaegsTyper()
        {
            try
            {
                var res = from bt in DiMPdotNet.tblBladTillaegsTypes select new
                {
                    bt.id, bt.type
                };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }


        public Task<int> CreateOrUpdate(tblBladTillaegsType tblBladTillaegsType)
        {
            try
            {
                DiMPdotNet.tblBladTillaegsTypes.AddOrUpdate(tblBladTillaegsType);
                return DiMPdotNet.SaveChangesAsync();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
