using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlu_persistence_api.models
{
    public class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
         
        }

        public byte RegionID { get; set; }
        public string RegionNavn { get; set; }
        public byte RegionSortKey { get; set; }
        public byte[] timestamp { get; set; }
    }
}
