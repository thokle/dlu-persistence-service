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
        private int ordreNr;
        private Boolean slutVist;
        private string annoncør;
        private string betegenelse;
        private string format;
        private Int16 antalFarver;
        private Int16 fejlID;
        private Int16 erOrdre;
        private string kulør;
        private string annoncørID;
        private Int16 _mmType;
        private int bladID;
        private Int16 dPKulørID;
        private Int16 version;
        private int medieplanNr;
        private Int16 eXPR2;
        private Int16 sidePlacering;

        public int OrdreNr { get => ordreNr; set => ordreNr = value; }
        public bool SlutVist { get => slutVist; set => slutVist = value; }
        public string Annoncør { get => annoncør; set => annoncør = value; }
        public string Betegenelse { get => betegenelse; set => betegenelse = value; }
        public string Format { get => format; set => format = value; }
        public short AntalFarver { get => antalFarver; set => antalFarver = value; }
        public short FejlID { get => fejlID; set => fejlID = value; }
        public short ErOrdre { get => erOrdre; set => erOrdre = value; }
        public string Kulør { get => kulør; set => kulør = value; }
        public string AnnoncørID { get => annoncørID; set => annoncørID = value; }
        public short MmType { get => _mmType; set => _mmType = value; }
        public int BladID { get => bladID; set => bladID = value; }
        public short DPKulørID { get => dPKulørID; set => dPKulørID = value; }
        public short Version { get => version; set => version = value; }
        public int MedieplanNr { get => medieplanNr; set => medieplanNr = value; }
        public short EXPR2 { get => eXPR2; set => eXPR2 = value; }
        public short SidePlacering { get => sidePlacering; set => sidePlacering = value; }
    }
}
