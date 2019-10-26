namespace dlu_persistence_api.daos
{
    public class BladStamdata
    {
        public BladStamdata()
        {
        }

        public int BladID { get; set; }
        public string Navn { get; set; }
        public string Navn2 { get; set; }
        public byte? MatGodtBeløb { get; set; }
        public byte? MedlemÅr { get; set; }
        public string CVR { get; set; }
        public string Fax { get; set; }
        public string Tlf { get; set; }
        public int? Oplag { get; set; }
        public string Emails { get; set; }
        public string Format { get; set; }
        public string Adresse { get; set; }
        public string Koncern { get; set; }
        public bool Ophørt { get; set; }
        public int? Primær { get; set; }
        public string Adresse2 { get; set; }
        public bool Overført { get; set; }
        public byte[] timestamp { get; set; }
        public string Hjemmeside { get; set; }
        public string Ejerforhold { get; set; }
        public int? Totalområde { get; set; }
        public string Kontaktperson { get; set; }
        public string OrienteringEmails { get; set; }
        public int? PostNr { get; set; }
        public byte? RegionID { get; set; }
        public byte? UgedagID { get; set; }
        public string OrdreEmail { get; set; }
        public byte? PrimærPct { get; set; }
        public string GruppeRabat { get; set; }
        public string AnnonceEmail { get; set; }
        public byte? MedlemMåned { get; set; }
        public byte? HovedgruppeID { get; set; }
        public string StamdataEmail { get; set; }
        public string MaterialeEmail { get; set; }
        public string RedaktionEmail { get; set; }
        public string OrdrecheckEmail { get; set; }
        public byte? TotalområdePct { get; set; }
        public string BilagsbladeEmail { get; set; }
        public string BogholderiEmails { get; set; }
        public string OrdredeadlineTekst { get; set; }
        public string SendetidOrdrecheck { get; set; }
        public string OrdredeadlineRubrik { get; set; }
        public string SamannonceringsRabat { get; set; }
        public string KontaktpersonerEmails { get; set; }
        public string MaterialedeadlineTekst { get; set; }
        public string MaterialedeadlineRubrik { get; set; }
        public string MaterialeDeadlineRubrikKl { get; set; }
        public string PrisforespørgselEmails { get; set; }
        public byte? GeoKodeID { get; set; }
        public bool VisPåWWW { get; set; }
        public byte? DelOmrådeID { get; set; }
        public byte? OrdreDeadlineTekstDag { get; set; }
        public byte? OrdreDeadlineRubrikDag { get; set; }
        public string OrdreDeadlineRubrikKl { get; set; }
        public string MedieNetKode { get; set; }
        public int? SalgsGruppeID { get; set; }
        public int FakturaGruppeID { get; set; }
        public bool GiverWebTillæg { get; set; }
        public bool? SendIndeværendeUge { get; set; }
        public string AnnonceKontrolEmail { get; set; }
        public bool? MåGiveFarveRabat { get; set; }
        public byte? OrdrecheckSendeDagID { get; set; }
        public string WWWDækningSomTekst { get; set; }
        public string MaterialeDeadlineTekstKl { get; set; }
        public string OrdreDeadlineTekstKl { get; set; }
        public byte? MaterialeDeadlineTekstDag { get; set; }
        public byte? MaterialeDeadlineRubrikDag { get; set; }
        public string DiMPDelOmrådeKode { get; set; }
    }
}