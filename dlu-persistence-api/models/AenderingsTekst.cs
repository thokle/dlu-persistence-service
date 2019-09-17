using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
   public class AenderingsTekst
    {
        public int MedieplanNr { get; set; }
        public short Version { get; set; }
        public string AendringsTekst { get; set; }
    }
}
