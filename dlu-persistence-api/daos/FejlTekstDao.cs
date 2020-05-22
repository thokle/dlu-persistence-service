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

        public List<FejlTekstModel> GetFejlTekster()
        {


            var res = (from mpnr in _entities.tblMedieplanNrs

                       join mp in _entities.tblMedieplans on mpnr.MedieplanNr equals mp.MedieplanNr

                       join anck in _entities.tblAnnoncekontrols on mp.MedieplanNr equals anck.MedieplanNr
                       join fejl in _entities.tblFejlTeksts on anck.Fejlkode equals fejl.Fejlkode
                       join nav in _entities.NavisionContacts on mp.AnnoncørNo_ equals nav.No_
                       join stm in _entities.tblBladStamdatas on anck.UgeavisID equals stm.BladID
                       where anck.Fejlkode > 0 && anck.Ansvar != "" && mp.Status == 1 && mp.Version == mpnr.AktivVersion

                       select new
                       {

                           mp.Version,
                           mp.MedieplanNr,
                           stm.Navn,

                           AnnoncørNo_ = nav.No_,
                           mp.IndrykningsUge,

                           anck.UgeavisID,
                           anck.Fejlkode
                       });

            return res.ToList().Select(ds => new FejlTekstModel()
            {
                Nr = OpretNummer(ds.MedieplanNr, ds.Version),
                Navn = ds.Navn,
                IndrykningsUge = ds.IndrykningsUge,
                FejlTekst = OpretFejlTekst(ds.Fejlkode),
                AnnoncørNo_ = ds.AnnoncørNo_,
                UgeavisID = ds.UgeavisID,
                MedieplanNr = ds.MedieplanNr

            }).ToList();

        }

        public List<FejlTekstModel> GetFejlTekstModelsRaw()
        {
            var res = _entities.Database.SqlQuery<FejlTekstModel>(RawSQL.sql);
            return res.ToList();
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
        public string FejlTekst { get; set; }
        public string Navn { get; set; }
        public Int32 MedieplanNr { get; set; }
        public Int16 Version { get; set; }
        public Int32 UgeavisID { get; set; }
        public string AnnoncørNo_ { get; set; }
        public string Nr { get; set; }

        public byte IndrykningsUge { get; set; }


    }

    public class RawSQL
    {
        public static string sql = "SELECT        CASE WHEN tblMedieplan.Version < 10 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + LTRIM(STR(tblMedieplan.Version)) " 
                  + "   WHEN tblMedieplan.Version > 10 AND tblMedieplan.Version< 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) "
                  + "   + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1)  "
                   + "  WHEN tblMedieplan.Version > 100 THEN LTRIM(STR(tblMedieplan.MedieplanNr)) + '-' + RIGHT(LTRIM(tblMedieplan.Version / 100), 1)  "
                   + "  + '-' + RIGHT(LTRIM(tblMedieplan.Version / 10), 1) + '-' + RIGHT(LTRIM(tblMedieplan.Version), 1) END AS Nr, tblBladStamdata.Navn,  "
                  + "  tblAnnoncekontrol.MedieplanNr, tblMedieplan.Version, NavisionContact.Name AS AnnoncørNo_,  "
                    + "  CASE WHEN tblAnnoncekontrol.Fejlkode = 7 THEN tblFejlTekst.FejlTekst + ' Ny Side: ' + tblAnnoncekontrol.IndrykketPåSide + ' Pris: ' + tblAnnoncekontrol.FaktureresTil "
                    + "   ELSE tblFejlTekst.FejlTekst END AS FejlTekst, tblAnnoncekontrol.UgeavisID, tblMedieplan.IndrykningsUge "
+ " FROM            tblMedieplanNr "
+ " INNER JOIN tblMedieplan ON tblMedieplanNr.MedieplanNr = tblMedieplan.MedieplanNr AND "
+ " tblMedieplanNr.AktivVersion = tblMedieplan.Version  INNER JOIN "
+ "tblAnnoncekontrol INNER JOIN tblFejlTekst ON tblAnnoncekontrol.Fejlkode = tblFejlTekst.Fejlkode ON tblMedieplanNr.MedieplanNr = tblAnnoncekontrol.MedieplanNr "
            + "  INNER JOIN "
             + "  NavisionContact ON tblMedieplan.AnnoncørNo_ = NavisionContact.No_ INNER JOIN "
                + "   tblBladStamdata ON tblAnnoncekontrol.UgeavisID = tblBladStamdata.BladID "
 + "  WHERE        (tblAnnoncekontrol.Fejlkode > 0) AND(tblAnnoncekontrol.Ansvar = '') AND(tblMedieplan.Status = 1)";
    }

}