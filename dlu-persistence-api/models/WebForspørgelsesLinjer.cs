using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class WebForspørgelsesLinjer
    {
        private int forespørgselID;
        private int bladID;
        private decimal dLUMmPris;
        private double dLUMmRabat;
        private decimal dLUFarveTillæg;
        private double dLUFarveRabat;
        private string placeringUdenBeregning;
        private decimal bladMmPris;
        private double bladMmRabat;
        private decimal bladFarveTillæg;
        private double bladFarveRabat;
        private string bladBemærkning;
        private char navn;
        private string personNavn;

        public int ForespørgselID { get => forespørgselID; set => forespørgselID = value; }
        public int BladID { get => bladID; set => bladID = value; }
        public decimal DLUMmPris { get => dLUMmPris; set => dLUMmPris = value; }
        public double DLUMmRabat { get => dLUMmRabat; set => dLUMmRabat = value; }
        public decimal DLUFarveTillæg { get => dLUFarveTillæg; set => dLUFarveTillæg = value; }
        public double DLUFarveRabat { get => dLUFarveRabat; set => dLUFarveRabat = value; }
        public string PlaceringUdenBeregning { get => placeringUdenBeregning; set => placeringUdenBeregning = value; }
        
        public double BladMmRabat { get => bladMmRabat; set => bladMmRabat = value; }
        public decimal BladFarveTillæg { get => bladFarveTillæg; set => bladFarveTillæg = value; }
        public double BladFarveRabat { get => bladFarveRabat; set => bladFarveRabat = value; }
        public string BladBemærkning { get => bladBemærkning; set => bladBemærkning = value; }
        public char Navn { get => navn; set => navn = value; }
        public string PersonNavn { get => personNavn; set => personNavn = value; }
        public decimal BladMmPris { get => bladMmPris; set => bladMmPris = value; }
    }
}
