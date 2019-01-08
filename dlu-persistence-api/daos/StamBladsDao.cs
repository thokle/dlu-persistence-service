using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.daos
{
    public class StamBladsDao
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
                      select new
                      {
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
                          KontaktpersonerEmails = en.KontaktpersonerEmails, en,
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
                       MedlemÅr =  en.MedlemÅr,
                       MåGiveFarveRabat =     en.MåGiveFarveRabat,
                       Navn =en.Navn,
                       Navn2 =en.Navn2,
                       Ophørt = en.Ophørt,
                       Oplag =en.Oplag,
                          OrdrecheckEmail = en.OrdrecheckEmail,
                          OrdrecheckSendeDagID  = en.OrdrecheckSendeDagID,
                          OrdredeadlineRubrik =  en.OrdredeadlineRubrik,
                          OrdreDeadlineRubrikDag = en.OrdreDeadlineRubrikDag,
                         OrdreDeadlineRubikDag = en.OrdreDeadlineRubrikKl,
                            
                     OrdreDeadlineTekst =    en.OrdredeadlineTekst,
                          OrdreDeadlineTekstDag =    en.OrdreDeadlineTekstDag,
                          OrdreDeadlineTekstKl =   en.OrdreDeadlineTekstKl,
                        OrdreEmai  en.OrdreEmail
                         tblPrislisterPrBladPrUges = from ps in di.tblPrislisterPrBladPrUges where ps.BladID == bladId select new  { Uge = ps.Uge,År = ps.År,PrislisteID = ps.PrislisteID }

                      }; 



            return JsonConvert.SerializeObject(res);
        }


        public List<StamData> GetStamBladByName(String name, String order, Boolean asc)
        {
            var resultat = from m in di.tblBladStamdatas.Where(d => d.Navn.Contains(name)).OrderBy(s => s.Navn).ToList<tblBladStamdata>() select m ;

            return mapper.AutoMaperUtil.ConvertFromTblBladEntitie(resultat.ToList());

        }


        public StamData OpretNytStamBlad(StamData stamData)
        {
            try
            {

                var tblStamBladData = mapper.AutoMaperUtil.ConvertFromnStamData(stamData);
                var res = di.tblBladStamdatas.Add(tblStamBladData);

                return mapper.AutoMaperUtil.ConvertFromTblStamBladEntity(res);
            } catch( Exception e)
            {
                throw e;
            }
        }

        
    }

}
