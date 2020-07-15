using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class Omsaetning
    {
        private string annoncør;
        private string bureau;
        private string ugeavis;
        private string delOmrådeKode;
        private byte delOmrådeSortKey;
        private string hovedGruppeNavn;
        private byte hovedGruppeSortKey;
        private string geoKodeNavn;
        private byte geoKodeSortKey;
        private string konsulent;
       
        private int mmÅrNy;
        private int mmÅrGammel;
        private decimal? prisÅrNy;
        private decimal? PrisÅrGammel;
        private Int16 indrykningsÅr;
        private byte indrykningsUge;
        private string ejerforhold;
        private byte sidePlacering;
        private decimal? miljøTillægNy;

        private decimal? miljøTillægGammel;
        private decimal? godtgørelseNy;
        private decimal? godtgørelseGammel;
        private int antalIndrykningerNy;

        private int antalIndrykningerGammel;
        private string format;

        public string Annoncør { get => annoncør; set => annoncør = value; }
        public string Bureau { get => bureau; set => bureau = value; }
        public string Ugeavis { get => ugeavis; set => ugeavis = value; }
        public string DelOmrådeKode { get => delOmrådeKode; set => delOmrådeKode = value; }
        public byte DelOmrådeSortKey { get => delOmrådeSortKey; set => delOmrådeSortKey = value; }
        public string HovedGruppeNavn { get => hovedGruppeNavn; set => hovedGruppeNavn = value; }
        public byte HovedGruppeSortKey { get => hovedGruppeSortKey; set => hovedGruppeSortKey = value; }
        public string GeoKodeNavn { get => geoKodeNavn; set => geoKodeNavn = value; }
        public byte GeoKodeSortKey { get => geoKodeSortKey; set => geoKodeSortKey = value; }
        public string Konsulent { get => konsulent; set => konsulent = value; }
        public int MmÅrNy { get => mmÅrNy; set => mmÅrNy = value; }
        public int MmÅrGammel { get => mmÅrGammel; set => mmÅrGammel = value; }
        public decimal? PrisÅrNy { get => prisÅrNy; set => prisÅrNy = value; }
        public decimal? PrisÅrGammel1 { get => PrisÅrGammel; set => PrisÅrGammel = value; }
        public Int16 IndrykningsÅr { get => indrykningsÅr; set => indrykningsÅr = value; }
        public byte IndrykningsUge { get => indrykningsUge; set => indrykningsUge = value; }
        public string Ejerforhold { get => ejerforhold; set => ejerforhold = value; }
        public byte SidePlacering { get => sidePlacering; set => sidePlacering = value; }
        public decimal? MiljøTillægNy { get => miljøTillægNy; set => miljøTillægNy = value; }
        public decimal? MiljøTillægGammel { get => miljøTillægGammel; set => miljøTillægGammel = value; }
        public decimal? GodtgørelseNy { get => godtgørelseNy; set => godtgørelseNy = value; }
        public decimal? GodtgørelseGammel { get => godtgørelseGammel; set => godtgørelseGammel = value; }
        public int AntalIndrykningerNy { get => antalIndrykningerNy; set => antalIndrykningerNy = value; }
        public int AntalIndrykningerGammel { get => antalIndrykningerGammel; set => antalIndrykningerGammel = value; }
        public string Format { get => format; set => format = value; }
    }
}
