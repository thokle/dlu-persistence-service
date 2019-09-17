using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using dlu_persistence_api.exceptions;
using System.Collections.Generic;
namespace dlu_persistence_api.daos
{
    /// <summary>
    /// 
    /// </summary>
    public class StamBladsDao
    {
        private DiMPdotNetDevEntities di;

        public StamBladsDao()
        {
            di = new DiMPdotNetDevEntities();
            di.Configuration.LazyLoadingEnabled = false;
        }

        public StamBlad GetTblBladStamdataByBladId(int bladId)
        {
            try
            {
                var res = (from en in di.tblBladStamdatas
                           join d in di.tblDages on en.UgedagID equals d.DagID into ds
                           from d in ds.DefaultIfEmpty()
                           join r in di.tblRegions on en.RegionID equals r.RegionID into rs
                           from r in rs.DefaultIfEmpty()
                           join h in di.tblHovedGruppes on en.HovedgruppeID equals h.HovedGruppeID into hs
                           from h in hs.DefaultIfEmpty()
                           join de in di.tblDelOmråde on en.DelOmrådeID equals de.DelOmrådeID into des
                           from de in des.DefaultIfEmpty()

                           join g in di.tblGeoKodes on en.GeoKodeID equals g.GeoKodeID into gs
                           from g in gs.DefaultIfEmpty()


                           where en.BladID == bladId

                           select new StamBlad
                           {
                               BladId = en.BladID,
                               Navn = en.Navn.Trim(),
                               Navn2 = en.Navn2.Trim(),
                               MatGodtBeloeb = en.MatGodtBeløb,
                               MedlemAAr = en.MedlemÅr,
                               Cvr = en.CVR,
                               Fax = en.Fax,

                               Tlf = en.Tlf,
                               Oplag = en.Oplag,
                               Emails = en.Emails,

                               Format = en.Format,
                               Adresse = en.Adresse,
                               Koncern = en.Koncern,
                               Ophoert = en.Ophørt,

                               Primaer = en.Primær,
                               Adresse2 = en.Adresse2,
                               Overfoert = en.Overført,
                               Timestamp = en.timestamp,
                               Hjemmeside = en.Hjemmeside,
                               Ejerforhold = en.Ejerforhold,
                               Totalomraade = en.Totalområde,
                               Kontaktperson = en.Kontaktperson,
                               OrienteringEmails = en.OrienteringEmails,
                               PostNr = en.PostNr,
                               RegionId = en.RegionID,
                               UgedagId = en.UgedagID,
                               OrdreEmail = en.OrdreEmail,
                               PrimaerPct = en.PrimærPct,
                               GruppeRabat = en.GruppeRabat,
                               AnnonceEmail = en.AnnonceEmail,
                               setMedlemMaaned = en.MedlemMåned,

                               HovedgruppeId = en.HovedgruppeID,
                               StamdataEmail = en.StamdataEmail,
                               MaterialeEmail = en.MaterialeEmail,
                               RedaktionEmail = en.RedaktionEmail,
                               OrdrecheckEmail = en.OrdrecheckEmail,
                               TotalomraadePct = en.TotalområdePct,
                               BilagsbladeEmail = en.BilagsbladeEmail,
                               BogholderiEmails = en.BogholderiEmails,
                               OrdredeadlineTekst = en.OrdredeadlineTekst,
                               SendetidOrdrecheck = en.SendetidOrdrecheck,
                               OrdredeadlineRubrik = en.OrdredeadlineRubrik,
                               SamannonceringsRabat = en.SamannonceringsRabat,
                               KontaktpersonerEmails = en.KontaktpersonerEmails,
                               MaterialedeadlineTekst = en.MaterialedeadlineTekst,

                               MaterialedeadlineRubrik = en.MaterialedeadlineRubrik,
                               MaterialeDeadlineRubrikKl = en.MaterialeDeadlineRubrikKl,
                               PrisforespoergselEmails = en.PrisforespørgselEmails,
                               GeoKodeId = en.GeoKodeID,
                               VisPaaWww = en.VisPåWWW,
                               DelOmraadeId = en.DelOmrådeID,
                               OrdreDeadlineTekstDag = en.OrdreDeadlineTekstDag,
                               OrdreDeadlineRubrikDag = en.OrdreDeadlineRubrikDag,
                               OrdreDeadlineRubrikKl = en.OrdreDeadlineRubrikKl,
                               MedieNetKode = en.MedieNetKode,
                               SalgsGruppeId = en.SalgsGruppeID,
                               FakturaGruppeId = en.FakturaGruppeID,
                               GiverWebTillaeg = en.GiverWebTillæg,
                               SendIndevaerendeUge = en.SendIndeværendeUge,
                               AnnonceKontrolEmail = en.AnnonceKontrolEmail,
                               MaaGiveFarveRabat = en.MåGiveFarveRabat,
                               OrdrecheckSendeDagId = en.OrdrecheckSendeDagID,
                               WwwDaekningSomTekst = en.WWWDækningSomTekst,
                               MaterialeDeadlineTekstKl = en.MaterialeDeadlineTekstKl,
                               OrdreDeadlineTekstKl = en.OrdreDeadlineTekstKl,
                               MaterialeDeadlineTekstDag = en.MaterialeDeadlineTekstDag,
                               MaterialeDeadlineRubrikDag = en.MaterialeDeadlineRubrikDag,
                               DelOmraadeNavn = de.DelOmrådeNavn,
                               BogholderiKontaktperson = en.Kontaktperson,
                               DiMpDelOmraadeKode = en.DiMPDelOmrådeKode,
                               DagNavn = d.DagNavn,
                               RegionNavn = r.RegionNavn,
                               HovedGruppeNavn = h.HovedGruppeNavn,
                               GeoKodeNavn = g.GeoKodeNavn



                           }).Single();

                return res ;
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bladId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetStamDataById(int bladId)
        {
            try
            {
                var res = from en in di.tblBladStamdatas 
                        join d in di.tblDages on en.UgedagID equals d.DagID into ds
                        from d in ds.DefaultIfEmpty()
                        join r in di.tblRegions on en.RegionID equals r.RegionID into  rs
                        from r in  rs.DefaultIfEmpty()
                        join h in di.tblHovedGruppes on en.HovedgruppeID equals h.HovedGruppeID into hs
                        from  h in  hs.DefaultIfEmpty()
                        join de in di.tblDelOmråde on en.DelOmrådeID equals de.DelOmrådeID into des
                        from de in des.DefaultIfEmpty()

                        join g in di.tblGeoKodes on en.GeoKodeID equals g.GeoKodeID into gs
                        from g in gs.DefaultIfEmpty()

                        
                          where en.BladID == bladId

                        
                        
                        
                    let p = new StamBlad()
                    {
                        BladId = en.BladID,
                        Navn = en.Navn.Trim(),
                        Navn2 = en.Navn2.Trim(),
                        MatGodtBeloeb = en.MatGodtBeløb,
                        MedlemAAr = en.MedlemÅr,
                        Cvr = en.CVR,
                        Fax = en.Fax,
                        
                        Tlf = en.Tlf,
                        Oplag = en.Oplag,
                        Emails = en.Emails,
                    
                        Format = en.Format,
                        Adresse = en.Adresse,
                        Koncern = en.Koncern,
                        Ophoert = en.Ophørt,

                        Primaer = en.Primær,
                        Adresse2 = en.Adresse2,
                        Overfoert = en.Overført,
                        Timestamp = en.timestamp,
                        Hjemmeside = en.Hjemmeside,
                        Ejerforhold = en.Ejerforhold,
                        Totalomraade = en.Totalområde,
                        Kontaktperson = en.Kontaktperson,
                        OrienteringEmails = en.OrienteringEmails,
                        PostNr = en.PostNr,
                        RegionId = en.RegionID,
                        UgedagId = en.UgedagID,
                        OrdreEmail = en.OrdreEmail,
                        PrimaerPct = en.PrimærPct,
                        GruppeRabat = en.GruppeRabat,
                        AnnonceEmail = en.AnnonceEmail,
                        setMedlemMaaned = en.MedlemMåned,
                       
                        HovedgruppeId = en.HovedgruppeID,
                        StamdataEmail = en.StamdataEmail,
                        MaterialeEmail = en.MaterialeEmail,
                        RedaktionEmail = en.RedaktionEmail,
                        OrdrecheckEmail = en.OrdrecheckEmail,
                        TotalomraadePct = en.TotalområdePct,
                        BilagsbladeEmail = en.BilagsbladeEmail,
                        BogholderiEmails = en.BogholderiEmails,
                        OrdredeadlineTekst = en.OrdredeadlineTekst,
                        SendetidOrdrecheck = en.SendetidOrdrecheck,
                        OrdredeadlineRubrik = en.OrdredeadlineRubrik,
                        SamannonceringsRabat = en.SamannonceringsRabat,
                        KontaktpersonerEmails = en.KontaktpersonerEmails,
                        MaterialedeadlineTekst = en.MaterialedeadlineTekst,
                     
                        MaterialedeadlineRubrik = en.MaterialedeadlineRubrik,
                        MaterialeDeadlineRubrikKl = en.MaterialeDeadlineRubrikKl,
                        PrisforespoergselEmails = en.PrisforespørgselEmails,
                        GeoKodeId = en.GeoKodeID,
                        VisPaaWww = en.VisPåWWW,
                        DelOmraadeId = en.DelOmrådeID,
                        OrdreDeadlineTekstDag = en.OrdreDeadlineTekstDag,
                        OrdreDeadlineRubrikDag = en.OrdreDeadlineRubrikDag,
                        OrdreDeadlineRubrikKl = en.OrdreDeadlineRubrikKl,
                        MedieNetKode = en.MedieNetKode,
                        SalgsGruppeId = en.SalgsGruppeID,
                        FakturaGruppeId = en.FakturaGruppeID,
                        GiverWebTillaeg = en.GiverWebTillæg,
                        SendIndevaerendeUge = en.SendIndeværendeUge,
                        AnnonceKontrolEmail = en.AnnonceKontrolEmail,
                        MaaGiveFarveRabat = en.MåGiveFarveRabat,
                        OrdrecheckSendeDagId = en.OrdrecheckSendeDagID,
                        WwwDaekningSomTekst = en.WWWDækningSomTekst,
                        MaterialeDeadlineTekstKl = en.MaterialeDeadlineTekstKl,
                        OrdreDeadlineTekstKl = en.OrdreDeadlineTekstKl,
                        MaterialeDeadlineTekstDag = en.MaterialeDeadlineTekstDag,
                        MaterialeDeadlineRubrikDag = en.MaterialeDeadlineRubrikDag,
                        DelOmraadeNavn = de.DelOmrådeNavn,
                        BogholderiKontaktperson = en.Kontaktperson,
                        DiMpDelOmraadeKode = en.DiMPDelOmrådeKode,
                        DagNavn = d.DagNavn,
                        RegionNavn = r.RegionNavn,
                       HovedGruppeNavn = h.HovedGruppeNavn,
                      GeoKodeNavn = g.GeoKodeNavn
                         
                        
                        
                    }
                    select p;
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions(" StamBladsDao GetStamDataById ", e.InnerException);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetStamBladByName(string name)
        {
            try
            {
                var res = from en in di.tblBladStamdatas
                          join d in di.tblDages on en.UgedagID equals d.DagID into ds
                          from d in ds.DefaultIfEmpty()
                          join r in di.tblRegions on en.RegionID equals r.RegionID into rs
                          from r in rs.DefaultIfEmpty()
                          join h in di.tblHovedGruppes on en.HovedgruppeID equals h.HovedGruppeID into hs
                          from h in hs.DefaultIfEmpty()
                          join de in di.tblDelOmråde on en.DelOmrådeID equals de.DelOmrådeID into des
                          from de in des.DefaultIfEmpty()

                          join g in di.tblGeoKodes on en.GeoKodeID equals g.GeoKodeID into gs
                          from g in gs.DefaultIfEmpty()


                          where en.Navn.Contains(name)




                          let p = new StamBlad()
                          {
                              BladId = en.BladID,
                              Navn = en.Navn.Trim(),
                              Navn2 = en.Navn2.Trim(),
                              MatGodtBeloeb = en.MatGodtBeløb,
                              MedlemAAr = en.MedlemÅr,
                              Cvr = en.CVR,
                              Fax = en.Fax,

                              Tlf = en.Tlf,
                              Oplag = en.Oplag,
                              Emails = en.Emails,

                              Format = en.Format,
                              Adresse = en.Adresse,
                              Koncern = en.Koncern,
                              Ophoert = en.Ophørt,

                              Primaer = en.Primær,
                              Adresse2 = en.Adresse2,
                              Overfoert = en.Overført,
                              Timestamp = en.timestamp,
                              Hjemmeside = en.Hjemmeside,
                              Ejerforhold = en.Ejerforhold,
                              Totalomraade = en.Totalområde,
                              Kontaktperson = en.Kontaktperson,
                              OrienteringEmails = en.OrienteringEmails,
                              PostNr = en.PostNr,
                              RegionId = en.RegionID,
                              UgedagId = en.UgedagID,
                              OrdreEmail = en.OrdreEmail,
                              PrimaerPct = en.PrimærPct,
                              GruppeRabat = en.GruppeRabat,
                              AnnonceEmail = en.AnnonceEmail,
                              setMedlemMaaned = en.MedlemMåned,

                              HovedgruppeId = en.HovedgruppeID,
                              StamdataEmail = en.StamdataEmail,
                              MaterialeEmail = en.MaterialeEmail,
                              RedaktionEmail = en.RedaktionEmail,
                              OrdrecheckEmail = en.OrdrecheckEmail,
                              TotalomraadePct = en.TotalområdePct,
                              BilagsbladeEmail = en.BilagsbladeEmail,
                              BogholderiEmails = en.BogholderiEmails,
                              OrdredeadlineTekst = en.OrdredeadlineTekst,
                              SendetidOrdrecheck = en.SendetidOrdrecheck,
                              OrdredeadlineRubrik = en.OrdredeadlineRubrik,
                              SamannonceringsRabat = en.SamannonceringsRabat,
                              KontaktpersonerEmails = en.KontaktpersonerEmails,
                              MaterialedeadlineTekst = en.MaterialedeadlineTekst,

                              MaterialedeadlineRubrik = en.MaterialedeadlineRubrik,
                              MaterialeDeadlineRubrikKl = en.MaterialeDeadlineRubrikKl,
                              PrisforespoergselEmails = en.PrisforespørgselEmails,
                              GeoKodeId = en.GeoKodeID,
                              VisPaaWww = en.VisPåWWW,
                              DelOmraadeId = en.DelOmrådeID,
                              OrdreDeadlineTekstDag = en.OrdreDeadlineTekstDag,
                              OrdreDeadlineRubrikDag = en.OrdreDeadlineRubrikDag,
                              OrdreDeadlineRubrikKl = en.OrdreDeadlineRubrikKl,
                              MedieNetKode = en.MedieNetKode,
                              SalgsGruppeId = en.SalgsGruppeID,
                              FakturaGruppeId = en.FakturaGruppeID,
                              GiverWebTillaeg = en.GiverWebTillæg,
                              SendIndevaerendeUge = en.SendIndeværendeUge,
                              AnnonceKontrolEmail = en.AnnonceKontrolEmail,
                              MaaGiveFarveRabat = en.MåGiveFarveRabat,
                              OrdrecheckSendeDagId = en.OrdrecheckSendeDagID,
                              WwwDaekningSomTekst = en.WWWDækningSomTekst,
                              MaterialeDeadlineTekstKl = en.MaterialeDeadlineTekstKl,
                              OrdreDeadlineTekstKl = en.OrdreDeadlineTekstKl,
                              MaterialeDeadlineTekstDag = en.MaterialeDeadlineTekstDag,
                              MaterialeDeadlineRubrikDag = en.MaterialeDeadlineRubrikDag,
                              DelOmraadeNavn = de.DelOmrådeNavn,
                              BogholderiKontaktperson = en.Kontaktperson,
                              DiMpDelOmraadeKode = en.DiMPDelOmrådeKode,
                              DagNavn = d.DagNavn,
                              RegionNavn = r.RegionNavn,
                              HovedGruppeNavn = h.HovedGruppeNavn,
                              GeoKodeNavn = g.GeoKodeNavn



                          }
                          select p;
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions(" StamBladsDao GetStamDataById ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="postNr"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetStamBladByPostNummer(int postNr)
        {
            try
            {
                var res = from en in di.tblBladStamdatas
                    where en.PostNr == postNr
                    orderby en.PostNr
                    select new
                    {
                        en.BladID,
                        en.Adresse,
                        en.Adresse2,
                        en.AnnonceEmail,
                        en.AnnonceKontrolEmail,
                        en.BilagsbladeEmail,
                        en.BogholderiEmails,
                       
                        en.CVR,
                        en.DelOmrådeID,
                        en.DiMPDelOmrådeKode,
                        en.UgedagID,
                        en.Ejerforhold,
                        en.Emails,
                        en.FakturaGruppeID,
                        en.Fax,
                     
                        en.Format,
                        en.GeoKodeID,

                        en.GruppeRabat,
                        en.Hjemmeside,
                        en.HovedgruppeID,
                        en.Koncern,
                        en.Kontaktperson,
                        en.KontaktpersonerEmails,
                        en.PostNr,
                        en.MaterialedeadlineRubrik,
                        en.MaterialeDeadlineRubrikDag,
                        en.MaterialeDeadlineRubrikKl,
                        en.MaterialedeadlineTekst,
                        en.MaterialeDeadlineTekstDag,
                        en.MaterialeDeadlineTekstKl,
                        en.MaterialeEmail,
                        en.MatGodtBeløb,
                        en.MedieNetKode,
                        en.MedlemMåned,
                      
                        en.MedlemÅr,
                        en.MåGiveFarveRabat,
                        en.Navn,
                        en.Navn2,
                        en.Ophørt,
                        en.Oplag,
                        en.OrdrecheckEmail,
                        en.OrdrecheckSendeDagID,
                        en.OrdredeadlineRubrik,
                        en.OrdreDeadlineRubrikDag,
                        en.OrdreDeadlineRubrikKl,

                        en.OrdredeadlineTekst,
                        en.OrdreDeadlineTekstDag,
                        en.OrdreDeadlineTekstKl,

                        en.OrdreEmail,
                        en.SendetidOrdrecheck,
                        en.SendIndeværendeUge
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetStamBladByPostNummer ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetTblRegion()
        {
            try
            {
                var res = from re in di.tblRegions
                    orderby re.RegionID
                    select new
                    {
                        re.RegionID,
                        re.RegionNavn,
                        re.RegionSortKey
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetTblRegion ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetPostNrSøgning()
        {
            try
            {
                var post = from ps in di.tblPostNrSøgning orderby ps.PostNr select new {ps.PostNr, ps.BrugerNavn};
                return JsonConvert.SerializeObject(post, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetPostNrSøgning ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public List<By> GetTblPostNr()
        {
            try
            {
                var post = from p in di.tblPostNrs
                           orderby p.PostNr ascending
                           select new By()
                           {
                               Husstane = p.Husstande, MaxDækningsGrad = p.MaxDækningsGrad, PostBy = p.PostBy, PostNr= p.PostNr
                        
                    };
                return post.ToList();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetTblPostNr ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetTblGetKode()
        {
            try
            {
                var geo = from g in di.tblGeoKodes
                    orderby g.GeoKodeID, g.GeoKodeNavn
                    select new {g.GeoKodeID, g.GeoKodeNavn, g.GeoKodeSortKey, g.timestamp};
                return JsonConvert.SerializeObject(geo, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetTblGetKode ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetTableDage()
        {
            try
            {
                var dage = from d in di.tblDages
                    orderby d.DagType, d.DagID
                    select new {d.DagID, d.DagNavn, d.DagType, d.timestamp};
                return JsonConvert.SerializeObject(dage, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetTableDage ", e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stamData"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Tuple<string, int> OpretNytStamBlad(tblBladStamdata stamData)

        {
           
            string trace = null;
            int i = 0;
            try
            {
                di.tblBladStamdatas.AddOrUpdate(stamData);

                 i =  di.SaveChanges();
                 
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            

            return new Tuple<string, int>(trace, i);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public Tuple<string, int> GetLatestId()
        {
            try
            {
                var row = di.tblBladStamdatas
                    .SqlQuery("select top 1 * from tblBladStamdata as a order  by a.BladID desc")
                    .SingleOrDefault();

                Debug.Assert(row != null, nameof(row) + " != null");

                return new Tuple<string, int>("bladId", row.BladID);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetTableHovedGruppe()
        {
            try
            {
                var res = from h in di.tblHovedGruppes
                    orderby h.HovedGruppeID, h.HovedGruppeNavn
                    select new
                    {
                        h.HovedGruppeID, h.HovedGruppeNavn, h.HovedGruppeSortKey, h.timestamp
                    };
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public int GetNumbersOfStamblad()
        {
            try
            {
                return di.tblBladStamdatas.SqlQuery("select * from tblBladStamdata as n").Count();
            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e);
            }
        }

        public bool DoesStambladExist(int bladId)
        {
            var res = from st in di.tblBladStamdatas where st.BladID == bladId select new {st.BladID};
            var single = res.Single();

            return single != null;
        }

        public string GetStamBladEfterEjerforhold(string ejerforhold)
        {
            try
            {
                var res = from en in di.tblBladStamdatas
                          where en.Ejerforhold == ejerforhold
                          let p = new StamBlad()
                          {
                                 BladId = en.BladID,
                                 Navn = en.Navn.Trim(),
                                 Navn2 = en.Navn2.Trim(),
                                 MatGodtBeloeb = en.MatGodtBeløb,
                                 MedlemAAr = en.MedlemÅr,
                                 Cvr = en.CVR,
                                 Fax = en.Fax,

                                 Tlf = en.Tlf,
                                 Oplag = en.Oplag,
                                 Emails = en.Emails,

                                 Format = en.Format,
                                 Adresse = en.Adresse,
                                 Koncern = en.Koncern,
                                 Ophoert = en.Ophørt,

                                 Primaer = en.Primær,
                                 Adresse2 = en.Adresse2,
                                 Overfoert = en.Overført,
                                 Timestamp = en.timestamp,
                                 Hjemmeside = en.Hjemmeside,
                                 Ejerforhold = en.Ejerforhold,
                                 Totalomraade = en.Totalområde,
                                 Kontaktperson = en.Kontaktperson,
                                 OrienteringEmails = en.OrienteringEmails,
                                 PostNr = en.PostNr,
                                 RegionId = en.RegionID,
                                 UgedagId = en.UgedagID,
                                 OrdreEmail = en.OrdreEmail,
                                 PrimaerPct = en.PrimærPct,
                                 GruppeRabat = en.GruppeRabat,
                                 AnnonceEmail = en.AnnonceEmail,
                                 setMedlemMaaned = en.MedlemMåned,

                                 HovedgruppeId = en.HovedgruppeID,
                                 StamdataEmail = en.StamdataEmail,
                                 MaterialeEmail = en.MaterialeEmail,
                                 RedaktionEmail = en.RedaktionEmail,
                                 OrdrecheckEmail = en.OrdrecheckEmail,
                                 TotalomraadePct = en.TotalområdePct,
                                 BilagsbladeEmail = en.BilagsbladeEmail,
                                 BogholderiEmails = en.BogholderiEmails,
                                 OrdredeadlineTekst = en.OrdredeadlineTekst,
                                 SendetidOrdrecheck = en.SendetidOrdrecheck,
                                 OrdredeadlineRubrik = en.OrdredeadlineRubrik,
                                 SamannonceringsRabat = en.SamannonceringsRabat,
                                 KontaktpersonerEmails = en.KontaktpersonerEmails,
                                 MaterialedeadlineTekst = en.MaterialedeadlineTekst,

                                 MaterialedeadlineRubrik = en.MaterialedeadlineRubrik,
                                 MaterialeDeadlineRubrikKl = en.MaterialeDeadlineRubrikKl,
                                 PrisforespoergselEmails = en.PrisforespørgselEmails,
                                 GeoKodeId = en.GeoKodeID,
                                 VisPaaWww = en.VisPåWWW,
                                 DelOmraadeId = en.DelOmrådeID,
                                 OrdreDeadlineTekstDag = en.OrdreDeadlineTekstDag,
                                 OrdreDeadlineRubrikDag = en.OrdreDeadlineRubrikDag,
                                 OrdreDeadlineRubrikKl = en.OrdreDeadlineRubrikKl,
                                 MedieNetKode = en.MedieNetKode,
                                 SalgsGruppeId = en.SalgsGruppeID,
                                 FakturaGruppeId = en.FakturaGruppeID,
                                 GiverWebTillaeg = en.GiverWebTillæg,
                                 SendIndevaerendeUge = en.SendIndeværendeUge,
                                 AnnonceKontrolEmail = en.AnnonceKontrolEmail,
                                 MaaGiveFarveRabat = en.MåGiveFarveRabat,
                                 OrdrecheckSendeDagId = en.OrdrecheckSendeDagID,
                                 WwwDaekningSomTekst = en.WWWDækningSomTekst,
                                 MaterialeDeadlineTekstKl = en.MaterialeDeadlineTekstKl,
                                 OrdreDeadlineTekstKl = en.OrdreDeadlineTekstKl,
                                 MaterialeDeadlineTekstDag = en.MaterialeDeadlineTekstDag,
                                 MaterialeDeadlineRubrikDag = en.MaterialeDeadlineRubrikDag
                             }
                    select p;
                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch(Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

       

        public string GetByNavnPostNr(int postnr)
        {
            try
            {
                var res = from st in di.tblPostNrs
                    where st.PostNr == postnr
                    select new
                    {
                        st.PostNr, st.Husstande, st.PostBy, st.MaxDækningsGrad
                    };

                return JsonConvert.SerializeObject(res, Formatting.Indented);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Console GetAllIds()
        {
            try
            {
                var res = from en in di.tblBladStamdatas   orderby en.BladID ascending select new {
                  en.BladID
                };
                return JsonConvert.SerializeObject(res, Formatting.Indented);


            }
            catch (Exception e)
            {
                throw new FormattedDbEntityValidationException(e.InnerException);
            }
        }

        public Task<int> UpdateEjerforholdForAviser(string oldejeforhold, string newejerforhold)
        {
            var old = from ej in di.tblBladStamdatas where ej.Ejerforhold == oldejeforhold select ej;

            foreach (var item in old)
            {
                item.Ejerforhold = newejerforhold;
            }
            return  di.SaveChangesAsync();
        }
    }
}