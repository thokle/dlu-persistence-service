using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class Bladdaeknik
    {
        private int BladID;
        private int Oplag;
        private int DaekningsGrad;
            private int PostNr;

        public int DaekningsGrad1 { get => DaekningsGrad; set => DaekningsGrad = value; }
        public int PostNr1 { get => PostNr; set => PostNr = value; }
        public int Oplag1 { get => Oplag; set => Oplag = value; }
        public int BladID1 { get => BladID; set => BladID = value; }
    }
}
