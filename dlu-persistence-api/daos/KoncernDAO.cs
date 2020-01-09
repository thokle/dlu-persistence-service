using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class KoncernDAO
    {

        private DiMPdotNetDevEntities entities;

        public KoncernDAO()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<Koncern> GetKoncerns()
        {
            try
            {
                var res = from k in entities.tblKoncerns
                          orderby k.koncernnavn ascending
                          select new Koncern()
                          {
                              koncern_name = k.koncernnavn,

                          };

                return res.ToList<Koncern>();

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }
    }
}
