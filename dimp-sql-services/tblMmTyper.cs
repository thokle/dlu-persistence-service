//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dimp_sql_services
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMmTyper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMmTyper()
        {
            this.tblOrdrers = new HashSet<tblOrdrer>();
            this.tblPlannerPlaners = new HashSet<tblPlannerPlaner>();
        }
    
        public byte mmType { get; set; }
        public string Betegnelse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblOrdrer> tblOrdrers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPlannerPlaner> tblPlannerPlaners { get; set; }
    }
}