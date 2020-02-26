using dlu_persistence_api.exceptions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace dlu_persistence_api.daos
{
    public class BladTilaegsTypeDao
    {
        private DiMPdotNetDevEntities DiMPdotNet;

        public BladTilaegsTypeDao()
        {
            DiMPdotNet = new DiMPdotNetDevEntities();
        }

        public List<tblBladTillaegsType> GetBladtillaegsTyper()
        {
            try
            {
                var res = from bt in DiMPdotNet.tblBladTillaegsTypes
                          select new tblBladTillaegsType
                          {
                              id = bt.id,
                              type = bt.type
                          };

                return res.ToList();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }


        public int CreateOrUpdate(tblBladTillaegsType tblBladTillaegsType)
        {
            try
            {
                DiMPdotNet.tblBladTillaegsTypes.AddOrUpdate(tblBladTillaegsType);
                return DiMPdotNet.SaveChanges();
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
