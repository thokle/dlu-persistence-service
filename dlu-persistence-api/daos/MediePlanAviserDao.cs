using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.exceptions;
using dlu_persistence_api.models;
namespace dlu_persistence_api.daos
{
   public class MediePlanAviserDao
    {
        private DiMPdotNetDevEntities diMPdot;
        public MediePlanAviserDao()
        {
            diMPdot = new DiMPdotNetDevEntities();
        }

        public string GetAllUgeAvisTilGrid(int bladid, int year)
        {
            try
            {
                var res = from b in diMPdot.tblBladStamdatas
                           join p in diMPdot.tblPrisers on b.BladID equals p.BladID into bp
                           from p in bp.DefaultIfEmpty()
                           join r in diMPdot.tblRegions on b.RegionID equals r.RegionID into rb
                           from r in rb.DefaultIfEmpty()
                           join d in diMPdot.tblBladDækning on b.BladID equals d.BladID into db
                           from d in db.DefaultIfEmpty()
                           join da in diMPdot.tblDages on b.UgedagID equals da.DagID into dab
                           from da in dab.DefaultIfEmpty()
                           join geo in diMPdot.tblGeoKodes on b.GeoKodeID equals geo.GeoKodeID into bgeo
                           from geo in bgeo.DefaultIfEmpty()
                           join hg in diMPdot.tblHovedGruppes on b.HovedgruppeID equals hg.HovedGruppeID into hgb
                           from hg in hgb.DefaultIfEmpty()
                           join pos in diMPdot.tblPostNrs on b.PostNr equals pos.PostNr into bpos
                           from pos in bpos.DefaultIfEmpty()
                           join pla in diMPdot.tblPlacerings on p.PlaceringID equals pla.PlaceringID into pplap
                           from pla in pplap.DefaultIfEmpty()
                           join prisl in diMPdot.tblPrislisters on p.PrislisteID equals prisl.PrislisteID into pprisl
                           from prisl in pprisl.DefaultIfEmpty()
                           where b.BladID == bladid & b.Ophørt == false select new AvisTIlGrid { Adresse = b.Adresse, AnnonceEmail = b.Adresse2, BladID = b.BladID, CVR = b.CVR, Adresse2 = b.Adresse2, AnnonceKontrolEmail = b.AnnonceKontrolEmail,
                               Betegnelse = pla.Betegnelse, BilagsbladeEmail = b.BilagsbladeEmail, BogholderiEmails = b.BogholderiEmails, DaekningsGrad = d.DækningsGrad, DagNavn = da.DagNavn, DiMPDelOmraadeKode = b.DiMPDelOmrådeKode, Ejerforhold = b.Ejerforhold,
                               Emails = b.Emails, FakturaGruppeID = b.FakturaGruppeID, Farve4Max = p.Farve4Max, Farve4Min = p.Farve4Min, Farve4Pris = p.Farve4Pris, FarveMax = p.FarveMax, FarveMin = p.FarveMin, FarvePris = p.FarvePris, Fax = b.Fax, Format = b.Format,
                               FormatFra = p.FormatFra, FormatTil = p.FormatTil, GeoKodeNavn = geo.GeoKodeNavn, GiverWebTillaeg = b.GiverWebTillæg, GruppeRabat = b.GruppeRabat, Hjemmeside = b.Hjemmeside, HovedGruppeNavn = hg.HovedGruppeNavn, Husstande = pos.Husstande,
                               Koncern = b.Koncern, Kontaktperson = b.Kontaktperson, KontaktpersonerEmails = b.KontaktpersonerEmails, MaaGiveFarveRabat = b.MåGiveFarveRabat, MaterialedeadlineRubrik = b.MaterialedeadlineRubrik, MaterialeDeadlineRubrikDag = b.MaterialeDeadlineRubrikDag,
                               MatGodtBeloeb = b.MatGodtBeløb, MaterialeDeadlineRubrikKl = b.MaterialeDeadlineRubrikKl, MaterialedeadlineTekst = b.MaterialedeadlineTekst, MaterialeDeadlineTekstDag = b.MaterialeDeadlineTekstDag, MaterialeDeadlineTekstKl = b.MaterialeDeadlineTekstKl, MaterialeEmail = b.MaterialeEmail,
                               MaxDaekningsGrad = pos.MaxDækningsGrad, Medlemaar = b.MedlemÅr, MedlemMaaned = b.MedlemMåned, mmPris = p.mmPris, Navn = b.Navn, Navn2 = b.Navn2, Ophoert = b.Ophørt, Oplag = d.Oplag, OrdrecheckEmail = b.OrdrecheckEmail, OrdrecheckSendeDagID = b.OrdrecheckSendeDagID,
                               OrdredeadlineRubrik = b.OrdredeadlineRubrik, OrdreDeadlineRubrikDag = b.OrdreDeadlineRubrikDag, OrdreDeadlineRubrikKl = b.OrdreDeadlineRubrikKl, OrdredeadlineTekst = b.OrdredeadlineTekst, OrdreDeadlineTekstDag = b.OrdreDeadlineTekstDag, OrdreDeadlineTekstKl = b.OrdreDeadlineTekstKl,
                               OrdreEmail = b.OrdreEmail, OrienteringEmails = b.OrienteringEmails, Overfoert = b.Overført, PostBy = pos.PostBy, PostNr = b.PostNr, Primaer = b.Primær, PrimaerPct = b.PrimærPct, PrisforespoergselEmails = b.PrisforespørgselEmails, PrislisteNavn = prisl.PrislisteNavn, RedaktionEmail = b.RedaktionEmail,
                               RegionNavn = r.RegionNavn, SamannonceringsRabat = b.SamannonceringsRabat, SendetidOrdrecheck = b.SendetidOrdrecheck, SendIndevaerendeUge = b.SendIndeværendeUge, StamdataEmail = b.StamdataEmail, Tlf = b.Tlf, Totalomraade = b.Totalområde, TotalomraadePct = b.TotalområdePct, VisPaaWWW = b.VisPåWWW, WWWDaekningSomTekst = b.WWWDækningSomTekst




                           };
                           
                      
                         

                return JsonConvert.SerializeObject(res, Formatting.Indented);

                        
                        
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.HelpLink);
            }
        }
    }
}
