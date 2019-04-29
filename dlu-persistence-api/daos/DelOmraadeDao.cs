using System;
using System.Linq;
using  dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using dlu_persistence_api.models;

namespace dlu_persistence_api.daos
{
    public class DelOmraadeDao
    {
        private DiMPdotNetEntities _entities;

        public DelOmraadeDao()
        {
         _entities = new DiMPdotNetEntities();
       
        }


        public string GetAllRegions()
        {
            try
            {
                var res = from ls in _entities.tblDelOmråde select 
                    new DelOmraade()
                    {
                        DelOmraadeId = ls.DelOmrådeID,
                        DelOmraadeKode1 = ls.DelOmrådeKode,
                        DelOmraadeNavn1 = ls.DelOmrådeNavn,
                        DelOmraadeSortKey1 =  ls.DelOmrådeSortKey,
                        Timestamp = ls.timestamp
                      
                        
                       };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
        
        public string GetDelOmraadeById(int delomraadeId)
        {
            try
            {
                var res = from ls in _entities.tblDelOmråde
                          where ls.DelOmrådeID == delomraadeId
                          select new DelOmraade()
                          {
                              DelOmraadeId = ls.DelOmrådeID,
                              DelOmraadeKode1 = ls.DelOmrådeKode,
                              DelOmraadeNavn1 = ls.DelOmrådeNavn,
                              DelOmraadeSortKey1 = ls.DelOmrådeSortKey,
                              Timestamp = ls.timestamp
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
                
            }catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
            
        }
        
    }
}