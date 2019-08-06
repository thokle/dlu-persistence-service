using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
   
    public     class GeoDao
    {
        public DiMPdotNetDevEntities entities;
        public GeoDao()
        {
            entities = new DiMPdotNetDevEntities();
        }


        public string GetGeoCodeById(int geocodeid)
        {
            try
            {
                var res = from gc in entities.tblGeoKodes
                          where gc.GeoKodeID == geocodeid
                          select new
                          {
                              gc.GeoKodeID,
                              gc.GeoKodeNavn,
                              gc.GeoKodeSortKey

                          };
                   return JsonConvert.SerializeObject(res, Formatting.Indented);
            } catch(Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
    }
}
