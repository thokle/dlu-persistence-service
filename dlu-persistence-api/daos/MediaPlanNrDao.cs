using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
namespace dlu_persistence_api.daos
{
    public class MediaPlanNrDao: IDisposable
    {
        private DiMPdotNetEntities _entities;

        public MediaPlanNrDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediePlanId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetMediePlanNrDaoByMedPlanId(int mediePlanId)
        {
            try
            {
                var res = from m in _entities.tblMedieplanNrs

                    where m.MedieplanNr == mediePlanId
                    orderby m.Status
                    select new
                    {
                        m.MedieplanNr, m.AktivVersion, m.Status, m.SupportBilagVedlagt, m.SupportBilagVist,
                        m.FakturaBemærkning1, m.FakturaBemærkning2, m.FakturaBemærkning3, m.MaterialeModtaget,
                        m.AnvendtMiljøTillæg, m.AnvendtPrisberegningVersion, m.BrugtGruppeVersion,
                        m.OverførtFraPrisforespørgsel



                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MediaPlanNrDao GetMediePlanNrDaoByMedPlanId " , e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMedieplanNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateOrUpDateMediePlanNr(tblMedieplanNr tblMedieplanNr)
        {
            try
            {
                _entities.tblMedieplanNrs.AddOrUpdate(tblMedieplanNr);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new  DaoExceptions(" MediaPlanNrDao CreateOrUpDateMediePlanNr ", e.InnerException);
            }
        }
        public void Dispose()
        {
            _entities.Dispose();
        }
    }
}