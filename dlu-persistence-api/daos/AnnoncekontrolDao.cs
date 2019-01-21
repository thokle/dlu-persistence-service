using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;
using  dlu_persistence_api.exceptions;

namespace dlu_persistence_api.daos
{/// <summary>
 /// 
 /// </summary>
    public class AnnoncekontrolDao : IDisposable
    {
        private DiMPdotNetEntities _entities;


        public AnnoncekontrolDao()
        {
            using (_entities = new DiMPdotNetEntities())
            {
                _entities.Configuration.LazyLoadingEnabled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediePlan"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetAnnoceKontrolByMediePlanId(int mediePlan)
        {
           
            try
            {
                var res = from an in _entities.tblAnnoncekontrols
                    where an.MedieplanNr == mediePlan
                    select new
                    {

                        an.MedieplanNr, an.Ansvar, an.Fejlkode, an.ErKontrolleret, an.FaktureresTil, an.KontrollørEmail,
                        an.KontrolTidspunkt,
                        an.SidePlacering,
                        an.tblFejlTekst.FejlTekst, an.IndrykketPåSide, an.UgeavisID, an.KontrolleretAfDLU
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (Exception a)
            {

                throw new DaoExceptions(" AnnoncekontrolDao GetAnnoceKontrolByMediePlanId", a.InnerException);
            }

            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetAnnonceKontrolByEmail(string email)
        {
            try
            {
                var res = from an in _entities.tblAnnoncekontrols
                    where an.KontrollørEmail == email
                    select new
                    {
                        an.MedieplanNr, an.Ansvar, an.Fejlkode, an.ErKontrolleret, an.FaktureresTil, an.KontrollørEmail,
                        an.KontrolTidspunkt,
                        an.SidePlacering,
                        an.tblFejlTekst.FejlTekst, an.IndrykketPåSide, an.UgeavisID, an.KontrolleretAfDLU
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);

            }
            catch (Exception e)
            {
                throw new DaoExceptions(" AnnoncekontrolDao GetAnnonceKontrolByEmail", e.InnerException);
            }
        }


    public Task<int> CreateOrUpdate(tblAnnoncekontrol tblAnnoncekontrol)
        {
            try
            {
                _entities.tblAnnoncekontrols.AddOrUpdate(tblAnnoncekontrol);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                
                throw  new DaoExceptions("AnnoncekontrolDao CreateOrUpdate", e.InnerException);
           }
        }
           
        
        
        
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}