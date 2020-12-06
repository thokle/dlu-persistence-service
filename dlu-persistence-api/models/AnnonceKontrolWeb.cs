using dlu_persistence_api.daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class AnnonceKontrolWeb
    {
      private Int32 ordreNr;
       private Int32 slutVist;
       private string annoncor;
        private string betegenelse;
       private string format;
        private Byte antalFarver;
      private Int32 fejlID;
     private Byte erOrdre;
        private string farve;
       private string annoncorID;
        private Byte _mmType;
       private Int32 bladID;
      private Byte dPKulorID;
       private Int32 medieplanNr;
       private Int16 eXPR2;
       private Byte? sidePlacering;

       public int OrdreNr { get => ordreNr; set => ordreNr = value; }
      public Int32 SlutVist { get => slutVist; set => slutVist = value; }
       public string Annoncor { get => annoncor; set => annoncor = value; }
        public string Betegenelse { get => betegenelse; set => betegenelse = value; }
       public string Format { get => format; set => format = value; }
        public byte AntalFarver { get => antalFarver; set => antalFarver = value; }
     public Int32 FejlID { get => fejlID; set => fejlID = value; }
     public byte ErOrdre { get => erOrdre; set => erOrdre = value; }
       public string AnnoncorID { get => annoncorID; set => annoncorID = value; }
        public byte MmType { get => _mmType; set => _mmType = value; }
        public int BladID { get => bladID; set => bladID = value; }
        public Byte DPKulorID { get => dPKulorID; set => dPKulorID = value; }
        public int MedieplanNr { get => medieplanNr; set => medieplanNr = value; }
        public short EXPR2 { get => eXPR2; set => eXPR2 = value; }
       public byte? SidePlacering { get => sidePlacering; set => sidePlacering = value; }
    }
}
