using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dlu_persistence_api.models;
namespace dlu_persistence_api
{
   public  class StamData
    {
       
        public StamData()
        {
            this.MedIGruppes = new HashSet<MedlGruppe>();
            this.MedieplanLinjers = new HashSet<MedieplanLinjer>();
            this.Prisers = new HashSet<Prisers>();
            this.PrislisterPrBladPrUges = new HashSet<PrislisterPrBladPrUges>();
            this.PrislisterPrBladPrÅr = new HashSet<PrislisterPrBladÅr>();
        }

        public int BladID { get; set; }
        public string Navn { get; set; }
        public string Navn2 { get; set; }
        public string Adresse { get; set; }
        public string Adresse2 { get; set; }
        public Nullable<int> PostNr { get; set; }
        public string Tlf { get; set; }
        public string Fax { get; set; }
        public string CVR { get; set; }
        public string FIK { get; set; }
        public string Kontaktperson { get; set; }
        public Nullable<byte> HovedgruppeID { get; set; }
        public Nullable<byte> MedlemMåned { get; set; }
        public Nullable<byte> MedlemÅr { get; set; }
        public Nullable<System.DateTime> MedlemSiden { get; set; }
        public string Ejerforhold { get; set; }
        public string Koncern { get; set; }
        public bool Ophørt { get; set; }
        public bool VisPåWWW { get; set; }
        public Nullable<byte> RegionID { get; set; }
        public Nullable<byte> DelOmrådeID { get; set; }
        public string DiMPDelOmrådeKode { get; set; }
        public Nullable<byte> GeoKodeID { get; set; }
        public Nullable<int> Totalområde { get; set; }
        public Nullable<byte> TotalområdePct { get; set; }
        public Nullable<int> Primær { get; set; }
        public Nullable<byte> PrimærPct { get; set; }
        public string WWWDækningSomTekst { get; set; }
        public Nullable<int> Oplag { get; set; }
        public Nullable<byte> UgedagID { get; set; }
        public string Format { get; set; }
        public string OrdredeadlineTekst { get; set; }
        public string OrdredeadlineRubrik { get; set; }
        public string MaterialedeadlineTekst { get; set; }
        public string MaterialedeadlineRubrik { get; set; }
        public string OrdreEmail { get; set; }
        public string OrdrecheckEmail { get; set; }
        public Nullable<byte> OrdrecheckSendeDagID { get; set; }
        public string SendetidOrdrecheck { get; set; }
        public Nullable<bool> SendIndeværendeUge { get; set; }
        public string StamdataEmail { get; set; }
        public string PrisforespørgselEmails { get; set; }
        public string OrienteringEmails { get; set; }
        public string Emails { get; set; }
        public string KontaktpersonerEmails { get; set; }
        public string BogholderiEmails { get; set; }
        public string BogholderiKontaktperson { get; set; }
        public string MedieNetKode { get; set; }
        public Nullable<byte> MatGodtBeløb { get; set; }
        public string Hjemmeside { get; set; }
        public string RedaktionEmail { get; set; }
        public string AnnonceEmail { get; set; }
        public string MaterialeEmail { get; set; }
        public string AnnonceKontrolEmail { get; set; }
        public string BilagsbladeEmail { get; set; }
        public int FakturaGruppeID { get; set; }
        public Nullable<int> SalgsGruppeID { get; set; }
        public string GruppeRabat { get; set; }
        public string SamannonceringsRabat { get; set; }
        public Nullable<bool> MåGiveFarveRabat { get; set; }
        public bool GiverWebTillæg { get; set; }
        public Nullable<byte> OrdreDeadlineTekstDag { get; set; }
        public string OrdreDeadlineTekstKl { get; set; }
        public Nullable<byte> MaterialeDeadlineTekstDag { get; set; }
        public string MaterialeDeadlineTekstKl { get; set; }
        public Nullable<byte> OrdreDeadlineRubrikDag { get; set; }
        public string OrdreDeadlineRubrikKl { get; set; }
        public Nullable<byte> MaterialeDeadlineRubrikDag { get; set; }
        public string MaterialeDeadlineRubrikKl { get; set; }
        public bool Overført { get; set; }
        public byte[] timestamp { get; set; }

       
        public  ICollection<MedlGruppe> MedIGruppes { get; set; }
        public  Dage Dage { get; set; }
        public  Dage1 Dage1 { get; set; }
        public  DelOmraade DelOmråde { get; set; }
        public  GeoKode GeoKode { get; set; }
        public  HovedGruppe HovedGruppe { get; set; }
        public  PostNr tblPostNr { get; set; }
        public  Region tblRegion { get; set; }
     
        public  ICollection<MedieplanLinjer> MedieplanLinjers { get; set; }
      
        public  ICollection<Prisers> Prisers { get; set; }
       
        public  ICollection<PrislisterPrBladPrUges> PrislisterPrBladPrUges { get; set; }
     
        public  ICollection<PrislisterPrBladÅr> PrislisterPrBladPrÅr { get; set; }
    }
}
