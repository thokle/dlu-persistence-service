﻿using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    /// <summary>
    /// </summary>
    public class StamBladsDao : IDisposable
    {
        private readonly DiMPdotNetEntities di;

        public StamBladsDao()
        {
            di = new DiMPdotNetEntities();
            di.Configuration.LazyLoadingEnabled = true;
        }


        public void Dispose()
        {
            di?.Dispose();
        }

        /// <summary>
        /// </summary>
        /// <param name="bladId"></param>
        /// <returns></returns>
        /// <exception cref="DaoExceptions"></exception>
        public string GetStamDataById(int bladId)
        {
            try
            {
                var res = from en in di.tblBladStamdatas
                    where en.BladID == bladId
                    let p = new
                    {
                        en.BladID,
                        en.Adresse,
                        en.Adresse2,
                        en.AnnonceEmail,
                        en.AnnonceKontrolEmail,
                        en.BilagsbladeEmail,
                        en.BogholderiEmails,
                        en.BogholderiKontaktperson,
                        en.CVR,
                        en.DelOmrådeID,
                        en.DiMPDelOmrådeKode,

                        en.Ejerforhold,
                        en.Emails,
                        en.FakturaGruppeID,
                        en.Fax,
                        en.FIK,
                        en.Format,
                        en.GeoKodeID,
                        en.GiverWebTillæg,
                        en.GruppeRabat,
                        en.Hjemmeside,
                        en.HovedgruppeID,
                        en.Koncern,
                        Kontakperson = en.Kontaktperson,
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
                        en.MedlemSiden,
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
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetStamBladByName(string name)
        {
            try
            {
                var res = from en in di.tblBladStamdatas.Where(d => d.Navn.Contains(name)).OrderBy(s => s.Navn)
                    select new
                    {
                        en.BladID,
                        en.Adresse,
                        en.Adresse2,
                        en.AnnonceEmail,
                        en.AnnonceKontrolEmail,
                        en.BilagsbladeEmail,
                        en.BogholderiEmails,
                        en.BogholderiKontaktperson,
                        en.CVR,
                        en.DelOmrådeID,
                        en.DiMPDelOmrådeKode,
                        en.PostNr,
                        en.Ejerforhold,
                        en.Emails,
                        en.FakturaGruppeID,
                        en.Fax,
                        en.FIK,
                        en.Format,
                        en.GeoKodeID,
                        en.GiverWebTillæg,
                        en.GruppeRabat,
                        en.Hjemmeside,
                        en.HovedgruppeID,
                        en.Koncern,
                        Kontakperson = en.Kontaktperson,
                        en.KontaktpersonerEmails,

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
                        en.MedlemSiden,
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
                throw new DaoExceptions("StamBladsDao GetStamBladByName ", e.InnerException);
            }
        }


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
                        en.BogholderiKontaktperson,
                        en.CVR,
                        en.DelOmrådeID,
                        en.DiMPDelOmrådeKode,

                        en.Ejerforhold,
                        en.Emails,
                        en.FakturaGruppeID,
                        en.Fax,
                        en.FIK,
                        en.Format,
                        en.GeoKodeID,
                        en.GiverWebTillæg,
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
                        en.MedlemSiden,
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

        public string GetTblPostNr()
        {
            try
            {
                var post = from p in di.tblPostNrs
                    orderby p.PostNr, p.PostBy
                    select new {p.PostNr, p.PostBy, p.Husstande, p.MaxDækningsGrad};
                return JsonConvert.SerializeObject(post, Formatting.Indented);
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetTblPostNr ", e.InnerException);
            }
        }


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

        public Task<int> OpretNytStamBlad(tblBladStamdata stamData)

        {
            try
            {
                stamData.BladID = GetLatestId() + 1;

                di.tblBladStamdatas.AddOrUpdate(stamData);
                return di.SaveChangesAsync();
            }
            catch (DbEntityValidationException e)
            {
                var newException = new FormattedDbEntityValidationException(e);
                throw newException;
            }
        }

        private int GetLatestId()
        {
            try
            {
                var row = di.tblBladStamdatas
                    .SqlQuery("select top 1 * from tblBladStamdata as a order  by a.BladID desc")
                    .SingleOrDefault();

                Debug.Assert(row != null, nameof(row) + " != null");

                return row.BladID;
            }
            catch (Exception e)
            {
                throw new DaoExceptions("GetLatestId", e.InnerException);
            }
        }


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
                throw new DaoExceptions("GetTableHovedGruppe ", e.InnerException);
            }
        }

        public Task<int> UpdateStamBlad(tblBladStamdata stamdata)
        {
            try
            {
                di.tblBladStamdatas.AddOrUpdate(stamdata);
                return di.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new DaoExceptions("UpdateStamBlad ", e.InnerException);
            }
        }
    }
}