using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class VisAnnoceFejl
    {
        private Int16 nr;
        private string navn;
        private int medieplanNr;
        private string annoncørNo_;
        private string fejlTekst;
        private Int16 version;
        private int ugeavisID;
        private Int16 indrykningsUge;

        public short Nr { get => nr; set => nr = value; }
        public string Navn { get => navn; set => navn = value; }
        public int MedieplanNr { get => medieplanNr; set => medieplanNr = value; }
        public string AnnoncørNo_ { get => annoncørNo_; set => annoncørNo_ = value; }
        public string FejlTekst { get => fejlTekst; set => fejlTekst = value; }
        public int UgeavisID { get => ugeavisID; set => ugeavisID = value; }
        public short IndrykningsUge { get => indrykningsUge; set => indrykningsUge = value; }
        public short Version { get => version; set => version = value; }
    }
}
