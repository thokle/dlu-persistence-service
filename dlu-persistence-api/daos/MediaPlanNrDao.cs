using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    public class MediaPlanNrDao: IDisposable
    {
        private DiMPdotNetDevEntities _entities;

        public MediaPlanNrDao()
        {
            _entities = new DiMPdotNetDevEntities();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediePlanId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public List<MediePlanNr> GetMediePlanNrDaoByMedPlanId(int mediePlanId)
        {
            try
            {
                var res = from m in _entities.tblMedieplanNrs

                          where m.MedieplanNr == mediePlanId
                          orderby m.Status
                          select new MediePlanNr
                          {
                              AktivVersion = m.AktivVersion, AnvendtPrisberegningVersion = m.AnvendtPrisberegningVersion, AnvendtMiljoeTillaeg = m.AnvendtMiljøTillæg, BrugtGruppeVersion = m.BrugtGruppeVersion,
                              MedieplanNr = m.MedieplanNr, FakturaBemaerkning1 = m.FakturaBemærkning1, FakturaBemaerkning2 = m.FakturaBemærkning2, FakturaBemaerkning3 = m.FakturaBemærkning3, Kommentar = m.Kommentar,
                              MaterialeModtaget = m.MaterialeModtaget, OverførtFraPrisforespoergsel = m.OverførtFraPrisforespørgsel, Status = m.Status, SupportBilagVedlagt = m.SupportBilagVedlagt, SupportBilagVist = m.SupportBilagVist
                         
                            



                    };
                return res.ToList();
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
        public Tuple<string, int> CreateOrUpDateMediePlanNr(tblMedieplanNr tblMedieplanNr)
        {
            try
            {
                _entities.tblMedieplanNrs.AddOrUpdate(tblMedieplanNr);
                _entities.SaveChanges();
                var res = _entities.tblMedieplanNrs.OrderByDescending(o => o.MedieplanNr).First<tblMedieplanNr>();
                return new Tuple<string, int>("MediePlanNr", res.MedieplanNr);
             }
            catch (Exception e)
            {
                throw new  FormattedDbEntityValidationException(e.InnerException);
            }
        }
        public void Dispose()
        {
            _entities.Dispose();
        }
    }
}