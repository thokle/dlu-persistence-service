//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dlu_persistence_api
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegion()
        {
            this.tblBladStamdatas = new HashSet<tblBladStamdata>();
        }
    
        public byte RegionID { get; set; }
        public string RegionNavn { get; set; }
        public byte RegionSortKey { get; set; }
        public byte[] timestamp { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBladStamdata> tblBladStamdatas { get; set; }
    }
}
