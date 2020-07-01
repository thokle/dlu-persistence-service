using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class AnnoceKontrol
    {
        private string navn;
        private int bladid;
        private byte indrykningsUge;

        public string Navn { get => navn; set => navn = value; }
        public int Bladid { get => bladid; set => bladid = value; }
        public byte IndrykningsUge { get => indrykningsUge; set => indrykningsUge = value; }
    }
}
