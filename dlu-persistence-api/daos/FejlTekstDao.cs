using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using  dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{ /// <summary>
  /// 
  /// </summary>
    public class FejlTekstDao: IDisposable
    {
    private DiMPdotNetEntities _entities;

        
    public FejlTekstDao()
    {
        using (_entities = new DiMPdotNetEntities())
        {

            _entities.Configuration.LazyLoadingEnabled = true;
        }
    }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Task<int> CreateOrUpDateFejlTekst(tblFakturaFejl t)
        {
            try
            {
                _entities.tblFakturaFejls.AddOrUpdate(t);
                return _entities.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("CreateOrUpDateFejlTekst ", e.InnerException);
            }
        
        }

        /// <summary>
        /// Metoden 
        /// </summary>
        /// <param name="medieId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetFejlTekstDaoByMedieId(int medieId)
        {
            try
            {
                var res = from m in _entities.tblFakturaFejls
                    where m.MedieplanNr == medieId
                    orderby m.MedieplanNr
                    select
                        new { m.MedieplanNr , m.Ansvarlig , m.Version , m.FejlKode , m.UgeavisID };

                return JsonConvert.SerializeObject(res, formatting: Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetFejlTekstDaoByMedieId ", e.InnerException);
            }
        }
        /// <summary>
        /// (
        /// </summary>
        /// <param name="ansvartlig"></param>
        /// <returns></returns>
        public string GetFejlodeTekstDaoByAnsvarlig(string ansvartlig)
        {
            try
            {
                var res = from m in _entities.tblFakturaFejls
                    where m.Ansvarlig == ansvartlig
                    orderby m.Ansvarlig
                    select new
                    {
                        m.MedieplanNr, m.Ansvarlig, m.Version, m.FejlKode, m.UgeavisID
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new  FormattedDbEntityValidationException(e.InnerException);
            }
        }
        public void Dispose()
        {
            _entities?.Dispose();
        }
    }
}