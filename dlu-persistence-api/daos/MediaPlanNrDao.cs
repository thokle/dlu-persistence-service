using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
namespace dlu_persistence_api.daos
{
    public class MediaPlanNrDao
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
        public MediePlanNr GetMediePlanNrDaoByMedPlanId(int mediePlanId)
        {
            try
            {
                var res = from m in _entities.tblMedieplanNrs

                          where m.MedieplanNr == mediePlanId
                          orderby m.Status
                          select new MediePlanNr
                          {
                              AktivVersion = m.AktivVersion,
                              AnvendtPrisberegningVersion = m.AnvendtPrisberegningVersion,
                              AnvendtMiljoeTillaeg = m.AnvendtMiljøTillæg,
                              BrugtGruppeVersion = m.BrugtGruppeVersion,
                              MedieplanNr = m.MedieplanNr,
                              FakturaBemaerkning1 = m.FakturaBemærkning1,
                              FakturaBemaerkning2 = m.FakturaBemærkning2,
                              FakturaBemaerkning3 = m.FakturaBemærkning3,
                              Kommentar = m.Kommentar,
                              MaterialeModtaget = m.MaterialeModtaget,
                              OverførtFraPrisforespoergsel = m.OverførtFraPrisforespørgsel,
                              Status = m.Status,
                              SupportBilagVedlagt = m.SupportBilagVedlagt,
                              SupportBilagVist = m.SupportBilagVist





                          };
                return res.FirstOrDefault();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MediaPlanNrDao GetMediePlanNrDaoByMedPlanId ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMedieplanNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Tuple<int, int, short> CreateOrUpDateMediePlanNr(tblMedieplanNr tblMedieplanNr)
        {
            try
            {
                _entities.tblMedieplanNrs.AddOrUpdate(tblMedieplanNr);
                var s = _entities.SaveChanges();
                var mediePlanNr = GetNextMediePlanNr();
                return new Tuple<int, int, short>(s, mediePlanNr.Item1, mediePlanNr.Item2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Create Or UpdateMediePlanNr Error " + e.InnerException + " " + e.StackTrace);
                throw new Exception();
            }
        }


        private Tuple<int, short> GetNextMediePlanNr()
        {
            try
            {
                var res = _entities.tblMedieplanNrs.OrderByDescending(s => s.MedieplanNr).First();
                return new Tuple<int, short>(res.MedieplanNr, res.AktivVersion);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Get NextMedioePlanNr Error " + ex.StackTrace);
                throw new Exception();
            }


        }


    }

    class MediePlanNummner
    {
        private int medieplanNr;

        public int MediePlanNr
        {
            get { return medieplanNr; }
            set { value = medieplanNr; }
        }
    }
}