using System;
using System.Collections.Generic;
using System.Linq;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{

    public     class GeoDao
    {
        public DiMPdotNetDevEntities entities;
        public GeoDao()
        {
            entities = new DiMPdotNetDevEntities();
        }

        public List<GeoKode> GetGeoCodes()
        {
            try
            {
                var res = from gc in entities.tblGeoKodes
                          orderby gc.GeoKodeSortKey ascending
                          select new GeoKode
                          {
                              GeoKodeID1 = gc.GeoKodeID,
                              GeoKodeNavn1 = gc.GeoKodeNavn,
                            
                          };
                return res.ToList<GeoKode>();
            }
            catch (Exception e)
            {

                throw new Exception(e.HelpLink);
            }
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
