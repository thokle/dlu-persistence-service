
using System;
using System.Data.Entity.Migrations;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{    /// <summary>
     /// 
     /// </summary>
    public class MediePlanLinjerDao: IDisposable
    {
        private DiMPdotNetDevEntities _entities;


        public MediePlanLinjerDao()
        {
            _entities = new DiMPdotNetDevEntities();
           
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="medieId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetMediePlanLinjerByMediePlanId(int medieId)
        {
            try
            {
                var res = from m in _entities.tblMedieplanLinjers
                          where m.MedieplanNr == medieId join mb in _entities.tblMedieplanÆndringer on m.MedieplanNr equals mb.MedieplanNr into mmb
                          from mb in mmb.DefaultIfEmpty()
                          join mae in _entities.tblMedieplanNrs on m.MedieplanNr equals mae.MedieplanNr into mmae
                          from mae in mmae.DefaultIfEmpty()


                          orderby m.MedieplanNr
                          select new MediePlanLinjer()
                          {

                              Bemaerkning = m.Bemærkning, BureauOrdreNr = m.BureauOrdreNr, ErWeekendGruppe = m.ErWeekendGruppe, FarveMax = m.FarveMax, FarveMin = m.FarveMin, FarvePris = m.FarvePris, FarveRabat = m.FarveRabat,
                              FarveTillaeg = m.FarveTillæg , FarveTotal = m.FarveTotal, MaaGiveMaterialeGodtgoerelse =  m.MåGiveMaterialeGodtgørelse, ManueltAendret = m.ManueltÆndret, MaterialeGodtgoerelsePris = m.MaterialeGodtgørelsePris, 
                              MaterialeNr = m.MaterialeNr, MedieplanNr = m.MedieplanNr, MedIGrupper = m.MedIGrupper , MiljoeTillaeg =   m.MiljøTillæg, Mm = m.Mm, MmPris  = m.MmPris, MmRabat = m.MmRabat,MmTotal =  m.MmTotal, MaaGiveMmRabat = m.MåGiveMmRabat, 
                              NormalMmPris = m.NormalMmPris, PrisLaast = m.PrisLåst, RabatGruppe = m.RabatGruppe , SendeGruppe = m.SendeGruppe, SkalGiveMaterialeGodtgoerelse = m.SkalGiveMaterialeGodtgørelse, Total = m.Total, TotalInclTillaeg = m.TotalInclTillæg, 
                              TotalPris = m.TotalPris ,  UgeavisID = m.UgeavisID , Version = m.Version , WebtillaegFaktureresHer = m.WebtillægFaktureresHer ,MaaGiveRabat= m.MåGiveMmRabat
                            
                           };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("MediePlanLinjerDao GetMediePlanLinjerByMediePlanId ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblMedieplanLinjer"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public int CreateOrUpdateMediePlanLinjer(tblMedieplanLinjer tblMedieplanLinjer)
        {
            int res = 0;
            try
            {
            _entities.tblMedieplanLinjers.AddOrUpdate(tblMedieplanLinjer);
               res = _entities.SaveChanges();

                return res;
            }
            catch (Exception e) 
            {
                throw new Exception();
            }
           

        }


        public MediePlanLinjer GetMediePlanLinjerForNavision(int indrykningsuge) {
            var res = (from mp in _entities.tblMedieplanLinjers
                       join mpnr in _entities.tblMedieplanNrs on mp.MedieplanNr equals mpnr.MedieplanNr into mpmnpr
                       from mpnr in mpmnpr.DefaultIfEmpty()
                       where mpnr.AktivVersion == 6
                       select new MediePlanLinjer() { }).OrderByDescending(e => e.MedieplanNr).SingleOrDefault();

            return res;
        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}