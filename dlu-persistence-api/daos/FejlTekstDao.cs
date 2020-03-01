using dlu_persistence_api.exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{ /// <summary>
  /// 
  /// </summary>
    public class FejlTekstDao
    {
       
        private DiMPdotNetDevEntities _entities;


        public FejlTekstDao()
        {
            _entities = new DiMPdotNetDevEntities();
           
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
                              new { m.MedieplanNr, m.Ansvarlig, m.Version, m.FejlKode, m.UgeavisID };

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
        /// tblMedieplanNr.MedieplanNr =    tblAnnoncekontrol.MedieplanNr
        public string GetFejlodeTekstDaoByAnsvarlig(string ansvartlig)
        {
         
            try
            {
                var res = from m in _entities.tblFakturaFejls
                          where m.Ansvarlig == ansvartlig
                          orderby m.Ansvarlig
                          select new
                          {
                              m.MedieplanNr,
                              m.Ansvarlig,
                              m.Version,
                              m.FejlKode,
      
                          };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public List<FejlTekstModel>  GetFejlTekster()
        {
            return (from mpnr in _entities.tblMedieplanNrs
                    join mp in _entities.tblMedieplans on mpnr.MedieplanNr equals mp.MedieplanNr into mpnrmp
                    from mp in mpnrmp.DefaultIfEmpty()
                    join mpv in _entities.tblMedieplans on mpnr.AktivVersion equals mpv.Version into mpvmpnr
                    from mpv in mpvmpnr.DefaultIfEmpty()
                    join anck in _entities.tblAnnoncekontrols on mp.MedieplanNr equals anck.MedieplanNr into anckmp
                    from anck in anckmp.DefaultIfEmpty()
                    join fejl in _entities.tblFejlTeksts on anck.Fejlkode equals fejl.Fejlkode into fejlanck
                    from fejl in fejlanck.DefaultIfEmpty()
                    join nav in _entities.NavisionContacts on mp.AnnoncørNo_ equals nav.No_ into navmp
                    from nav in navmp.DefaultIfEmpty()
                    join stm in _entities.tblBladStamdatas on anck.UgeavisID equals stm.BladID into stmanck
                    from stm in stmanck.DefaultIfEmpty()
                    where anck.Fejlkode > 0 && anck.Ansvar.Equals(" ") && mp.Status == 1 && mp.MedieplanNr  == anck.MedieplanNr
                    select new
                    {

                        Version = mp.Version,
                        MedieplanNr = mp.MedieplanNr,
                        Navn = stm.Navn,

                        AnnoncørNo_ = nav.Name,
                        mp.IndrykningsUge,

                        anck.UgeavisID,
                        anck.Fejlkode
                    }).ToList().Select(ds => new FejlTekstModel()
                    {
                        Nr = OpretNummer(ds.MedieplanNr, ds.Version),
                        Navn = ds.Navn,
                        IndrykningsUge = ds.IndrykningsUge,
                        FejlTekst = OpretFejlTekst(ds.Fejlkode)
                        , MedieplanNr = ds.MedieplanNr
                     
                    }).Distinct().ToList();

        }

        private string OpretNummer(int medieplanNr, short version)
        {
            return "88000-1-1";
        }
        
        private string OpretFejlTekst(int kode)
        {
            return "Fejl tekst";
        }
    }

    
    public class FejlTekstModel
    {
        public string FejlTekst;
        public string Navn;
        public int MedieplanNr;
        public int Version;
        public int UgeavisID;
        public string AnnoncørNo_;
        public string Nr;
       
        public byte IndrykningsUge;


    }
}