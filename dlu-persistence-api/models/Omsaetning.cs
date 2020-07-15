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
        private char delOmrådeKode;
        private int delOmrådeSortKey;
        private string hovedGruppeNavn;
        private int hovedGruppeSortKey;
        private string geoKodeNavn;
        private int geoKodeSortKey;
        private string konsulent;
       
        private int mmÅrNy;
        private int mmÅrGammel;
        private decimal prisÅrNy;
        private decimal PrisÅrGammel;
        private int indrykningsÅr;
        private int indrykningsUge;
        private string ejerforhold;
        private int sidePlacering;
        private decimal miljøTillægNy;

        private decimal miljøTillægGammel;
        private decimal godtgørelseNy;
        private decimal godtgørelseGammel;
        private int antalIndrykningerNy;

        private int antalIndrykningerGammel;
        private string format;

        public string Annoncør { get => annoncør; set => annoncør = value; }
        public string Bureau { get => bureau; set => bureau = value; }
        public string Ugeavis { get => ugeavis; set => ugeavis = value; }
        public char DelOmrådeKode { get => delOmrådeKode; set => delOmrådeKode = value; }
        public int DelOmrådeSortKey { get => delOmrådeSortKey; set => delOmrådeSortKey = value; }
        public string HovedGruppeNavn { get => hovedGruppeNavn; set => hovedGruppeNavn = value; }
        public int HovedGruppeSortKey { get => hovedGruppeSortKey; set => hovedGruppeSortKey = value; }
        public string GeoKodeNavn { get => geoKodeNavn; set => geoKodeNavn = value; }
        public int GeoKodeSortKey { get => geoKodeSortKey; set => geoKodeSortKey = value; }
        public string Konsulent { get => konsulent; set => konsulent = value; }
        public int MmÅrNy { get => mmÅrNy; set => mmÅrNy = value; }
        public int MmÅrGammel { get => mmÅrGammel; set => mmÅrGammel = value; }
        public decimal PrisÅrNy { get => prisÅrNy; set => prisÅrNy = value; }
        public decimal PrisÅrGammel1 { get => PrisÅrGammel; set => PrisÅrGammel = value; }
        public int IndrykningsÅr { get => indrykningsÅr; set => indrykningsÅr = value; }
        public int IndrykningsUge { get => indrykningsUge; set => indrykningsUge = value; }
        public string Ejerforhold { get => ejerforhold; set => ejerforhold = value; }
        public int SidePlacering { get => sidePlacering; set => sidePlacering = value; }
        public decimal MiljøTillægNy { get => miljøTillægNy; set => miljøTillægNy = value; }
        public decimal MiljøTillægGammel { get => miljøTillægGammel; set => miljøTillægGammel = value; }
        public decimal GodtgørelseNy { get => godtgørelseNy; set => godtgørelseNy = value; }
        public decimal GodtgørelseGammel { get => godtgørelseGammel; set => godtgørelseGammel = value; }
        public int AntalIndrykningerNy { get => antalIndrykningerNy; set => antalIndrykningerNy = value; }
        public int AntalIndrykningerGammel { get => antalIndrykningerGammel; set => antalIndrykningerGammel = value; }
        public string Format { get => format; set => format = value; }
    }
}
