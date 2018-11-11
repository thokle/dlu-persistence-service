using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class PrislisterPrBladÅr
    {
        public int BladID { get; set; }
        public short År { get; set; }
        public int PrislisteID { get; set; }
    }
}
