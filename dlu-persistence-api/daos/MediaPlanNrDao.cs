using System;
using System.Linq;
using AutoMapper.QueryableExtensions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class MediaPlanNrDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public MediaPlanNrDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                
            }
        }

        public string GetMediePlanNrDaoByMedPlanId(int mediePlanId)
        {
            var res = from m in _entities.tblMedieplanNrs
        
                where m.MedieplanNr == mediePlanId
                orderby m.Status
                select new
                {
                    m.MedieplanNr, m.AktivVersion, m.Status, m.SupportBilagVedlagt, m.SupportBilagVist, m.FakturaBemærkning1, m.FakturaBemærkning2, m.FakturaBemærkning3, m.MaterialeModtaget, m.AnvendtMiljøTillæg, m.AnvendtPrisberegningVersion, m.BrugtGruppeVersion, m.OverførtFraPrisforespørgsel
                        
                   
                    
                };
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }

        public void Dispose()
        {
            _entities.Dispose();
        }
    }
}