using System;

namespace dlu_persistence_api.models
{
    public class StamBlad
    {
       

        public StamBlad()
        {
            
        }


        public int BladId { get; set; }

        public string Navn { get; set; }

        public string Navn2{ get; set; }

        public string Adresse { get; set; }

        public string Adresse2 { get; set; }

        public int? PostNr { get; set; }

        public string Tlf { get; set; }

        public string Fax { get; set; }

        public string Cvr { get; set; }

       

        public string Kontaktperson { get; set; }

        public byte? HovedgruppeId { get; set; }

        private byte? medlemMaaned;

        public byte? MedlemAAr { get; set; }

    

        public string Ejerforhold { get; set; }

        public string Koncern { get; set; }

        public bool Ophoert { get; set; }

        public bool VisPaaWww { get; set; }

        public byte? RegionId { get; set; }

        public byte? DelOmraadeId { get; set; }

        public string DiMpDelOmraadeKode { get; set; }

        public byte? GeoKodeId { get; set; }

        public int? Totalomraade { get; set; }

        public byte? TotalomraadePct { get; set; }

        public int? Primaer { get; set; }

        public byte? PrimaerPct { get; set; }

        public string WwwDaekningSomTekst { get; set; }

        public int? Oplag { get; set; }

        public byte? UgedagId { get; set; }

        public string Format { get; set; }

        public string OrdredeadlineTekst { get; set; }

        public string OrdredeadlineRubrik { get; set; }

        public string MaterialedeadlineTekst { get; set; }

        public string MaterialedeadlineRubrik { get; set; }

        public string OrdreEmail { get; set; }

        public string OrdrecheckEmail { get; set; }

        public byte? OrdrecheckSendeDagId { get; set; }

        public string SendetidOrdrecheck { get; set; }

        public bool? SendIndevaerendeUge { get; set; }

        public string StamdataEmail { get; set; }

        public string PrisforespoergselEmails { get; set; }

        public string OrienteringEmails { get; set; }

        public string Emails { get; set; }

        public string KontaktpersonerEmails { get; set; }

        public string BogholderiEmails { get; set; }

        public string BogholderiKontaktperson { get; set; }

        public string MedieNetKode { get; set; }

        public byte? MatGodtBeloeb { get; set; }

        public string Hjemmeside { get; set; }

        public string RedaktionEmail { get; set; }

        public string AnnonceEmail { get; set; }

        public string MaterialeEmail { get; set; }

        public string AnnonceKontrolEmail { get; set; }

        public string BilagsbladeEmail { get; set; }

        public int FakturaGruppeId { get; set; }

        public int? SalgsGruppeId { get; set; }

        public string GruppeRabat { get; set; }

        public string SamannonceringsRabat { get; set; }

        public bool? MaaGiveFarveRabat { get; set; }

        public bool GiverWebTillaeg { get; set; }

        public byte? OrdreDeadlineTekstDag { get; set; }

        public string OrdreDeadlineTekstKl { get; set; }

        public byte? MaterialeDeadlineTekstDag { get; set; }

        public string MaterialeDeadlineTekstKl { get; set; }

        public byte? OrdreDeadlineRubrikDag { get; set; }

        public string OrdreDeadlineRubrikKl { get; set; }

        public byte? MaterialeDeadlineRubrikDag { get; set; }

        public string MaterialeDeadlineRubrikKl { get; set; }

        public bool Overfoert { get; set; }

        public byte[] Timestamp { get; set; }
        public string DelOmraadeNavn { get;  set; }
        public string DagNavn { get;  set; }
        public string HovedGruppeNavn { get;  set; }
        public string GeoKodeNavn { get;  set; }
        public string RegionNavn { get; set; }
        public byte? setMedlemMaaned { set => medlemMaaned = value; }
        public string getMedlemMaaned { get
            {
                var maaned = "";
                switch(medlemMaaned)
                {
                    case 0:
                        maaned = "Januar";
                        break;
                    case 1:
                        maaned = "Februar";
                        break;
                    case 2:
                        maaned = "Marts";
                        break;
                    case 3:
                        maaned = "April";
                        break;
                    case 4:
                        maaned = "Maj";
                        break;
                    case 5:
                        maaned = "Juni";
                        break;
                    case 6:

                        maaned = "Juli";  
                        break;
                    case 7:
                        maaned = "August";
                        break;
                    case 8:
                        maaned = "September";
                        break;
                    case 9:
                        maaned = "Oktober";
                        break;
                    case 10:
                        maaned = "November";
                        break;
                    case 11:
                        maaned = "December";
                        break;

                }
                return maaned;
            } }
    }
}