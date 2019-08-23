
using System;
using System.Data.Entity.Migrations;

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dlu_persistence_api.exceptions;
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
                    select new
                    {
                        m.UgeavisID , m.BureauOrdreNr, m.ErWeekendGruppe, m.MmRabat, m.MmTotal, m.Total, m.WebtillægFaktureresHer, m.TotalPris,
                        m.Bemærkning, m.Mm, m.Version, m.FarveMax, m.FarveMin, m.FarveRabat, m.FarvePris,
                        m.FarveTillæg, m.FarveTotal, m.ManueltÆndret, m.NormalMmPris , mb.ÆndringsTekst, mae.Kommentar,mae.MaterialeModtaget,mae.OverførtFraPrisforespørgsel, mae.Status, mae.SupportBilagVedlagt, mae.SupportBilagVist, mae.AktivVersion, mae.AnvendtMiljøTillæg, mae.AnvendtPrisberegningVersion, mae.BrugtGruppeVersion,
                        mae.FakturaBemærkning1, mae.FakturaBemærkning2, mae.FakturaBemærkning3
                    
                 
                      
                        

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
        public Task<int> CreateOrUpdateMediePlanLinjer(tblMedieplanLinjer tblMedieplanLinjer)
        {
            try
            {
                _entities.tblMedieplanLinjers.AddOrUpdate(tblMedieplanLinjer);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }

        }

        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}