using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class PriserForBlad
    {
        private int AAr;
        private int BladID;
        private string ControlNavn;
        private decimal? Farve4Max;
        private decimal? Farve4Min;
        private decimal? Farve4Pris;
        private decimal? FarveMax;
        private decimal? FarveMin;
        private decimal? FarvePris;
        private decimal? FormatFra;
        private int FormatTil;
        private int PlaceringID;
        private int PrislisteID;

        public int AAr1 { get => AAr; set => AAr = value; }
        public int BladID1 { get => BladID; set => BladID = value; }
        public string ControlNavn1 { get => ControlNavn; set => ControlNavn = value; }
       
        public decimal? Farve4Min1 { get => Farve4Min; set => Farve4Min = value; }
        public decimal? Farve4Pris1 { get => Farve4Pris; set => Farve4Pris = value; }
        public decimal? FarveMax1 { get => FarveMax; set => FarveMax = value; }
        public decimal? FarveMin1 { get => FarveMin; set => FarveMin = value; }
        public decimal? FarvePris1 { get => FarvePris; set => FarvePris = value; }
        public decimal? FormatFra1 { get => FormatFra; set => FormatFra = value; }
        public int FormatTil1 { get => FormatTil; set => FormatTil = value; }
        public int PlaceringID1 { get => PlaceringID; set => PlaceringID = value; }
        public int PrislisteID1 { get => PrislisteID; set => PrislisteID = value; }
        public decimal? Farve4Max1 { get => Farve4Max; set => Farve4Max = value; }
        public decimal? mmPris { get; internal set; }
    }
}
