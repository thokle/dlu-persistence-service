﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
 using System.Management.Instrumentation;
 using Newtonsoft.Json;

namespace dlu_persistence_api.daos
{
    public class StamBladsDao: IDisposable
    {

        private DiMPdotNetEntities di;

        public StamBladsDao()
        {
            di = new DiMPdotNetEntities();
            di.Configuration.LazyLoadingEnabled = true;

        }

        public string GetStamDataById(int bladId)
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
                          en.SendIndeværendeUge,


                      }
                      select p;
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }



        public string GetStamBladByName(String name){
            var res = from en in di.tblBladStamdatas.Where(d => d.Navn.Contains(name)).OrderBy(s => s.Navn) select new
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
                en.SendIndeværendeUge,

            };
            return JsonConvert.SerializeObject(res, Formatting.Indented);

        }

       


        public string GetStamBladByPostNummer(int postNr)
        {
            var res = from en in di.tblBladStamdatas
                where en.PostNr == postNr
                orderby en.PostNr ascending
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
                    en.SendIndeværendeUge,


                };
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }
        
        public string GetTblRegion()
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

        public string GetPostNrSøgning()
        {
            var post = from ps in di.tblPostNrSøgning orderby ps.PostNr select new { ps.PostNr, ps.BrugerNavn };
            return JsonConvert.SerializeObject(post, Formatting.Indented);
                
        }
        
        public string GetTblPostNr()
        {
            var post = from p in di.tblPostNrs orderby p.PostNr, p.PostBy select new { p.PostNr, p.PostBy, p.Husstande, p.MaxDækningsGrad };
            return JsonConvert.SerializeObject(post, Formatting.Indented);
               
        }


        public string GetTblGetKode()
        {
            var geo = from g in di.tblGeoKodes orderby g.GeoKodeID, g.GeoKodeNavn select new { g.GeoKodeID, g.GeoKodeNavn, g.GeoKodeSortKey, g.timestamp };
            return JsonConvert.SerializeObject(geo, Formatting.Indented);
        }


        public string GetTableDage()
        {
            var dage = from d in di.tblDages orderby d.DagType, d.DagID select new { d.DagID, d.DagNavn, d.DagType, d.timestamp };
            return JsonConvert.SerializeObject(dage, Formatting.Indented);
           
        }
        public string  OpretNytStamBlad(tblBladStamdata stamData)

        {
            try
            {
                stamData.BladID = GetLatestId() + 1;
               var res = di.tblBladStamdatas.Add(stamData);
                di.SaveChanges();


                return "";

            } catch( Exception e)
            {
                throw e;
            }
        }

        private int GetLatestId()
        {
          var row =  di.tblBladStamdatas.SqlQuery("select top 1 * from tblBladStamdata as a order  by a.BladID desc").SingleOrDefault();

            Debug.Assert(row != null, nameof(row) + " != null");
            return row.BladID;
        }


        public string GetTableHovedGruppe()
        {
            var res = from h in di.tblHovedGruppes
                orderby h.HovedGruppeID, h.HovedGruppeNavn
                select new
                {
                     h.HovedGruppeID, h.HovedGruppeNavn, h.HovedGruppeSortKey, h.timestamp
                };
            return JsonConvert.SerializeObject(res, Formatting.Indented);
        }


        public void Dispose()
        {
            di?.Dispose();
        }
    }

}
