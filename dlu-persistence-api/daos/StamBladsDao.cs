﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

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
                select GetValue(en);
            return JsonConvert.SerializeObject(res);
        }



        public string GetStamBladByName(String name){
            var res = from en in di.tblBladStamdatas.Where(d => d.Navn.Contains(name)).OrderBy(s => s.Navn) select GetValue(en);
            return JsonConvert.SerializeObject(res);

        }

        private static object GetValue(tblBladStamdata en)
        {
            return new {
                BladID = en.BladID,
                Adresse = en.Adresse,
                Addresse2 = en.Adresse2,
                AnnonceEmail = en.AnnonceEmail,
                AnnonceKontrolEmail = en.AnnonceKontrolEmail,
                BilagsbladEmail = en.BilagsbladeEmail,
                BogholderiEmails = en.BogholderiEmails,
                Bogholderikontaktperson = en.BogholderiKontaktperson,
                CVR = en.CVR,
                DelOmrådeID = en.DelOmrådeID,
                DiMPDelOmrådeKode = en.DiMPDelOmrådeKode,

                Ejerforhold = en.Ejerforhold,
                Emails = en.Emails,
                FakturaGruppeID = en.FakturaGruppeID,
                Fax = en.Fax,
                FIK = en.FIK,
                Format = en.Format,
                GeokodeID = en.GeoKodeID,
                GiveWebTillæg = en.GiverWebTillæg,
                GruppeRabat = en.GruppeRabat,
                Hjemmesiode = en.Hjemmeside,
                HovedgruppeID = en.HovedgruppeID,
                Koncern = en.Koncern,
                Kontakperson = en.Kontaktperson,
                KontaktpersonerEmails = en.KontaktpersonerEmails,
                PostNr = en.PostNr,
                MaterialedeadlineRubrik = en.MaterialedeadlineRubrik,
                MaterialeDeadlineRubrikDag = en.MaterialeDeadlineRubrikDag,
                MaterialeDeadlineRubrikKl = en.MaterialeDeadlineRubrikKl,
                MaterialedeadlineTekst = en.MaterialedeadlineTekst,
                MaterialeDeadlineTekstDag = en.MaterialeDeadlineTekstDag,
                MaterialeDeadlineTekstKl = en.MaterialeDeadlineTekstKl,
                MaterialeEmail = en.MaterialeEmail,
                MatGodtBeløb = en.MatGodtBeløb,
                MedieNetKode = en.MedieNetKode,
                MedlemMåned = en.MedlemMåned,
                MedlemSiden = en.MedlemSiden,
                MedlemÅr = en.MedlemÅr,
                MåGiveFarveRabat = en.MåGiveFarveRabat,
                Navn = en.Navn,
                Navn2 = en.Navn2,
                Ophørt = en.Ophørt,
                Oplag = en.Oplag,
                OrdrecheckEmail = en.OrdrecheckEmail,
                OrdrecheckSendeDagID = en.OrdrecheckSendeDagID,
                OrdredeadlineRubrik = en.OrdredeadlineRubrik,
                OrdreDeadlineRubrikDag = en.OrdreDeadlineRubrikDag,
                OrdreDeadlineRubikDag = en.OrdreDeadlineRubrikKl,

                OrdreDeadlineTekst = en.OrdredeadlineTekst,
                OrdreDeadlineTekstDag = en.OrdreDeadlineTekstDag,
                OrdreDeadlineTekstKl = en.OrdreDeadlineTekstKl,

                OrdreEmai = en.OrdreEmail,
                SendtiOrdrecheck = en.SendetidOrdrecheck,
                SendværendeUge = en.SendIndeværendeUge,


            };
        }


        public string GetStamBladByPostNummer(int postNr)
        {
            var res = from en in di.tblBladStamdatas
                where en.PostNr == postNr
                orderby en.PostNr ascending
                select GetValue(en);
            return JsonConvert.SerializeObject(res);
        }
        
        
        

        public string  OpretNytStamBlad(tblBladStamdata stamData)

        {
            try
            {
                stamData.BladID = GetLatestId() + 1;
               var res = di.tblBladStamdatas.Add(stamData);
                di.SaveChanges();
                 var json  =GetValue(res);

                return JsonConvert.SerializeObject(json);

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


        public void Dispose()
        {
            di?.Dispose();
        }
    }

}
