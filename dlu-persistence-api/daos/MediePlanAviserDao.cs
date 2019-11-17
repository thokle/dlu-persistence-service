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

        public AviserTilGrid GetAllUgeAvisTilGrid(int bladid, int year,  int placeringid=0)
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
                              
                           where b.BladID == bladid & b.Ophørt == false  & p.År == year  & p.PlaceringID == placeringid select new AviserTilGrid  { Adresse = b.Adresse, AnnonceEmail = b.Adresse2, BladID = b.BladID, CVR = b.CVR, Adresse2 = b.Adresse2, AnnonceKontrolEmail = b.AnnonceKontrolEmail,
                               Betegnelse = pla.Betegnelse, BilagsbladeEmail = b.BilagsbladeEmail, BogholderiEmails = b.BogholderiEmails, DaekningsGrad = d.DækningsGrad, DagNavn = da.DagNavn, DiMPDelOmraadeKode = b.DiMPDelOmrådeKode, Ejerforhold = b.Ejerforhold,
                               Emails = b.Emails, FakturaGruppeID = b.FakturaGruppeID, Farve4Max = p.Farve4Max, Farve4Min = p.Farve4Min, Farve4Pris = p.Farve4Pris, FarveMax = p.FarveMax, FarveMin = p.FarveMin, FarvePris = p.FarvePris, Fax = b.Fax, Format = b.Format,
                               FormatFra = p.FormatFra, FormatTil = p.FormatTil, GeoKodeNavn = geo.GeoKodeNavn, GiverWebTillaeg = b.GiverWebTillæg, GruppeRabat = b.GruppeRabat, Hjemmeside = b.Hjemmeside, HovedGruppeNavn = hg.HovedGruppeNavn, Husstande = pos.Husstande,
                               Koncern = b.Koncern, Kontaktperson = b.Kontaktperson, KontaktpersonerEmails = b.KontaktpersonerEmails, MaaGiveFarveRabat = b.MåGiveFarveRabat, MaterialedeadlineRubrik = b.MaterialedeadlineRubrik, MaterialeDeadlineRubrikDag = b.MaterialeDeadlineRubrikDag,
                               MatGodtBeloeb = b.MatGodtBeløb, MaterialeDeadlineRubrikKl = b.MaterialeDeadlineRubrikKl, MaterialedeadlineTekst = b.MaterialedeadlineTekst, MaterialeDeadlineTekstDag = b.MaterialeDeadlineTekstDag, MaterialeDeadlineTekstKl = b.MaterialeDeadlineTekstKl, MaterialeEmail = b.MaterialeEmail,
                               MaxDaekningsGrad = pos.MaxDækningsGrad, Medlemaar = b.MedlemÅr, MedlemMaaned = b.MedlemMåned, mmPris = p.mmPris, Navn = b.Navn, Navn2 = b.Navn2, Ophoert = b.Ophørt, Oplag = d.Oplag, OrdrecheckEmail = b.OrdrecheckEmail, OrdrecheckSendeDagID = b.OrdrecheckSendeDagID,
                               OrdredeadlineRubrik = b.OrdredeadlineRubrik, OrdreDeadlineRubrikDag = b.OrdreDeadlineRubrikDag, OrdreDeadlineRubrikKl = b.OrdreDeadlineRubrikKl, OrdredeadlineTekst = b.OrdredeadlineTekst, OrdreDeadlineTekstDag = b.OrdreDeadlineTekstDag, OrdreDeadlineTekstKl = b.OrdreDeadlineTekstKl,
                               OrdreEmail = b.OrdreEmail, OrienteringEmails = b.OrienteringEmails, Overfoert = b.Overført, PostBy = pos.PostBy, PostNr = b.PostNr, Primaer = b.Primær, PrimaerPct = b.PrimærPct, PrisforespoergselEmails = b.PrisforespørgselEmails, PrislisteNavn = prisl.PrislisteNavn, RedaktionEmail = b.RedaktionEmail,
                               RegionNavn = r.RegionNavn, SamannonceringsRabat = b.SamannonceringsRabat, SendetidOrdrecheck = b.SendetidOrdrecheck, SendIndevaerendeUge = b.SendIndeværendeUge, StamdataEmail = b.StamdataEmail, Tlf = b.Tlf, Totalomraade = b.Totalområde, TotalomraadePct = b.TotalområdePct, VisPaaWWW = b.VisPåWWW, WWWDaekningSomTekst = b.WWWDækningSomTekst,
                              
                               MMPris = p.mmPris,
                            
                               webtillages =  ( from wb in b.tblBladTillaegs where wb.bladId == bladid select new webtilLæg
                               {
                                  wbId =   wb.id, 
                                  wpPris = wb.pris,
                                   type = wb.tblBladTillaegsType.type
                                
                               }).ToList()
                          
                                        

                                          
                             
               
                               
                            
                                               
                                                  
                       
                           };




                return res.First();

                        
                        
            }
            catch (FormattedDbEntityValidationException e)
            {

                throw new Exception(e.HelpLink);
            }
        }
    }

    public class AviserTilGrid
    {
        public string Adresse { get; set; }
        public string AnnonceEmail { get; set; }
        public int BladID { get; set; }
        public string CVR { get; set; }
        public string Adresse2 { get; set; }
        public string AnnonceKontrolEmail { get; set; }
        public string Betegnelse { get; set; }
        public string BilagsbladeEmail { get; set; }
        public string BogholderiEmails { get; set; }
        public int DaekningsGrad { get; set; }
        public string DagNavn { get; set; }
        public string DiMPDelOmraadeKode { get; set; }
        public string Ejerforhold { get; set; }
        public string Emails { get; set; }
        public int FakturaGruppeID { get; set; }
        public decimal? Farve4Max { get; set; }
        public decimal? Farve4Min { get; set; }
        public decimal? Farve4Pris { get; set; }
        public decimal? FarveMax { get; set; }
        public decimal? FarveMin { get; set; }
        public decimal? FarvePris { get; set; }
        public string Fax { get; set; }
        public string Format { get; set; }
        public int FormatFra { get; set; }
        public int FormatTil { get; set; }
        public string GeoKodeNavn { get; set; }
        public bool GiverWebTillaeg { get; set; }
        public string GruppeRabat { get; set; }
        public string Hjemmeside { get; set; }
        public string HovedGruppeNavn { get; set; }
        public int Husstande { get; set; }
        public string Koncern { get; set; }
        public string Kontaktperson { get; set; }
        public string KontaktpersonerEmails { get; set; }
        public bool? MaaGiveFarveRabat { get; set; }
        public string MaterialedeadlineRubrik { get; set; }
        public byte? MaterialeDeadlineRubrikDag { get; set; }
        public byte? MatGodtBeloeb { get; set; }
        public string MaterialeDeadlineRubrikKl { get; set; }
        public string MaterialedeadlineTekst { get; set; }
        public byte? MaterialeDeadlineTekstDag { get; set; }
        public string MaterialeDeadlineTekstKl { get; set; }
        public string MaterialeEmail { get; set; }
        public byte MaxDaekningsGrad { get; set; }
        public byte? Medlemaar { get; set; }
        public byte? MedlemMaaned { get; set; }
        public decimal? mmPris { get; set; }
        public decimal? MMPris { get; set; }
        public string Navn { get; set; }
        public string Navn2 { get; set; }
        public bool Ophoert { get; set; }
        public int Oplag { get; set; }
        public string OrdrecheckEmail { get; set; }
        public byte? OrdrecheckSendeDagID { get; set; }
        public string OrdredeadlineRubrik { get; set; }
        public byte? OrdreDeadlineRubrikDag { get; set; }
        public string OrdreDeadlineRubrikKl { get; set; }
        public string OrdredeadlineTekst { get; set; }
        public byte? OrdreDeadlineTekstDag { get; set; }
        public string OrdreDeadlineTekstKl { get; set; }
        public string OrdreEmail { get; set; }
        public string OrienteringEmails { get; set; }
        public bool Overfoert { get; set; }
        public string PostBy { get; set; }
        public int? PostNr { get; set; }
        public int? Primaer { get; set; }
        public byte? PrimaerPct { get; set; }
        public string PrisforespoergselEmails { get; set; }
        public string PrislisteNavn { get; set; }
        public string RedaktionEmail { get; set; }
        public string RegionNavn { get; set; }
        public string SamannonceringsRabat { get; set; }
        public string SendetidOrdrecheck { get; set; }
        public bool? SendIndevaerendeUge { get; set; }
        public string StamdataEmail { get; set; }
        public string Tlf { get; set; }
        public int? Totalomraade { get; set; }
        public byte? TotalomraadePct { get; set; }
        public bool VisPaaWWW { get; set; }
        public string WWWDaekningSomTekst { get; set; }
        public List<webtilLæg> webtillages { get; set; }
    }
}
