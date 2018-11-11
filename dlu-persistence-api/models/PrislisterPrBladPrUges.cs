using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class PrislisterPrBladPrUges
    {
        public int BladID { get; set; }
        public byte Uge { get; set; }
        public short År { get; set; }
        public int PrislisteID { get; set; }

    }
}
