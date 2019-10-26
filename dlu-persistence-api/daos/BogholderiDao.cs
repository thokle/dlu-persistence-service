using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class BogholderiDao
    {

        private DiMPdotNetDevEntities di;
        public BogholderiDao()
        {
            di = new DiMPdotNetDevEntities();
        }

        public int AddOrUpdateBogholderi(tblStamBladBogHolderi tblStamBladBogHolderi) {
            di.tblStamBladBogHolderis.AddOrUpdate(tblStamBladBogHolderi);
            return di.SaveChanges();

        }

        public StamBladBogHolderi GetStamBladBogHolderiByBladId(int bladid , int id)
        {

            try
            {
                var res = (from s in di.tblStamBladBogHolderis
                          where s.Bladid == bladid && s.id == id
                          select new StamBladBogHolderi()
                          {
                              Id = s.id,
                              Bladid = s.Bladid,
                              Kontakt = s.Kontakt,
                              NavisioID = s.NavisioID,
                              NavisionId = s.NavisionId
                          }).FirstOrDefault<StamBladBogHolderi>();
                return res;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
