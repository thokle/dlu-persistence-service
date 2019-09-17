using System;
using System.Linq;
using  dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using dlu_persistence_api.models;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    public class DelOmraadeDao
    {
        private DiMPdotNetDevEntities _entities;

        public DelOmraadeDao()
        {
         _entities = new DiMPdotNetDevEntities();
       
        }


        public List<DelOmraade>  GetAllRegions()
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
                return res.ToList();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }
        
        public DelOmraade GetDelOmraadeById(int delomraadeId)
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
                return res.Single<DelOmraade>();
                
            }catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
            
        }
        
    }
}